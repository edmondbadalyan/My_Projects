namespace Control_Elements
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            trackBarRed = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarBlue = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            costPerDayTextBox = new TextBox();
            resultLabel = new Label();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            calculateButton = new Button();
            toolTip1 = new ToolTip(components);
            emalTextBox = new TextBox();
            email = new Label();
            validateEmail = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(27, 197);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(814, 33);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(27, 0);
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(549, 45);
            trackBarRed.TabIndex = 1;
            trackBarRed.Scroll += OnSliderScroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(27, 51);
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(549, 45);
            trackBarGreen.TabIndex = 2;
            trackBarGreen.Scroll += OnSliderScroll;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(27, 113);
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(549, 45);
            trackBarBlue.TabIndex = 3;
            trackBarBlue.Scroll += OnSliderScroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(594, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 10;
            label1.Text = "RGB: RED";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 61);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 11;
            label2.Text = "RGB:GREEN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(594, 113);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 11;
            label3.Text = "RGB:BLUE";
            // 
            // costPerDayTextBox
            // 
            costPerDayTextBox.Location = new Point(188, 352);
            costPerDayTextBox.Name = "costPerDayTextBox";
            costPerDayTextBox.Size = new Size(100, 23);
            costPerDayTextBox.TabIndex = 12;
            toolTip1.SetToolTip(costPerDayTextBox, "Введите стоимость работ за день.");
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(188, 470);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(120, 15);
            resultLabel.TabIndex = 13;
            resultLabel.Text = "Ждем ввода данных!";
            toolTip1.SetToolTip(resultLabel, "Поняли?)");
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(27, 298);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(200, 23);
            startDatePicker.TabIndex = 14;
            toolTip1.SetToolTip(startDatePicker, "Дата начала работ не может быть позже даты окончания работ");
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(267, 298);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(200, 23);
            endDatePicker.TabIndex = 15;
            toolTip1.SetToolTip(endDatePicker, "Введите дату окончания работ!\r\n");
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(153, 388);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(180, 49);
            calculateButton.TabIndex = 16;
            calculateButton.Text = "Расчитать стоимость";
            toolTip1.SetToolTip(calculateButton, "Кнопка рассчитает стоимость ваших работ)");
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += button1_Click;
            // 
            // emalTextBox
            // 
            emalTextBox.Location = new Point(718, 352);
            emalTextBox.Name = "emalTextBox";
            emalTextBox.Size = new Size(100, 23);
            emalTextBox.TabIndex = 17;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(630, 355);
            email.Name = "email";
            email.Size = new Size(85, 15);
            email.TabIndex = 18;
            email.Text = "Введите Email:";
            // 
            // validateEmail
            // 
            validateEmail.Location = new Point(713, 407);
            validateEmail.Name = "validateEmail";
            validateEmail.Size = new Size(105, 50);
            validateEmail.TabIndex = 19;
            validateEmail.Text = "Проверить";
            validateEmail.UseVisualStyleBackColor = true;
            validateEmail.Click += validateEmail_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 525);
            Controls.Add(validateEmail);
            Controls.Add(email);
            Controls.Add(emalTextBox);
            Controls.Add(calculateButton);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Controls.Add(resultLabel);
            Controls.Add(costPerDayTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBarBlue);
            Controls.Add(trackBarGreen);
            Controls.Add(trackBarRed);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox costPerDayTextBox;
        private Label resultLabel;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private Button calculateButton;
        private ToolTip toolTip1;
        private TextBox emalTextBox;
        private Label email;
        private Button validateEmail;
    }
}
