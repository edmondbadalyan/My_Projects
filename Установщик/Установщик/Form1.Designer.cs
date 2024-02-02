namespace Установщик
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
            Next = new Button();
            Cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(83, 60);
            label1.Name = "label1";
            label1.Size = new Size(534, 21);
            label1.TabIndex = 0;
            label1.Text = "Вас приветсвует Мастер установки, установится что-то рандомно)";
            // 
            // Next
            // 
            Next.Location = new Point(323, 379);
            Next.Name = "Next";
            Next.Size = new Size(132, 39);
            Next.TabIndex = 1;
            Next.Text = "Next";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(527, 379);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(141, 39);
            Cancel.TabIndex = 2;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Form1
            // 
            AcceptButton = Next;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Cancel;
            ClientSize = new Size(703, 450);
            Controls.Add(Cancel);
            Controls.Add(Next);
            Controls.Add(label1);
            HelpButton = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Next;
        private Button Cancel;
    }
}
