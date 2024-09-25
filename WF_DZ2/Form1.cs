namespace WF_DZ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateColor();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer.Stop();
            }
        }

        private void redSlider_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void greenSlider_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void blueSlider_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void UpdateColor()
        {
            this.BackColor = Color.FromArgb(redSlider.Value, greenSlider.Value, blueSlider.Value);
        }

        private void CalculatePrice()
        {
            totalPrice.Text = $"Итоговая сумма: {priceDay.Value * (int)Math.Ceiling((datesWork.SelectionEnd - datesWork.SelectionStart).TotalDays)}";
        }

        private void datesWork_DateChanged(object sender, DateRangeEventArgs e)
        {
            CalculatePrice();
        }

        private void priceDay_ValueChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
    }
}
