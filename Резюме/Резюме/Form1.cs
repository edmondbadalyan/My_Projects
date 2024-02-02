namespace Резюме
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string fullname = textBoxFullname.Text;
            DateTime dateTime = DateTime.Parse(textBoxBD.Text);

            Employee employee = new Employee(fullname, dateTime);
            MessageBox.Show(employee.ToString());


        }
    }
}