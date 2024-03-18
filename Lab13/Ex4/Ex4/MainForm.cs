namespace Ex4
{
    public partial class MainForm : Form
    {
        private Dictionary<string, float> clothingItems = new Dictionary<string, float>()
        {
            {"Футболка", 20.0F},
            {"Світшот", 30.0F},
            {"Джинси", 40.0F},
            {"Штани", 35.0F},
            {"Спортивні кросівки", 50.0F},
            {"Туфлі", 60.0F}
        };

        private Dictionary<string, List<string>> dressingCombos = new Dictionary<string, List<string>>()
        {
            {"Варіант 1", new List<string>{"Футболка", "Джинси", "Спортивні кросівки"}},
            {"Варіант 2", new List<string>{"Світшот", "Штани", "Туфлі"}},
            {"Варіант 3", new List<string>{"Футболка", "Штани", "Спортивні кросівки"}}
        };

        public MainForm()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            foreach (var dressingCombo in dressingCombos)
                comboBoxOutfit.Items.Add(dressingCombo.Key);
        }

        private void comboBoxOutfit_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxItems.Items.Clear();

            var selectedCombo = comboBoxOutfit.SelectedItem!.ToString();
            var selectedItems = dressingCombos[selectedCombo!];
            var totalCost = 0F;

            foreach (var item in selectedItems)
            {
                listBoxItems.Items.Add(item);
                totalCost += clothingItems[item];
            }

            labelTotalCost.Text = $"Загальна вартість: {totalCost.ToString("F2")} грн.";
        }
    }
}
