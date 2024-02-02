namespace Installer
{
    public partial class Form1 : Form
    {

        public List<string> SelectedFeatures { get; set; }
        public string InstallationPath { get; set; }

        public Form1()
        {
            InitializeComponent();
            SelectedFeatures = new List<string>();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            Features_form features_Form = new Features_form();
           
            features_Form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
