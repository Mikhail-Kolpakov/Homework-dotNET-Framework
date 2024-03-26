namespace Ex1
{
    partial class Form1
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
            rowTextBox = new TextBox();
            label2 = new Label();
            textListBox = new ListBox();
            addRowButton = new Button();
            numberTextBox = new TextBox();
            deleteNumberRowButton = new Button();
            deleteValueRowButton = new Button();
            CountLabel = new Label();
            TypeLabel = new Label();
            NumberLabel = new Label();
            clearListButton = new Button();
            checkRowButton = new Button();
            addArrayButton = new Button();
            SuspendLayout();
            // 
            // rowTextBox
            // 
            rowTextBox.Font = new Font("Segoe UI", 12F);
            rowTextBox.Location = new Point(11, 22);
            rowTextBox.Name = "rowTextBox";
            rowTextBox.PlaceholderText = "Рядок";
            rowTextBox.Size = new Size(285, 29);
            rowTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(11, 232);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 2;
            label2.Text = "Основний текст";
            // 
            // textListBox
            // 
            textListBox.FormattingEnabled = true;
            textListBox.ItemHeight = 15;
            textListBox.Location = new Point(11, 265);
            textListBox.Name = "textListBox";
            textListBox.Size = new Size(399, 244);
            textListBox.TabIndex = 3;
            textListBox.SelectedIndexChanged += textListBox_SelectedIndexChanged;
            // 
            // addRowButton
            // 
            addRowButton.BackColor = Color.LightGreen;
            addRowButton.FlatAppearance.BorderColor = Color.Black;
            addRowButton.FlatStyle = FlatStyle.Flat;
            addRowButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addRowButton.Location = new Point(11, 92);
            addRowButton.Name = "addRowButton";
            addRowButton.Size = new Size(87, 38);
            addRowButton.TabIndex = 6;
            addRowButton.Text = "Додати";
            addRowButton.UseVisualStyleBackColor = false;
            addRowButton.Click += addRowButton_Click;
            // 
            // numberTextBox
            // 
            numberTextBox.Font = new Font("Segoe UI", 12F);
            numberTextBox.Location = new Point(11, 57);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.PlaceholderText = "Номер вставлення";
            numberTextBox.Size = new Size(399, 29);
            numberTextBox.TabIndex = 7;
            // 
            // deleteNumberRowButton
            // 
            deleteNumberRowButton.BackColor = Color.LightCoral;
            deleteNumberRowButton.FlatAppearance.BorderColor = Color.Black;
            deleteNumberRowButton.FlatStyle = FlatStyle.Flat;
            deleteNumberRowButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteNumberRowButton.Location = new Point(104, 92);
            deleteNumberRowButton.Name = "deleteNumberRowButton";
            deleteNumberRowButton.Size = new Size(150, 38);
            deleteNumberRowButton.TabIndex = 8;
            deleteNumberRowButton.Text = "Видалити(нмр)";
            deleteNumberRowButton.UseVisualStyleBackColor = false;
            deleteNumberRowButton.Click += deleteNumberRowButton_Click;
            // 
            // deleteValueRowButton
            // 
            deleteValueRowButton.BackColor = Color.LightCoral;
            deleteValueRowButton.FlatAppearance.BorderColor = Color.Black;
            deleteValueRowButton.FlatStyle = FlatStyle.Flat;
            deleteValueRowButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteValueRowButton.Location = new Point(260, 92);
            deleteValueRowButton.Name = "deleteValueRowButton";
            deleteValueRowButton.Size = new Size(150, 38);
            deleteValueRowButton.TabIndex = 9;
            deleteValueRowButton.Text = "Видалити(знч)";
            deleteValueRowButton.UseVisualStyleBackColor = false;
            deleteValueRowButton.Click += deleteValueRowButton_Click;
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CountLabel.Location = new Point(11, 150);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(190, 21);
            CountLabel.TabIndex = 10;
            CountLabel.Text = "Кількість рядків у списку:";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TypeLabel.Location = new Point(12, 171);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(193, 21);
            TypeLabel.TabIndex = 11;
            TypeLabel.Text = "Тип виділеного елементу:";
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumberLabel.Location = new Point(12, 192);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(251, 21);
            NumberLabel.TabIndex = 12;
            NumberLabel.Text = "Номер рядка, який розшукується:";
            // 
            // clearListButton
            // 
            clearListButton.BackColor = Color.LightCoral;
            clearListButton.FlatAppearance.BorderColor = Color.Black;
            clearListButton.FlatStyle = FlatStyle.Flat;
            clearListButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            clearListButton.Location = new Point(158, 515);
            clearListButton.Name = "clearListButton";
            clearListButton.Size = new Size(163, 38);
            clearListButton.TabIndex = 13;
            clearListButton.Text = "Очистити список";
            clearListButton.UseVisualStyleBackColor = false;
            clearListButton.Click += clearListButton_Click;
            // 
            // checkRowButton
            // 
            checkRowButton.BackColor = SystemColors.Control;
            checkRowButton.FlatAppearance.BorderColor = Color.Black;
            checkRowButton.FlatStyle = FlatStyle.Flat;
            checkRowButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            checkRowButton.Location = new Point(302, 22);
            checkRowButton.Name = "checkRowButton";
            checkRowButton.Size = new Size(108, 29);
            checkRowButton.TabIndex = 14;
            checkRowButton.Text = "Перевірити";
            checkRowButton.UseVisualStyleBackColor = false;
            checkRowButton.Click += checkRowButton_Click;
            // 
            // addArrayButton
            // 
            addArrayButton.BackColor = Color.LightGreen;
            addArrayButton.FlatAppearance.BorderColor = Color.Black;
            addArrayButton.FlatStyle = FlatStyle.Flat;
            addArrayButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addArrayButton.Location = new Point(12, 515);
            addArrayButton.Name = "addArrayButton";
            addArrayButton.Size = new Size(140, 38);
            addArrayButton.TabIndex = 15;
            addArrayButton.Text = "Додати масив";
            addArrayButton.UseVisualStyleBackColor = false;
            addArrayButton.Click += addArrayButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 560);
            Controls.Add(addArrayButton);
            Controls.Add(checkRowButton);
            Controls.Add(clearListButton);
            Controls.Add(NumberLabel);
            Controls.Add(TypeLabel);
            Controls.Add(CountLabel);
            Controls.Add(deleteValueRowButton);
            Controls.Add(deleteNumberRowButton);
            Controls.Add(numberTextBox);
            Controls.Add(addRowButton);
            Controls.Add(textListBox);
            Controls.Add(label2);
            Controls.Add(rowTextBox);
            Name = "Form1";
            Text = "Ex1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void DeleteValueRowButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CheckRowButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox rowTextBox;
        private Label label2;
        private ListBox textListBox;
        private Button addRowButton;
        private TextBox numberTextBox;
        private Button deleteNumberRowButton;
        private Button deleteValueRowButton;
        private Label CountLabel;
        private Label TypeLabel;
        private Label NumberLabel;
        private Button clearListButton;
        private Button checkRowButton;
        private Button addArrayButton;
    }
}
