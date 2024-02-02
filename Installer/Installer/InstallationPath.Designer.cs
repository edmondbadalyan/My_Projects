namespace Installer
{
    partial class InstallationPath
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            changeinstallationPath = new Button();
            label1 = new Label();
            nextButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // changeinstallationPath
            // 
            changeinstallationPath.Location = new Point(529, 119);
            changeinstallationPath.Name = "changeinstallationPath";
            changeinstallationPath.Size = new Size(99, 46);
            changeinstallationPath.TabIndex = 1;
            changeinstallationPath.Text = "Выбрать путь установки";
            changeinstallationPath.UseVisualStyleBackColor = true;
            changeinstallationPath.Click += changeinstallationPath_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 140);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 2;
            label1.Text = "Путь установки";
            // 
            // nextButton
            // 
            nextButton.Location = new Point(135, 334);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(156, 59);
            nextButton.TabIndex = 3;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(472, 334);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(156, 59);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // InstallationPath
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelButton);
            Controls.Add(nextButton);
            Controls.Add(label1);
            Controls.Add(changeinstallationPath);
            Controls.Add(textBox1);
            Name = "InstallationPath";
            Text = "InstallationPath";
            Load += InstallationPath_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button changeinstallationPath;
        private Label label1;
        private Button nextButton;
        private Button cancelButton;
    }
}