namespace Ex3
{
    public partial class MainForm : Form
    {
        private Dictionary<string, float> dishes = new Dictionary<string, float>()
        {
            {"Борщ", 25.0F},
            {"Салат Цезар", 30.0F},
            {"Плов", 40.0F},
            {"Картопляне пюре", 20.0F},
            {"Паста з томатним соусом", 35.0F}
        };

        private Dictionary<string, List<string>> lunchCombos = new Dictionary<string, List<string>>()
        {
            {"Варіант 1", new List<string>{"Борщ", "Салат Цезар", "Картопляне пюре"}},
            {"Варіант 2", new List<string>{"Салат Цезар", "Плов", "Паста з томатним соусом"}},
            {"Варіант 3", new List<string>{"Борщ", "Плов", "Картопляне пюре"}}
        };

        public MainForm()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            foreach (var lunchCombo in lunchCombos)
                comboBoxLunch.Items.Add(lunchCombo.Key);
        }

        private void comboBoxLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDishes.Items.Clear();

            var selectedCombo = comboBoxLunch.SelectedItem!.ToString();
            var selectedDishes = lunchCombos[selectedCombo!];
            var totalCost = 0F;

            foreach (var dish in selectedDishes)
            {
                listBoxDishes.Items.Add(dish);
                totalCost += dishes[dish];
            }

            labelTotalCost.Text = $"Загальна вартість: {totalCost.ToString("F2")} грн.";
        }
    }
}
