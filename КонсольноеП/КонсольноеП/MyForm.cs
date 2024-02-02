using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КонсольноеП
{
    internal class MyForm : Form
    {

        public MyForm()
        {
            InitializeComponent();

        }
        private void InitializeComponent()
        {
            button = new Button();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(-5, -4);
            button.Name = "button";
            button.Size = new Size(100, 100);
            button.TabIndex = 0;
            button.Text = "нажми меня";
            // 
            // MyForm
            // 
            BackColor = Color.Green;
            ClientSize = new Size(784, 69);
            Controls.Add(button);
            Name = "MyForm";
            Text = "Привет Денис";
            Load += MyForm_Load;
            ResumeLayout(false);
        }

        private void MyForm_Load(object sender, EventArgs e)
        {

        }

        private Button button;
    }
}
