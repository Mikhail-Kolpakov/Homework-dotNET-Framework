namespace Ex3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxLunch = new ComboBox();
            listBoxDishes = new ListBox();
            labelTotalCost = new Label();
            SuspendLayout();
            // 
            // comboBoxLunch
            // 
            comboBoxLunch.FormattingEnabled = true;
            comboBoxLunch.Location = new Point(75, 106);
            comboBoxLunch.Name = "comboBoxLunch";
            comboBoxLunch.Size = new Size(259, 23);
            comboBoxLunch.TabIndex = 0;
            comboBoxLunch.SelectedIndexChanged += this.comboBoxLunch_SelectedIndexChanged;
            // 
            // listBoxDishes
            // 
            listBoxDishes.FormattingEnabled = true;
            listBoxDishes.ItemHeight = 15;
            listBoxDishes.Location = new Point(384, 106);
            listBoxDishes.Name = "listBoxDishes";
            listBoxDishes.Size = new Size(291, 184);
            listBoxDishes.TabIndex = 1;
            // 
            // labelTotalCost
            // 
            labelTotalCost.AutoSize = true;
            labelTotalCost.Font = new Font("Segoe UI", 12F);
            labelTotalCost.Location = new Point(384, 308);
            labelTotalCost.Name = "labelTotalCost";
            labelTotalCost.Size = new Size(139, 21);
            labelTotalCost.TabIndex = 2;
            labelTotalCost.Text = "Загальна вартість:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTotalCost);
            Controls.Add(listBoxDishes);
            Controls.Add(comboBoxLunch);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxLunch;
        private ListBox listBoxDishes;
        private Label labelTotalCost;
    }
}
