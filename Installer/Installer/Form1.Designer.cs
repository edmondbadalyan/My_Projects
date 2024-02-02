namespace Installer
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
            label1 = new Label();
            Next_button = new Button();
            Cancel_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(45, 45);
            label1.Name = "label1";
            label1.Size = new Size(726, 30);
            label1.TabIndex = 0;
            label1.Text = "Вас приветсвует Мастер установки, сейчас что-нибудь да установим.";
            // 
            // Next_button
            // 
            Next_button.Location = new Point(122, 329);
            Next_button.Name = "Next_button";
            Next_button.Size = new Size(186, 65);
            Next_button.TabIndex = 1;
            Next_button.Text = "Next";
            Next_button.UseVisualStyleBackColor = true;
            Next_button.Click += Next_button_Click;
            // 
            // Cancel_button
            // 
            Cancel_button.Location = new Point(494, 329);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(186, 65);
            Cancel_button.TabIndex = 2;
            Cancel_button.Text = "Cancel";
            Cancel_button.UseVisualStyleBackColor = true;
            Cancel_button.Click += Cancel_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cancel_button);
            Controls.Add(Next_button);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Next_button;
        private Button Cancel_button;
    }
}
