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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBooths1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBooths2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCar)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(570, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Simulation";
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
            this.progressBar.Location = new System.Drawing.Point(570, 125);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(305, 22);
            this.progressBar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 635);
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
    }
}

