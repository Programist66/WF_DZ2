namespace WF_DZ2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            redSlider = new TrackBar();
            greenSlider = new TrackBar();
            label2 = new Label();
            blueSlider = new TrackBar();
            label3 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            totalPrice = new Label();
            label7 = new Label();
            datesWork = new MonthCalendar();
            priceDay = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)redSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceDay).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(2, 10);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1310, 23);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(34, 118);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 1;
            label1.Text = "красный";
            // 
            // redSlider
            // 
            redSlider.Location = new Point(136, 109);
            redSlider.Maximum = 255;
            redSlider.Name = "redSlider";
            redSlider.Size = new Size(1042, 45);
            redSlider.TabIndex = 2;
            redSlider.TickStyle = TickStyle.Both;
            redSlider.Value = 255;
            redSlider.ValueChanged += redSlider_ValueChanged;
            // 
            // greenSlider
            // 
            greenSlider.Location = new Point(136, 160);
            greenSlider.Maximum = 255;
            greenSlider.Name = "greenSlider";
            greenSlider.Size = new Size(1042, 45);
            greenSlider.TabIndex = 4;
            greenSlider.TickStyle = TickStyle.Both;
            greenSlider.Value = 255;
            greenSlider.ValueChanged += greenSlider_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(34, 169);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 3;
            label2.Text = "зеленый";
            // 
            // blueSlider
            // 
            blueSlider.Location = new Point(136, 211);
            blueSlider.Maximum = 255;
            blueSlider.Name = "blueSlider";
            blueSlider.Size = new Size(1042, 45);
            blueSlider.TabIndex = 6;
            blueSlider.TickStyle = TickStyle.Both;
            blueSlider.Value = 255;
            blueSlider.ValueChanged += blueSlider_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(34, 220);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 5;
            label3.Text = "синий";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(647, 323);
            label5.Name = "label5";
            label5.Size = new Size(175, 15);
            label5.TabIndex = 9;
            label5.Text = "Введите стоимость одного для";
            // 
            // totalPrice
            // 
            totalPrice.AutoSize = true;
            totalPrice.Location = new Point(719, 529);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(103, 15);
            totalPrice.TabIndex = 11;
            totalPrice.Text = "Итоговая сумма: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(391, 325);
            label7.Name = "label7";
            label7.Size = new Size(218, 15);
            label7.TabIndex = 13;
            label7.Text = "Введите дату начала/окончания работ";
            // 
            // datesWork
            // 
            datesWork.Location = new Point(411, 349);
            datesWork.MaxSelectionCount = 999999999;
            datesWork.Name = "datesWork";
            datesWork.ShowToday = false;
            datesWork.TabIndex = 12;
            datesWork.DateChanged += datesWork_DateChanged;
            // 
            // priceDay
            // 
            priceDay.Location = new Point(839, 321);
            priceDay.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            priceDay.Name = "priceDay";
            priceDay.Size = new Size(120, 23);
            priceDay.TabIndex = 14;
            priceDay.ValueChanged += priceDay_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 633);
            Controls.Add(priceDay);
            Controls.Add(label7);
            Controls.Add(datesWork);
            Controls.Add(totalPrice);
            Controls.Add(label5);
            Controls.Add(blueSlider);
            Controls.Add(label3);
            Controls.Add(greenSlider);
            Controls.Add(label2);
            Controls.Add(redSlider);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)redSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private TrackBar redSlider;
        private TrackBar greenSlider;
        private Label label2;
        private TrackBar blueSlider;
        private Label label3;
        private System.Windows.Forms.Timer timer;
        private Label label5;
        private Label totalPrice;
        private Label label7;
        private MonthCalendar datesWork;
        private NumericUpDown priceDay;
    }
}
