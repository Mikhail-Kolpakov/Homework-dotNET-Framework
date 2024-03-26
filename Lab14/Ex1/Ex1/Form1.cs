namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(xMinTextBox.Text, out float xMin) ||
                !float.TryParse(xMaxTextBox.Text, out float xMax) ||
                !float.TryParse(dxTextBox.Text, out float dx) ||
                !float.TryParse(constTextBox.Text, out float c))
            {
                MessageBox.Show("�������: ���� �����, ������ ������� ������ �������� ��� x_min, x_max, ����� (dx) �� ��������� c.");
                return;
            }

            if (xMin >= xMax || dx <= 0)
            {
                MessageBox.Show("�������: x_min �� ���� ����� x_max, � ���� (dx) �� ���� ����� 0.");
                return;
            }

            float x = xMin;
            float y;

            while (x <= xMax)
            {
                try
                {
                    y = CalculateFunction(x, c);
                    resultsListBox.Items.Add($"f({x:f3}) = {y:f3}\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"�������: {ex.Message}. x = {x}, c = {c}");
                    return;
                }

                x += dx;
            }
        }

        private float CalculateFunction(float x, float c) =>
            (float)(Math.Pow(Math.Log(c - x) + Math.Sin(x), 1.0 / 5.0) + (Math.Tan(c * x) + Math.Sqrt(c * x)) / Math.Log(c - x));
    }
}
