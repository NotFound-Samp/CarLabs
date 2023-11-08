using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// Будет добавлена сводка автомобилей, добавлены счётчики времени, возможно таблица для построения графиков

namespace CarsLab
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stopwatch stopwatch = new Stopwatch();
        // Ключевые переменные, экземляры, значения такие же как в дизайнере, можно в инициализации формы захуячить значения из дизайнера
        SemaphoreSlim firstTollBooth = new SemaphoreSlim(1); // Семафор - збс хуйня
        SemaphoreSlim secondTollBooth = new SemaphoreSlim(1);
        private static int totalCars = 10; // Всего тачек
        private static int timeLimit1 = 3000; // Лимит по времени для первого пункта
        private static int timeLimit2 = 3000; // Лимит по времени для второго пункта
        private static int travelTime = 1000; // Время в пути
        private static int chancedOutCar = 50;
        private static int compliteCar = 0; // Автомобили, которые проехали первый пункт
        private static int outCar = 0; // Автомобили, которые покинули шоссе
        private static int finishCar = 0; // Автомобили, которые проехали оба пункта

        public Form1()
        {
            InitializeComponent(); // Сама инициализация формы
        }
        private async void buttonStartSimulation_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = totalCars; // Макс. значение прогресс бара это кол-во машин
            progressBar.Value = 0;

            compliteCar = 0;
            outCar = 0;
            finishCar = 0;

            listBox1.Items.Clear();

            labelInfo.Text = 
                $"Шлагбаумы: \n" +
                $"Первый пункт: {(int)numericUpDownBooths1.Value}\n" +
                $"Второй пункт: {(int)numericUpDownBooths2.Value}.\n" +
                $"Количество автомобилей: {totalCars}.";

            List<Task> tasks = new List<Task>();

            stopwatch.Start();

            for (int i = 1; i <= totalCars; i++) // Моделируем движение автомобилей в totalCars количестве
            {
                tasks.Add(SimulateCar(i));
                await Task.Delay(random.Next(1000, 2000));
            }    
                
            await Task.WhenAll(tasks); // Жду, когда вся хуйня закончиться

            stopwatch.Stop();
            long executionTime = stopwatch.ElapsedMilliseconds;

            listBox1.Items.Add($"[{CurrentTime()}] Все автомобили проехали.");
            labelInfo.Text +=
                $"\nКол-во автомобилей проехавших 2 пункта: {finishCar}," +
                $"\nКол-во автомобилей покинувших шоссе: {outCar}." +
                $"\nВремя выполнения симуляции: {executionTime} мс.";
            labelFinish.Text = "";
        }
        async Task SimulateCar(int carNumber) // Принимаем номер автомобиля
        {
            await firstTollBooth.WaitAsync(); // Заезд на первый пункт оплаты
            UpdateLabelInfo();

            listBox1.Items.Add($"[{CurrentTime()}] Автомобиль[{carNumber}] заехал на первый пункт оплаты."); // В листбокс хуячим ифну по автомобилю на первом пункте

            await Task.Delay(random.Next(1000, timeLimit1)); // Задержка на первом пункте

            listBox1.Items.Add($"[{CurrentTime()}] Автомобиль[{carNumber}] проехал первый пункт оплаты.");
            
            firstTollBooth.Release(); // Освобождаем шлагбаум на первом пункте
            compliteCar += 1;
            UpdateLabelInfo();

            await Task.Delay(travelTime);

            if (random.Next(0, 100) <= chancedOutCar) // С вероятностью 50% или 33%, я хуй знает, автомобиль покидает шоссе
            {
                listBox1.Items.Add($"[{CurrentTime()}] Автомобиль[{carNumber}] покинул шоссе без проезда ко второму пункту.");
                progressBar.Invoke((MethodInvoker)(() => progressBar.Value++)); // Когда автомобиль съебался, увеличиваю значение прогрессбара
                outCar += 1;
                UpdateLabelInfo();
                return; // Выходим из функции, то что ниже, не выполняется
            }

            await secondTollBooth.WaitAsync(); // Заезд на второй пункт оплаты

            listBox1.Items.Add($"[{CurrentTime()}] Автомобиль[{carNumber}] заехал на второй пункт оплаты.");
            
            await Task.Delay(random.Next(1000, timeLimit2)); // Задержка на втором пункте

            secondTollBooth.Release(); // Освобождаем шлагбаум на втором пункте

            listBox1.Items.Add($"[{CurrentTime()}] Автомобиль[{carNumber}] проехал через оба пункта оплаты.");

            progressBar.Invoke((MethodInvoker)(() => progressBar.Value++));
            finishCar += 1;
            UpdateLabelInfo();
        }
        private void numericUpDownBarrier1_ValueChanged(object sender, EventArgs e) // Метод, который хукает эвент нажатия inputInt и увеличивает/уменьшает своё значение
        {
            firstTollBooth = new SemaphoreSlim(MathClamp((int)numericUpDownBooths1.Value, 1, 100));
        }
        private void numericUpDownBarrier2_ValueChanged(object sender, EventArgs e)
        {
            secondTollBooth = new SemaphoreSlim(MathClamp((int)numericUpDownBooths2.Value, 1, 100)); 
        }
        private void numericUpDownCars_ValueChanged(object sender, EventArgs e)
        {
            totalCars = MathClamp((int)numericUpDownCar.Value, 1, 100);
        }
        private void Time1Bar_Scroll(object sender, EventArgs e) // Слайдер, какого-то хуя он тут называется TrackBar, разраб долбаёб. То же самое, что выше, ток тут ползунок
        {
            timeLimit1 = Time1Bar.Value*1000; // Слайдер выдаёт число от 3 до 15(Можно больше, но в целом похуй) и умножает его на 1000, чтобы получить секунды
            label4.Text = $"Лимит задержки на 1ом пункте оплаты: {timeLimit1} мс";
        }
        private void Time2Bar_Scroll(object sender, EventArgs e)
        {
            timeLimit2 = Time3Bar.Value*1000;
            label5.Text = $"Лимит задержки на 2ом пункте оплаты: {timeLimit2} мс";
        }
        private void chancedBar_Scroll(object sender, EventArgs e)
        {
            chancedOutCar = chancedBar.Value;
            chancedValue.Text = $"Шанс съезда автомобиля с шоссе: {chancedOutCar}%";
        }
        private void travelTimeBar_Scroll(object sender, EventArgs e)
        {
            travelTime = travelTimeBar.Value*1000;
            label6.Text = $"Время в пути: {travelTime} мс";
        }
        private void UpdateLabelInfo()
        {
            int temp1 = totalCars - compliteCar - (int)numericUpDownBooths1.Value;
            int temp2 = compliteCar - outCar - finishCar - (int)numericUpDownBooths2.Value;
            if (temp1 < 0)
                temp1 = 0;
            if (temp2 < 0)
                temp2 = 0;
            labelFinish.Text = $"Автомобилей в очереди на первый пункт: {temp1},\nАвтомобилей в очеди на второй пункт: {temp2}.";
        }
        private int MathClamp(int number, int minLimit, int maxLimit)
        {
            if (number <= minLimit)
                number = minLimit;
            else if (number >= maxLimit)
                number = maxLimit;
            return number;
        }
        private TimeSpan CurrentTime()
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            TimeSpan currentTimeWithoutMilliseconds = new TimeSpan(currentTime.Hours, currentTime.Minutes, currentTime.Seconds);
            return currentTimeWithoutMilliseconds;
        }


    }
}
// По итогу лаба - хуйня, препод - еблан, а из готового продукта надо удалять все комментарии, но это Pre-released, так что хуй там. Чурка лох кста