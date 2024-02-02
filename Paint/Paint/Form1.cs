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

           

            // �������� ������ Graphics ��� ���������
            Graphics g = e.Graphics;

            // ����������� �������� � ��������� ������ �����
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int appleSize = Math.Min(this.ClientSize.Width, this.ClientSize.Height);

            // ������ ������ � �������������� ����������
            using (Pen pen = new Pen(Color.Red, 2))
            {
                // ������ ������ � �������������� �����, ��� � ������ �����
                g.DrawEllipse(pen, centerX - appleSize / 2, centerY - appleSize / 2, appleSize, appleSize);

                // ����� ������
                g.DrawLine(pen, centerX, centerY - appleSize / 2, centerX, centerY + appleSize / 2);
                g.DrawLine(pen, centerX - appleSize / 4, centerY - appleSize / 2, centerX - appleSize / 4, centerY + appleSize / 2);
                g.DrawLine(pen, centerX + appleSize / 4, centerY - appleSize / 2, centerX + appleSize / 4, centerY + appleSize / 2);

                // ���� ������
                Rectangle arcRect = new Rectangle(centerX - appleSize / 4, centerY - appleSize / 4, appleSize / 2, appleSize / 2);
                g.DrawArc(pen, arcRect, 0, -180);

                // ������ ����� ������
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

