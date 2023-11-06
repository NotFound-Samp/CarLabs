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
        SemaphoreSlim firstTollBooth = new SemaphoreSlim(1);
        SemaphoreSlim secondTollBooth = new SemaphoreSlim(1);
        private static int totalCars = 10;
        private static int timeLimit1 = 3000;
        private static int timeLimit2 = 3000;

        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonStartSimulation_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = totalCars;
            progressBar.Value = 0;

            listBox1.Items.Add(
                $"Шлагбаумы: " +
                $"Пункт 1 - {(int)numericUpDownBooths1.Value}, " +
                $"Пункт 2 - {(int)numericUpDownBooths2.Value}, " +
                $"Автомобилей: {totalCars}"
                );

            List<Task> tasks = new List<Task>();

            for (int i = 1; i <= totalCars; i++) // Моделируем движение 10 автомобилей
            {
                tasks.Add(SimulateCar(i));
                await Task.Delay(random.Next(1000, 3000)); // Интервал времени перед появлением следующего автомобиля
            }
            await Task.WhenAll(tasks);
            listBox1.Items.Add("Все автомобили проехали.");
        }

        async Task SimulateCar(int carNumber) // Принимаем номер автомобиля
        {
            await firstTollBooth.WaitAsync(); // Заезд на первый пункт оплаты

            listBox1.Items.Add($"Автомобиль[{carNumber}] заехал на первый пункт оплаты."); // Используем номер автомобиля

            await Task.Delay(random.Next(1000, timeLimit1)); // Задержка на первом пункте

            firstTollBooth.Release(); // Освобождаем шлагбаум на первом пункте

            if (random.Next(0, 2) == 0) // С вероятностью 50% автомобиль покидает шоссе
            {
                listBox1.Items.Add($"Автомобиль[{carNumber}] покинул шоссе без проезда ко второму пункту.");
                progressBar.Invoke((MethodInvoker)(() => progressBar.Value++));
                return;
            }

            await secondTollBooth.WaitAsync(); // Заезд на второй пункт оплаты

            listBox1.Items.Add($"Автомобиль[{carNumber}] заехал на второй пункт оплаты.");

            await Task.Delay(random.Next(1000, timeLimit2)); // Задержка на втором пункте

            secondTollBooth.Release(); // Освобождаем шлагбаум на втором пункте

            listBox1.Items.Add($"Автомобиль[{carNumber}] успешно проехал через оба пункта оплаты.");

            progressBar.Invoke((MethodInvoker)(() => progressBar.Value++));
        }

        private void numericUpDownBarrier1_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDownBooths1.Value < 1)
                numericUpDownBooths1.Value = 1;
            firstTollBooth = new SemaphoreSlim((int)numericUpDownBooths1.Value);
        }

        private void numericUpDownBarrier2_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDownBooths2.Value < 1)
                numericUpDownBooths2.Value = 1;
            secondTollBooth = new SemaphoreSlim((int)numericUpDownBooths2.Value);
        }

        private void numericUpDownCars_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDownCar.Value < 1)
                numericUpDownCar.Value = 1;
            totalCars = (int)numericUpDownCar.Value;
        }

        private void Time1Bar_Scroll(object sender, EventArgs e)
        {
            timeLimit1 = Time1Bar.Value;
            label4.Text = $"Лимит задержки на 1ом пункте оплаты: {Time1Bar.Value} мс";
        }

        private void Time2Bar_Scroll(object sender, EventArgs e)
        {
            timeLimit2 = Time3Bar.Value;
            label5.Text = $"Лимит задержки на 2ом пункте оплаты: {Time3Bar.Value} мс";
        }
    }
}
