using System.Drawing.Drawing2D;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

           

            // —оздадим объект Graphics дл€ рисовани€
            Graphics g = e.Graphics;

            // ќпределение размеров и координат центра формы
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int appleSize = Math.Min(this.ClientSize.Width, this.ClientSize.Height);

            // –исуем €блоко с использованием траекторий
            using (Pen pen = new Pen(Color.Red, 2))
            {
                // –исуем €блоко с использованием линий, дуг и кривых Ѕезье
                g.DrawEllipse(pen, centerX - appleSize / 2, centerY - appleSize / 2, appleSize, appleSize);

                // Ћинии €блока
                g.DrawLine(pen, centerX, centerY - appleSize / 2, centerX, centerY + appleSize / 2);
                g.DrawLine(pen, centerX - appleSize / 4, centerY - appleSize / 2, centerX - appleSize / 4, centerY + appleSize / 2);
                g.DrawLine(pen, centerX + appleSize / 4, centerY - appleSize / 2, centerX + appleSize / 4, centerY + appleSize / 2);

                // ƒуга €блока
                Rectangle arcRect = new Rectangle(centerX - appleSize / 4, centerY - appleSize / 4, appleSize / 2, appleSize / 2);
                g.DrawArc(pen, arcRect, 0, -180);

                //  рива€ Ѕезье €блока
                Point p1 = new Point(centerX - appleSize / 4, centerY + appleSize / 2);
                Point p2 = new Point(centerX, centerY + appleSize / 4);
                Point p3 = new Point(centerX + appleSize / 4, centerY + appleSize / 2);
                g.DrawBezier(pen, p1, p2, p3, new Point(centerX, centerY + appleSize / 4));
            }

        }
        



        //Make sure to force a repaint if the form is resized
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); // This will cause the OnPaint method to be called
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

