using System.Drawing.Drawing2D;

namespace Ex2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var graphics = Graphics.FromHwnd(Handle);

            var rectanglePen = new Pen(Color.BlueViolet, 2);
            rectanglePen.DashStyle = DashStyle.DashDot;

            var rectangle = new Rectangle(50, 50, 200, 150);
            graphics.DrawRectangle(rectanglePen, rectangle);

            var text = "Hello, my friend!";
            var font = new Font("Arial Black", 14);
            var textSize = graphics.MeasureString(text, font);
            var textPosition = new PointF(rectangle.Left + (rectangle.Width - textSize.Width) / 2, 
                rectangle.Top + (rectangle.Height - textSize.Height) / 2);
            graphics.DrawString(text, font, Brushes.Black, textPosition);

            var hatchBrush = new HatchBrush(HatchStyle.Cross, Color.DeepPink);
            graphics.FillRectangle(hatchBrush, 300, 50, 150, 100);
        }
    }
}
