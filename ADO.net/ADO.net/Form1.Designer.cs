namespace ADO.net
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
            listView1 = new ListView();
            columnId = new ColumnHeader();
            columnTitle = new ColumnHeader();
            columnRating = new ColumnHeader();
            columnFileSizeKb = new ColumnHeader();
            columnDuration = new ColumnHeader();
            sumFileSize = new Label();
            sumDuration = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnId, columnTitle, columnRating, columnFileSizeKb, columnDuration });
            listView1.Location = new Point(49, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(695, 247);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnId
            // 
            columnId.Text = "Id";
            // 
            // columnTitle
            // 
            columnTitle.Text = "Title";
            // 
            // columnRating
            // 
            columnRating.Text = "Rating";
            // 
            // columnFileSizeKb
            // 
            columnFileSizeKb.Text = "File size";
            // 
            // columnDuration
            // 
            columnDuration.Text = "Duration";
            // 
            // sumFileSize
            // 
            sumFileSize.AutoSize = true;
            sumFileSize.Location = new Point(207, 358);
            sumFileSize.Name = "sumFileSize";
            sumFileSize.Size = new Size(68, 15);
            sumFileSize.TabIndex = 1;
            sumFileSize.Text = "sumFileSize";
            sumFileSize.Click += sumFileSize_Click;
            // 
            // sumDuration
            // 
            sumDuration.AutoSize = true;
            sumDuration.Location = new Point(414, 358);
            sumDuration.Name = "sumDuration";
            sumDuration.Size = new Size(76, 15);
            sumDuration.TabIndex = 2;
            sumDuration.Text = "sumDuration";
            sumDuration.Click += sumDuration_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sumDuration);
            Controls.Add(sumFileSize);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnId;
        private ColumnHeader columnTitle;
        private ColumnHeader columnRating;
        private ColumnHeader columnFileSizeKb;
        private ColumnHeader columnDuration;
        private Label sumFileSize;
        private Label sumDuration;
    }
}
