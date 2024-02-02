using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class InstallationPath : Form
    {

        public InstallationPath()
        {
            InitializeComponent();

        }

        private void changeinstallationPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {


                folderBrowser.SelectedPath = changeinstallationPath.Text;


                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {


                    changeinstallationPath.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InstallationPath_Load(object sender, EventArgs e)
        {
            textBox1.Text = "C:\\Program Files\\MyApplication";
        }
    }
}
