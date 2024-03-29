using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1() =>
            InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog.FileName = "my-new-txt.txt";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files (*.*)|*.*";
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName == null)
                return;

            var MyReader = new StreamReader(openFileDialog.FileName);

            textBox1.Text = MyReader.ReadToEnd();
            MyReader.Close();
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = openFileDialog.FileName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                Save();
        }

        void Save()
        {
            var MyWriter = new StreamWriter(saveFileDialog.FileName, false);

            MyWriter.Write(textBox1.Text);
            MyWriter.Close();

            textBox1.Modified = false;
        }

        private void exitMenuItem_Click(object sender, EventArgs e) =>
            Close();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified == false)
                return;

            var message = "Текст був змінений. Зберегти зміни?";
            var title = "Закрити вікно";
            var buttons = MessageBoxButtons.YesNoCancel;
            var result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.No)
                return;
            if (result == DialogResult.Cancel)
                e.Cancel = true;
            if (result == DialogResult.Yes)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Save();
                    return;
                }
                else
                    e.Cancel = true;
            }
        }
    }
}
