namespace Кнопки_и_свойства
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
            GetsRandomArea = new Button();
            GetNewAreaForm = new Button();
            ChangeButtonColor = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // GetsRandomArea
            // 
            GetsRandomArea.Location = new Point(66, 285);
            GetsRandomArea.Name = "GetsRandomArea";
            GetsRandomArea.Size = new Size(170, 80);
            GetsRandomArea.TabIndex = 0;
            GetsRandomArea.Text = "Переместить кнопку внутри формы!";
            GetsRandomArea.UseVisualStyleBackColor = true;
            GetsRandomArea.Click += GetsRandomArea_Click;
            // 
            // GetNewAreaForm
            // 
            GetNewAreaForm.Location = new Point(47, 60);
            GetNewAreaForm.Name = "GetNewAreaForm";
            GetNewAreaForm.Size = new Size(189, 84);
            GetNewAreaForm.TabIndex = 1;
            GetNewAreaForm.Text = "Переместить саму форму!";
            GetNewAreaForm.UseVisualStyleBackColor = true;
            GetNewAreaForm.Click += GetNewAreaForm_Click;
            // 
            // ChangeButtonColor
            // 
            ChangeButtonColor.BackColor = Color.White;
            ChangeButtonColor.Location = new Point(389, 60);
            ChangeButtonColor.Name = "ChangeButtonColor";
            ChangeButtonColor.Size = new Size(348, 101);
            ChangeButtonColor.TabIndex = 2;
            ChangeButtonColor.Text = "Поменять цвет кнопки!";
            ChangeButtonColor.UseVisualStyleBackColor = false;
            ChangeButtonColor.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(504, 285);
            button1.Name = "button1";
            button1.Size = new Size(248, 114);
            button1.TabIndex = 3;
            button1.Text = "Закрыть всю форму!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ChangeButtonColor);
            Controls.Add(GetNewAreaForm);
            Controls.Add(GetsRandomArea);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button GetsRandomArea;
        private Button GetNewAreaForm;
        private Button ChangeButtonColor;
        private Button button1;
    }
}