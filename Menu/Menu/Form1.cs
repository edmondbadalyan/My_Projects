
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        private string currentFileName = "";
        public Form1()
        {
            InitializeComponent();
            UpdateStatusStrip();
        }
        private void UpdateStatusStrip()
        {
            toolStripStatusLabel1.Text = "Document: " + Path.GetFileName(currentFileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            currentFileName = "";
            UpdateStatusStrip();

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentFileName = ofd.FileName;
                textBox1.Text = File.ReadAllText(currentFileName);
                UpdateStatusStrip();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentFileName))
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else { File.WriteAllText(currentFileName, textBox1.Text); }
            UpdateStatusStrip();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFileName = saveFileDialog.FileName;
                File.WriteAllText(currentFileName, textBox1.Text);
                UpdateStatusStrip();
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem_Click(sender, e);
        }
    }
}
