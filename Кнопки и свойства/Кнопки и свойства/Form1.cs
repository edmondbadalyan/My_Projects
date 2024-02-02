namespace Кнопки_и_свойства
{
    public partial class Form1 : Form
    {
        private int colorIndex = 0;
        private Color[] colors = { Color.Red, Color.Yellow, Color.Green };
        public Form1()
        {
            InitializeComponent();
        }

        private void GetsRandomArea_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int newX = random.Next(0, ClientSize.Width - GetsRandomArea.Width);
            int newY = random.Next(0, ClientSize.Height - GetsRandomArea.Height);

            GetsRandomArea.Location = new Point(newX, newY);
        }

        private void GetNewAreaForm_Click(object sender, EventArgs e)
        {
            Random newRandom = new Random();

            int newX = new Random().Next(0, ClientSize.Width);

            int newY = new Random().Next(0, ClientSize.Height);

            Location = new(newX, newY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeButtonColor.BackColor = colors[colorIndex];

            colorIndex = (colorIndex + 1) % colors.Length;
        }
         
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
