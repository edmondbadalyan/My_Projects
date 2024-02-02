namespace Installer
{
    partial class Features_form
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
            checkListBox_Values = new CheckedListBox();
            nextButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // checkListBox_Values
            // 
            checkListBox_Values.FormattingEnabled = true;
            checkListBox_Values.Items.AddRange(new object[] { "Как насчет игры Starcraft 2?)", "Или лучше Diablo IV ?", "Пойду лучше прогать на Python", "C# сила,мощь!" });
            checkListBox_Values.Location = new Point(78, 51);
            checkListBox_Values.Name = "checkListBox_Values";
            checkListBox_Values.Size = new Size(618, 220);
            checkListBox_Values.TabIndex = 0;
            checkListBox_Values.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(128, 344);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(168, 66);
            nextButton.TabIndex = 1;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(484, 344);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(168, 66);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // Features_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelButton);
            Controls.Add(nextButton);
            Controls.Add(checkListBox_Values);
            Name = "Features_form";
            Text = "Features_form";
            Load += Features_form_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkListBox_Values;
        private Button nextButton;
        private Button cancelButton;
    }
}