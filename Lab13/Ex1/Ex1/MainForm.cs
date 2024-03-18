using System.Drawing.Drawing2D;

namespace Ex1;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var graphics = Graphics.FromHwnd(Handle);

        var rectanglePen = new Pen(Color.DeepPink, 4);
        rectanglePen.DashStyle = DashStyle.DashDotDot;

        var rectangle = new Rectangle(50, 50, 200, 150);
        graphics.DrawRectangle(rectanglePen, rectangle);

        var font = new Font("Arial Black", 14);

        var text = "Hello, my friend!";
        var textSize = graphics.MeasureString(text, font);
        var textPosition = new PointF(rectangle.Left + (rectangle.Width - textSize.Width) / 2,
            rectangle.Top + (rectangle.Height - textSize.Height) / 2);
        graphics.DrawString(text, font, Brushes.Black, textPosition);

        var hatchBrush = new HatchBrush(HatchStyle.DiagonalCross, Color.BlueViolet);
        graphics.FillEllipse(hatchBrush, 300, 50, 150, 100);
    }
}
