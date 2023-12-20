using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsLab
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        // Ключевые переменные, значения +- такие же как в дизайнере, можно в загрузке формы захуячить значения из дизайнера
        SemaphoreSlim firstTollBooth = new SemaphoreSlim(1); // Семафор - збс хуйня
        SemaphoreSlim secondTollBooth = new SemaphoreSlim(1);
        private static int totalCars = 10; // Всего тачек
        private static int timeLimit1 = 3000; // Лимит по времени для первого пункта
        private static int timeLimit2 = 3000; // Лимит по времени для второго пункта

        public Form1()
        {
            InitializeComponent(); // Сама инициализация формы
            label1.Text = $"1й пунк количество шлагбаумов: {BarrierBar1.Value}";
            label2.Text = $"2й пунк количество шлагбаумов: {BarrierBar2.Value}";
            label3.Text = $"Количество автомобилей: {CarScrollBar.Value}";
        }

        private async void buttonStartSimulation_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add( // Не ебу нахуя тут это, но пусть будет
                $"Шлагбаумы: " +
                $"Пункт 1 - {(int)BarrierBar1.Value}, " +
                $"Пункт 2 - {(int)BarrierBar2.Value}, " +
                $"Автомобилей: {totalCars}"
                );

            List<Task> tasks = new List<Task>();

            for (int i = 1; i <= totalCars; i++) // Моделируем движение автомобилей в totalCars количестве
            {
                tasks.Add(SimulateCar(i));
                await Task.Delay(random.Next(1000, 3000)); // Интервал времени перед появлением следующего автомобиля
            }
            await Task.WhenAll(tasks); // Жду, когда вся хуйня закончиться
            listBox1.Items.Add("Все автомобили проехали.");
        }

        async Task SimulateCar(int carNumber) // Принимаем номер автомобиля
        {
            await firstTollBooth.WaitAsync(); // Заезд на первый пункт оплаты

            listBox1.Items.Add($"Автомобиль[{carNumber}] заехал на первый пункт оплаты."); // В листбокс хуячим ифну по автомобилю на первом пункте

            await Task.Delay(random.Next(1000, timeLimit1)); // Задержка на первом пункте

            firstTollBooth.Release(); // Освобождаем шлагбаум на первом пункте

            if (random.Next(0, 2) == 0) // С вероятностью 50% или 33%, я хуй знает, автомобиль покидает шоссе
            {
                listBox1.Items.Add($"Автомобиль[{carNumber}] покинул шоссе без проезда ко второму пункту.");
                return; // Выходим из функции, то что ниже, не выполняется
            }

            await secondTollBooth.WaitAsync(); // Заезд на второй пункт оплаты

            listBox1.Items.Add($"Автомобиль[{carNumber}] заехал на второй пункт оплаты.");

            await Task.Delay(random.Next(1000, timeLimit2)); // Задержка на втором пункте

            secondTollBooth.Release(); // Освобождаем шлагбаум на втором пункте

            listBox1.Items.Add($"Автомобиль[{carNumber}] успешно проехал через оба пункта оплаты.");

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

        private void CarScrollBar_Scroll(object sender, EventArgs e)
        {
            totalCars = (int)CarScrollBar.Value;
            label3.Text = $"Количество автомобилей: {totalCars}";
        }

        private void BarrierBar1_Scroll(object sender, EventArgs e)
        {
            firstTollBooth = new SemaphoreSlim(BarrierBar1.Value);
            label1.Text = $"1й пунк количество шлагбаумов: {BarrierBar1.Value}";
        }

        private void BarrierBar2_Scroll(object sender, EventArgs e)
        {
            secondTollBooth = new SemaphoreSlim(BarrierBar2.Value);
            label1.Text = $"2й пунк количество шлагбаумов: {BarrierBar2.Value}";
        }
    }
}  