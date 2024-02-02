using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Control_Elements
{
    public partial class Form1 : Form
    {

        private ErrorProvider errorProvider;
        public Form1()
        {
            InitializeComponent();
            Shown += (sender, e) => timer1.Start();


        }



        private void progressBar1_Click(object sender, EventArgs e)
        {



        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            progressBar1.Value += 1;


            if (progressBar1.Value >= progressBar1.Maximum)
            {

                timer1.Stop();
            }
        }


        private void OnSliderScroll(object sender, EventArgs e)
        {

            UpdateFormColor();
        }
        private void UpdateFormColor()
        {
            trackBarRed.Minimum = 0;
            trackBarRed.Maximum = 255;

            trackBarGreen.Minimum = 0;
            trackBarGreen.Maximum = 255;

            trackBarBlue.Minimum = 0;
            trackBarBlue.Maximum = 255;


            int redValue = trackBarRed.Value;
            int greenValue = trackBarGreen.Value;
            int blueValue = trackBarBlue.Value;


            Color newColor = Color.FromArgb(255, redValue, greenValue, blueValue);


            BackColor = newColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;
            //  double costPerDay = double.Parse(costPerDayTextBox.Text);

            if (startDate > endDate || startDate < DateTime.Now || endDate < DateTime.Now)
            {
                MessageBox.Show("Проверьте корректность введенных дат.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (!double.TryParse(costPerDayTextBox.Text, out double costPerDay) || costPerDay <= 0)
            {
                MessageBox.Show("Введите корректную стоимость одного дня работы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int daysOfWork = (int)(endDate - startDate).TotalDays;
            double totalCost = daysOfWork * costPerDay;

            resultLabel.Text = $"Стоимость работ: {totalCost:C}";



        }

        private void validateEmail_Click(object sender, EventArgs e)
        {

            string email = emalTextBox.Text;

            if (IsValidEmail(email))
            {
                MessageBox.Show("Адрес электронной почты правильно сформирован.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.SetError(emalTextBox, "");

            }
            else
            {
                MessageBox.Show("Некорректный формат адреса электронной почты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(emalTextBox, "Некорректный формат адреса");
            }


        }
        static bool IsValidEmail(string email)
        {
            try
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(email);
            }
            catch (FormatException)
            {
                return false;
            }
            //string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            //Regex regex = new Regex(pattern);

            //return regex.IsMatch(email);
        }



    }
}
