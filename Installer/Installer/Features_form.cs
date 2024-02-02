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
    public partial class Features_form : Form
    {

        public Features_form()
        {
            InitializeComponent();
        }

        public Features_form(IContainer components, CheckedListBox checkListBox_Values, Form1 form1)
        {
            this.components = components;
            checkListBox_Values.SelectedValue = form1.SelectedFeatures;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Features_form_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            InstallationPath installationPath = new InstallationPath();
             installationPath.ShowDialog();
        }
    }
}
