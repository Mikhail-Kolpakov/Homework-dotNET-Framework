using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        Bitmap imageForDrawing;
        Point startPoint;
        bool access;
        Pen pen = new Pen(Color.Black, 5);
        string fullImageName;


        public Form1()
        {
            InitializeComponent();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fullImageName = openFileDialog.FileName;
                    imageForDrawing = new Bitmap(openFileDialog.FileName);
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    pictureBox.Image = imageForDrawing;
                    pictureBox.Invalidate();
                }
                catch
                {
                    var result = MessageBox.Show("Неможливо відкрити файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                fullImageName.Substring(fullImageName.Length - 5, 5);
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Filter = "JPEG Files (*.jpg)|*.jpg";
                savedialog.Title = "Зберегти як ...";
                savedialog.OverwritePrompt = true;
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        imageForDrawing.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Неможливо зберегти зображення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            var g = pictureBox.CreateGraphics();
            g.Clear(SystemColors.Window);
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                access = true;
                startPoint = e.Location;
            }

        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                access = false;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (var g = Graphics.FromImage(pictureBox.Image))
                {
                    if (access == true)
                    {
                        g.DrawLine(pen, startPoint, e.Location);
                        startPoint = e.Location;
                        pictureBox.Invalidate();
                    }
                }
            }
        }
    }
}
