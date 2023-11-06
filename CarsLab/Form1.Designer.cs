namespace CarsLab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownBooths1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBooths2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Time1Bar = new System.Windows.Forms.TrackBar();
            this.Time3Bar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBooths1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBooths2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time1Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time3Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(552, 612);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Запуск симуляцию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonStartSimulation_Click);
            // 
            // numericUpDownBooths1
            // 
            this.numericUpDownBooths1.Location = new System.Drawing.Point(570, 12);
            this.numericUpDownBooths1.Name = "numericUpDownBooths1";
            this.numericUpDownBooths1.Size = new System.Drawing.Size(65, 22);
            this.numericUpDownBooths1.TabIndex = 2;
            this.numericUpDownBooths1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBooths1.ValueChanged += new System.EventHandler(this.numericUpDownBarrier1_ValueChanged);
            // 
            // numericUpDownBooths2
            // 
            this.numericUpDownBooths2.Location = new System.Drawing.Point(570, 40);
            this.numericUpDownBooths2.Name = "numericUpDownBooths2";
            this.numericUpDownBooths2.Size = new System.Drawing.Size(65, 22);
            this.numericUpDownBooths2.TabIndex = 3;
            this.numericUpDownBooths2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBooths2.ValueChanged += new System.EventHandler(this.numericUpDownBarrier2_ValueChanged);
            // 
            // numericUpDownCar
            // 
            this.numericUpDownCar.Location = new System.Drawing.Point(570, 68);
            this.numericUpDownCar.Name = "numericUpDownCar";
            this.numericUpDownCar.Size = new System.Drawing.Size(65, 22);
            this.numericUpDownCar.TabIndex = 4;
            this.numericUpDownCar.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCar.ValueChanged += new System.EventHandler(this.numericUpDownCars_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "1й пунк кол-во шлагбаумов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "2й пунк кол-во шлагбаумов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кол-во автомобилей";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(570, 249);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(335, 22);
            this.progressBar.TabIndex = 8;
            // 
            // Time1Bar
            // 
            this.Time1Bar.Location = new System.Drawing.Point(570, 96);
            this.Time1Bar.Maximum = 15;
            this.Time1Bar.Minimum = 3;
            this.Time1Bar.Name = "Time1Bar";
            this.Time1Bar.Size = new System.Drawing.Size(335, 56);
            this.Time1Bar.TabIndex = 9;
            this.Time1Bar.Value = 3;
            this.Time1Bar.Scroll += new System.EventHandler(this.Time1Bar_Scroll);
            // 
            // Time3Bar
            // 
            this.Time3Bar.Location = new System.Drawing.Point(570, 158);
            this.Time3Bar.Maximum = 15;
            this.Time3Bar.Minimum = 3;
            this.Time3Bar.Name = "Time3Bar";
            this.Time3Bar.Size = new System.Drawing.Size(335, 56);
            this.Time3Bar.TabIndex = 9;
            this.Time3Bar.Value = 3;
            this.Time3Bar.Scroll += new System.EventHandler(this.Time2Bar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Лимит задержки на 1ом пункте оплаты: 3000 мс";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Лимит задержки на 2ом пункте оплаты: 3000 мс";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 635);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Time3Bar);
            this.Controls.Add(this.Time1Bar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownCar);
            this.Controls.Add(this.numericUpDownBooths2);
            this.Controls.Add(this.numericUpDownBooths1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBooths1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBooths2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time1Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time3Bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownBooths1;
        private System.Windows.Forms.NumericUpDown numericUpDownBooths2;
        private System.Windows.Forms.NumericUpDown numericUpDownCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TrackBar Time1Bar;
        private System.Windows.Forms.TrackBar Time3Bar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

