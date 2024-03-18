namespace Ex4
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
            comboBoxOutfit = new ComboBox();
            listBoxItems = new ListBox();
            labelTotalCost = new Label();
            SuspendLayout();
            // 
            // comboBoxOutfit
            // 
            comboBoxOutfit.FormattingEnabled = true;
            comboBoxOutfit.Location = new Point(86, 106);
            comboBoxOutfit.Name = "comboBoxOutfit";
            comboBoxOutfit.Size = new Size(290, 23);
            comboBoxOutfit.TabIndex = 0;
            comboBoxOutfit.SelectedIndexChanged += this.comboBoxOutfit_SelectedIndexChanged;
            // 
            // listBoxItems
            // 
            listBoxItems.FormattingEnabled = true;
            listBoxItems.ItemHeight = 15;
            listBoxItems.Location = new Point(416, 106);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(308, 169);
            listBoxItems.TabIndex = 1;
            // 
            // labelTotalCost
            // 
            labelTotalCost.AutoSize = true;
            labelTotalCost.Font = new Font("Segoe UI", 12F);
            labelTotalCost.Location = new Point(416, 293);
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
            Controls.Add(listBoxItems);
            Controls.Add(comboBoxOutfit);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxOutfit;
        private ListBox listBoxItems;
        private Label labelTotalCost;
    }
}
