using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListBox();
        }

        private void InitializeListBox()
        {
            textListBox.Items.Add("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            textListBox.Items.Add("Praesent rhoncus eget nulla eget facilisis.");
            textListBox.Items.Add("Sed tincidunt orci a sem porta, id fringilla libero suscipit.");
            textListBox.Items.Add("Nam turpis ante, efficitur eu nibh vitae, tristique eleifend libero.");
            textListBox.Items.Add("In in tristique lacus, quis hendrerit augue.");
            textListBox.Items.Add("Ut gravida in nunc ultricies dignissim.");
            textListBox.Items.Add("Vivamus velit nibh, eleifend nec felis vel, rutrum fermentum augue.");
            textListBox.Items.Add("Quisque eros erat, rutrum et est et, posuere vulputate orci.");
            textListBox.Items.Add("Sed molestie ex interdum enim feugiat, sed vulputate ipsum vulputate.");
        }

        private void textListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rowTextBox.Text = textListBox.SelectedItem?.ToString();
            CountLabel.Text = $"Ê³ëüê³ñòü ğÿäê³â ó ñïèñêó: {textListBox.Items.Count}";
            TypeLabel.Text = $"Òèï âèä³ëåíîãî åëåìåíòó: {textListBox.SelectedItem?.GetType()}";
            NumberLabel.Text = $"Íîìåğ ğÿäêà, ÿêèé ğîçøóêóºòüñÿ: {textListBox.SelectedIndex + 1}";
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rowTextBox.Text))
            {
                MessageBox.Show("Ïîëå \"Ğÿäîê\" íå ìîæå áóòè ïîğîæí³ì");
                return;
            }
            if (!int.TryParse(numberTextBox.Text, out int number) || string.IsNullOrWhiteSpace(numberTextBox.Text))
            {
                MessageBox.Show("Â³äñóòíº àáî íåêîğåêòíå çíà÷åííÿ äëÿ \"Íîìåğ âñòàâëåííÿ\"");
                return;
            }

            if (number > 0 && number <= textListBox.Items.Count + 1)
                textListBox.Items.Insert(number - 1, rowTextBox.Text);
            else
                MessageBox.Show("Íåäîïóñòèìèé íîìåğ âñòàâëåííÿ");
        }

        private void checkRowButton_Click(object sender, EventArgs e)
        {
            if (textListBox.Items.Contains(rowTextBox.Text))
                MessageBox.Show("Ğÿäîê çíàéäåíî â ñïèñêó");
            else
                MessageBox.Show("Ğÿäîê íå çíàéäåíî â ñïèñêó");
        }

        private void deleteValueRowButton_Click(object sender, EventArgs e) =>
            textListBox.Items.Remove(rowTextBox.Text);

        private void deleteNumberRowButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(numberTextBox.Text, out int number))
            {
                MessageBox.Show("Íåêîğåêòíå çíà÷åííÿ äëÿ \"Íîìåğ âñòàâëåííÿ\"");
                return;
            }

            if (number > 0 && number <= textListBox.Items.Count)
                textListBox.Items.RemoveAt(number - 1);
            else
                MessageBox.Show("Íåäîïóñòèìèé íîìåğ ğÿäêà");
        }

        private void addArrayButton_Click(object sender, EventArgs e)
        {
            string[] stringsToAdd = { "Ö³", "ğÿäêè", "ç", "ìàñèâó" };
            textListBox.Items.AddRange(stringsToAdd);
        }

        private void clearListButton_Click(object sender, EventArgs e)
        {
            textListBox.Items.Clear();
            CountLabel.Text = $"Ê³ëüê³ñòü ğÿäê³â ó ñïèñêó:";
            TypeLabel.Text = $"Òèï âèä³ëåíîãî åëåìåíòó:";
            NumberLabel.Text = $"Íîìåğ ğÿäêà, ÿêèé ğîçøóêóºòüñÿ:";
        }  
    }
}
