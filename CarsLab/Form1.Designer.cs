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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Time1Bar = new System.Windows.Forms.TrackBar();
            this.Time3Bar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CarScrollBar = new System.Windows.Forms.TrackBar();
            this.BarrierBar1 = new System.Windows.Forms.TrackBar();
            this.BarrierBar2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.Time1Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time3Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarScrollBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarrierBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarrierBar2)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(570, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonStartSimulation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "1й пунк количество шлагбаумов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "2й пунк количество шлагбаумов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество автомобилей";
            // 
            // Time1Bar
            // 
            this.Time1Bar.Location = new System.Drawing.Point(570, 188);
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
            this.Time3Bar.Location = new System.Drawing.Point(570, 250);
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
            this.label4.Location = new System.Drawing.Point(570, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Лимит задержки на 1ом пункте оплаты: 3000 мс";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Лимит задержки на 2ом пункте оплаты: 3000 мс";
            // 
            // CarScrollBar
            // 
            this.CarScrollBar.Location = new System.Drawing.Point(570, 11);
            this.CarScrollBar.Maximum = 100;
            this.CarScrollBar.Minimum = 1;
            this.CarScrollBar.Name = "CarScrollBar";
            this.CarScrollBar.Size = new System.Drawing.Size(332, 56);
            this.CarScrollBar.TabIndex = 12;
            this.CarScrollBar.Value = 1;
            this.CarScrollBar.Scroll += new System.EventHandler(this.CarScrollBar_Scroll);
            // 
            // BarrierBar1
            // 
            this.BarrierBar1.Location = new System.Drawing.Point(570, 64);
            this.BarrierBar1.Maximum = 8;
            this.BarrierBar1.Minimum = 1;
            this.BarrierBar1.Name = "BarrierBar1";
            this.BarrierBar1.Size = new System.Drawing.Size(332, 56);
            this.BarrierBar1.TabIndex = 13;
            this.BarrierBar1.Value = 1;
            this.BarrierBar1.Scroll += new System.EventHandler(this.BarrierBar1_Scroll);
            // 
            // BarrierBar2
            // 
            this.BarrierBar2.Location = new System.Drawing.Point(570, 126);
            this.BarrierBar2.Maximum = 8;
            this.BarrierBar2.Minimum = 1;
            this.BarrierBar2.Name = "BarrierBar2";
            this.BarrierBar2.Size = new System.Drawing.Size(332, 56);
            this.BarrierBar2.TabIndex = 14;
            this.BarrierBar2.Value = 1;
            this.BarrierBar2.Scroll += new System.EventHandler(this.BarrierBar2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Time3Bar);
            this.Controls.Add(this.Time1Bar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BarrierBar2);
            this.Controls.Add(this.BarrierBar1);
            this.Controls.Add(this.CarScrollBar);
            this.Name = "Form1";
            this.Text = "Симулятор КПП";
            ((System.ComponentModel.ISupportInitialize)(this.Time1Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time3Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarScrollBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarrierBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarrierBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar Time1Bar;
        private System.Windows.Forms.TrackBar Time3Bar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar CarScrollBar;
        private System.Windows.Forms.TrackBar BarrierBar1;
        private System.Windows.Forms.TrackBar BarrierBar2;
    }
}

 