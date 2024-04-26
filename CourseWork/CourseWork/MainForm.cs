namespace CourseWork
{
    public partial class MainForm : Form
    {
        public MainForm() =>
            InitializeComponent();

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (TryParseFloat(xMinTextBox, "xMin", out float xMin) && TryParseFloat(xMaxTextBox, "xMax", out float xMax) && 
                TryParseFloat(dxTextBox, "dx", out float dx) && TryParseFloat(alphaTextBox, "alpha", out float alpha))
            {
                f1ResultsRichTextBox.Clear();
                f2ResultsRichTextBox.Clear();
                CalculateFunction(xMin, xMax, dx, alpha);
            }
        }

        private void CalculateFunction(float xMin, float xMax, float dx, float alpha)
        {
            var rand = new Random();
            var f1Counter = 0;
            var f2Counter = 0;

            for (float x = xMin; x <= xMax; x += dx)
            {
                var q = rand.NextSingle();

                if (q <= 0.55f)
                {
                    if (Math.Abs(q + x) < float.Epsilon || alpha - x <= 0)
                    {
                        PrintColoredText($"��������� ��� x = {x:f2}, q = {q:f2}{Environment.NewLine}", f1ResultsRichTextBox, Color.Red);
                        continue;
                    }

                    f1ResultsRichTextBox.AppendText($"��� x = {x:f2} �������� {FunctionF1(x, alpha, q):f2}{Environment.NewLine}");
                    f1Counter++;
                }
                else
                {
                    if (q + x < 0)
                    {
                        PrintColoredText($"��������� ��� x = {x:f2}, q = {q:f2}{Environment.NewLine}", f2ResultsRichTextBox, Color.Red);
                        continue;
                    }

                    f2ResultsRichTextBox.AppendText($"��� x = {x:f2} �������� {FunctionF2(x, q):f2}{Environment.NewLine}");
                    f2Counter++;
                }
            }

            f1CounterLabel.Text = $"ʳ������ ��������� ��� f1(x): {f1Counter}";
            f2CounterLabel.Text = $"ʳ������ ��������� ��� f2(x): {f2Counter}";
        }

        private float FunctionF1(float x, float alpha, float q) =>
            (float)Math.Log(alpha - x) / (q + x);

        private float FunctionF2(float x, float q) =>
            (float)Math.Pow(q + x, 1.0f / 3.0f);

        private bool TryParseFloat(TextBox textBox, string propName, out float result)
        {
            if (!float.TryParse(textBox.Text, out result))
            {
                MessageBox.Show($"���� ������� ���������� �������� ��� {propName}", "������������ ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();

                return false;
            }

            return true;
        }

        private void PrintColoredText(string text, RichTextBox textBox, Color textColor)
        {
            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;
            textBox.SelectionColor = textColor;

            textBox.AppendText(text);

            textBox.SelectionColor = textBox.ForeColor;
        }
    }
}
