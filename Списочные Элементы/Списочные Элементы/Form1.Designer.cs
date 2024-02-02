namespace Списочные_Элементы
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
            comboBoxCountry = new ComboBox();
            comboBoxCity = new ComboBox();
            comboBoxStreet = new ComboBox();
            comboBoxHouse = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(306, 85);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(121, 23);
            comboBoxCountry.TabIndex = 0;
            comboBoxCountry.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(306, 149);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(121, 23);
            comboBoxCity.TabIndex = 1;
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            // 
            // comboBoxStreet
            // 
            comboBoxStreet.FormattingEnabled = true;
            comboBoxStreet.Location = new Point(306, 220);
            comboBoxStreet.Name = "comboBoxStreet";
            comboBoxStreet.Size = new Size(121, 23);
            comboBoxStreet.TabIndex = 2;
            comboBoxStreet.SelectedIndexChanged += comboBoxStreet_SelectedIndexChanged;
            // 
            // comboBoxHouse
            // 
            comboBoxHouse.FormattingEnabled = true;
            comboBoxHouse.Location = new Point(306, 288);
            comboBoxHouse.Name = "comboBoxHouse";
            comboBoxHouse.Size = new Size(121, 23);
            comboBoxHouse.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 93);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 4;
            label1.Text = "Страна";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 157);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Город";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 228);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Улица";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 291);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 7;
            label4.Text = "Дом";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(292, 340);
            button1.Name = "button1";
            button1.Size = new Size(148, 53);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxHouse);
            Controls.Add(comboBoxStreet);
            Controls.Add(comboBoxCity);
            Controls.Add(comboBoxCountry);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCountry;
        private ComboBox comboBoxCity;
        private ComboBox comboBoxStreet;
        private ComboBox comboBoxHouse;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
