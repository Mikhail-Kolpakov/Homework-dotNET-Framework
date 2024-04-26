namespace CourseWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            infoInputLabel = new Label();
            xMinInputLabel = new Label();
            xMinTextBox = new TextBox();
            xMaxTextBox = new TextBox();
            xMaxInputLabel = new Label();
            dxTextBox = new TextBox();
            dxInputLabel = new Label();
            studentPhotoPictureBox = new PictureBox();
            studentInfoLabel = new Label();
            calculateButton = new Button();
            overallResultsLabel = new Label();
            f1ResultsLabel = new Label();
            f2ResultsLabel = new Label();
            resultsTableLayoutPanel = new TableLayoutPanel();
            f1CounterLabel = new Label();
            f2CounterLabel = new Label();
            outerInputTableLayoutPanel = new TableLayoutPanel();
            inner2InputTableLayoutPanel = new TableLayoutPanel();
            inner1InputTableLayoutPanel = new TableLayoutPanel();
            alphaLabel = new Label();
            alphaTextBox = new TextBox();
            mainTableLayoutPanel = new TableLayoutPanel();
            f1ResultsRichTextBox = new RichTextBox();
            f2ResultsRichTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)studentPhotoPictureBox).BeginInit();
            resultsTableLayoutPanel.SuspendLayout();
            outerInputTableLayoutPanel.SuspendLayout();
            inner2InputTableLayoutPanel.SuspendLayout();
            inner1InputTableLayoutPanel.SuspendLayout();
            mainTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // infoInputLabel
            // 
            infoInputLabel.AutoSize = true;
            infoInputLabel.Dock = DockStyle.Fill;
            infoInputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            infoInputLabel.Location = new Point(0, 0);
            infoInputLabel.Margin = new Padding(0);
            infoInputLabel.Name = "infoInputLabel";
            infoInputLabel.Size = new Size(272, 21);
            infoInputLabel.TabIndex = 0;
            infoInputLabel.Text = "Введіть вхідні значення:";
            // 
            // xMinInputLabel
            // 
            xMinInputLabel.AutoSize = true;
            xMinInputLabel.Dock = DockStyle.Fill;
            xMinInputLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            xMinInputLabel.Location = new Point(0, 21);
            xMinInputLabel.Margin = new Padding(0);
            xMinInputLabel.Name = "xMinInputLabel";
            xMinInputLabel.Size = new Size(272, 21);
            xMinInputLabel.TabIndex = 1;
            xMinInputLabel.Text = "Введіть xMin:";
            // 
            // xMinTextBox
            // 
            xMinTextBox.BorderStyle = BorderStyle.FixedSingle;
            xMinTextBox.Dock = DockStyle.Fill;
            xMinTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            xMinTextBox.Location = new Point(0, 42);
            xMinTextBox.Margin = new Padding(0);
            xMinTextBox.Name = "xMinTextBox";
            xMinTextBox.Size = new Size(272, 29);
            xMinTextBox.TabIndex = 2;
            // 
            // xMaxTextBox
            // 
            xMaxTextBox.BorderStyle = BorderStyle.FixedSingle;
            xMaxTextBox.Dock = DockStyle.Fill;
            xMaxTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            xMaxTextBox.Location = new Point(0, 92);
            xMaxTextBox.Margin = new Padding(0);
            xMaxTextBox.Name = "xMaxTextBox";
            xMaxTextBox.Size = new Size(272, 29);
            xMaxTextBox.TabIndex = 4;
            // 
            // xMaxInputLabel
            // 
            xMaxInputLabel.AutoSize = true;
            xMaxInputLabel.Dock = DockStyle.Fill;
            xMaxInputLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            xMaxInputLabel.Location = new Point(0, 71);
            xMaxInputLabel.Margin = new Padding(0);
            xMaxInputLabel.Name = "xMaxInputLabel";
            xMaxInputLabel.Size = new Size(272, 21);
            xMaxInputLabel.TabIndex = 3;
            xMaxInputLabel.Text = "Введіть xMax:";
            // 
            // dxTextBox
            // 
            dxTextBox.BorderStyle = BorderStyle.FixedSingle;
            dxTextBox.Dock = DockStyle.Fill;
            dxTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dxTextBox.Location = new Point(0, 142);
            dxTextBox.Margin = new Padding(0);
            dxTextBox.Name = "dxTextBox";
            dxTextBox.Size = new Size(272, 29);
            dxTextBox.TabIndex = 6;
            // 
            // dxInputLabel
            // 
            dxInputLabel.AutoSize = true;
            dxInputLabel.Dock = DockStyle.Fill;
            dxInputLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dxInputLabel.Location = new Point(0, 121);
            dxInputLabel.Margin = new Padding(0);
            dxInputLabel.Name = "dxInputLabel";
            dxInputLabel.Size = new Size(272, 21);
            dxInputLabel.TabIndex = 5;
            dxInputLabel.Text = "Введіть крок dx:";
            // 
            // studentPhotoPictureBox
            // 
            studentPhotoPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            studentPhotoPictureBox.Image = (Image)resources.GetObject("studentPhotoPictureBox.Image");
            studentPhotoPictureBox.Location = new Point(3, 0);
            studentPhotoPictureBox.Margin = new Padding(0);
            studentPhotoPictureBox.Name = "studentPhotoPictureBox";
            studentPhotoPictureBox.Size = new Size(162, 209);
            studentPhotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            studentPhotoPictureBox.TabIndex = 7;
            studentPhotoPictureBox.TabStop = false;
            // 
            // studentInfoLabel
            // 
            studentInfoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            studentInfoLabel.AutoSize = true;
            studentInfoLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            studentInfoLabel.Location = new Point(8, 209);
            studentInfoLabel.Margin = new Padding(0);
            studentInfoLabel.Name = "studentInfoLabel";
            studentInfoLabel.Size = new Size(157, 42);
            studentInfoLabel.TabIndex = 8;
            studentInfoLabel.Text = "Колпаков Михайло\r\nгруппа ІН-21/1";
            studentInfoLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // calculateButton
            // 
            calculateButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            calculateButton.BackColor = Color.FromArgb(0, 184, 105);
            calculateButton.FlatAppearance.BorderColor = Color.Black;
            calculateButton.FlatAppearance.BorderSize = 2;
            calculateButton.FlatStyle = FlatStyle.Flat;
            calculateButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            calculateButton.ForeColor = SystemColors.InfoText;
            calculateButton.Location = new Point(0, 231);
            calculateButton.Margin = new Padding(0, 10, 0, 0);
            calculateButton.MaximumSize = new Size(272, 43);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(272, 43);
            calculateButton.TabIndex = 9;
            calculateButton.Text = "Розрахувати";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // overallResultsLabel
            // 
            overallResultsLabel.AutoSize = true;
            overallResultsLabel.Dock = DockStyle.Fill;
            overallResultsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            overallResultsLabel.Location = new Point(0, 0);
            overallResultsLabel.Margin = new Padding(0);
            overallResultsLabel.Name = "overallResultsLabel";
            overallResultsLabel.Size = new Size(320, 21);
            overallResultsLabel.TabIndex = 11;
            overallResultsLabel.Text = "Результати розрахунків:";
            // 
            // f1ResultsLabel
            // 
            f1ResultsLabel.AutoSize = true;
            f1ResultsLabel.Dock = DockStyle.Fill;
            f1ResultsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            f1ResultsLabel.Location = new Point(0, 21);
            f1ResultsLabel.Margin = new Padding(0);
            f1ResultsLabel.Name = "f1ResultsLabel";
            f1ResultsLabel.Size = new Size(320, 21);
            f1ResultsLabel.TabIndex = 12;
            f1ResultsLabel.Text = "За функцією f₁(x)=log(α - x) / (q + x)";
            // 
            // f2ResultsLabel
            // 
            f2ResultsLabel.AutoSize = true;
            f2ResultsLabel.Dock = DockStyle.Fill;
            f2ResultsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            f2ResultsLabel.Location = new Point(339, 21);
            f2ResultsLabel.Margin = new Padding(0);
            f2ResultsLabel.Name = "f2ResultsLabel";
            f2ResultsLabel.Size = new Size(321, 21);
            f2ResultsLabel.TabIndex = 13;
            f2ResultsLabel.Text = "За функцією f₂(x)=∛(q + x)";
            // 
            // resultsTableLayoutPanel
            // 
            resultsTableLayoutPanel.ColumnCount = 3;
            resultsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.5F));
            resultsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            resultsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.5F));
            resultsTableLayoutPanel.Controls.Add(f2ResultsRichTextBox, 2, 2);
            resultsTableLayoutPanel.Controls.Add(f1ResultsRichTextBox, 0, 2);
            resultsTableLayoutPanel.Controls.Add(f1CounterLabel, 0, 3);
            resultsTableLayoutPanel.Controls.Add(overallResultsLabel, 0, 0);
            resultsTableLayoutPanel.Controls.Add(f2CounterLabel, 2, 3);
            resultsTableLayoutPanel.Controls.Add(f1ResultsLabel, 0, 1);
            resultsTableLayoutPanel.Controls.Add(f2ResultsLabel, 2, 1);
            resultsTableLayoutPanel.Dock = DockStyle.Fill;
            resultsTableLayoutPanel.Location = new Point(0, 280);
            resultsTableLayoutPanel.Margin = new Padding(0);
            resultsTableLayoutPanel.Name = "resultsTableLayoutPanel";
            resultsTableLayoutPanel.RowCount = 4;
            resultsTableLayoutPanel.RowStyles.Add(new RowStyle());
            resultsTableLayoutPanel.RowStyles.Add(new RowStyle());
            resultsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            resultsTableLayoutPanel.RowStyles.Add(new RowStyle());
            resultsTableLayoutPanel.Size = new Size(660, 238);
            resultsTableLayoutPanel.TabIndex = 15;
            // 
            // f1CounterLabel
            // 
            f1CounterLabel.AutoSize = true;
            f1CounterLabel.Dock = DockStyle.Fill;
            f1CounterLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            f1CounterLabel.Location = new Point(0, 217);
            f1CounterLabel.Margin = new Padding(0);
            f1CounterLabel.Name = "f1CounterLabel";
            f1CounterLabel.Size = new Size(320, 21);
            f1CounterLabel.TabIndex = 16;
            f1CounterLabel.Text = "Кількість обчислень за f₁(x): 0";
            // 
            // f2CounterLabel
            // 
            f2CounterLabel.AutoSize = true;
            f2CounterLabel.Dock = DockStyle.Fill;
            f2CounterLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            f2CounterLabel.Location = new Point(339, 217);
            f2CounterLabel.Margin = new Padding(0);
            f2CounterLabel.Name = "f2CounterLabel";
            f2CounterLabel.Size = new Size(321, 21);
            f2CounterLabel.TabIndex = 17;
            f2CounterLabel.Text = "Кількість обчислень за f₂(x): 0";
            // 
            // outerInputTableLayoutPanel
            // 
            outerInputTableLayoutPanel.ColumnCount = 2;
            outerInputTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            outerInputTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            outerInputTableLayoutPanel.Controls.Add(inner2InputTableLayoutPanel, 1, 0);
            outerInputTableLayoutPanel.Controls.Add(inner1InputTableLayoutPanel, 0, 0);
            outerInputTableLayoutPanel.Dock = DockStyle.Fill;
            outerInputTableLayoutPanel.Location = new Point(0, 0);
            outerInputTableLayoutPanel.Margin = new Padding(0);
            outerInputTableLayoutPanel.Name = "outerInputTableLayoutPanel";
            outerInputTableLayoutPanel.RowCount = 1;
            outerInputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            outerInputTableLayoutPanel.Size = new Size(660, 280);
            outerInputTableLayoutPanel.TabIndex = 17;
            // 
            // inner2InputTableLayoutPanel
            // 
            inner2InputTableLayoutPanel.ColumnCount = 1;
            inner2InputTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            inner2InputTableLayoutPanel.Controls.Add(studentPhotoPictureBox, 0, 0);
            inner2InputTableLayoutPanel.Controls.Add(studentInfoLabel, 0, 1);
            inner2InputTableLayoutPanel.Dock = DockStyle.Fill;
            inner2InputTableLayoutPanel.Location = new Point(495, 0);
            inner2InputTableLayoutPanel.Margin = new Padding(0);
            inner2InputTableLayoutPanel.Name = "inner2InputTableLayoutPanel";
            inner2InputTableLayoutPanel.RowCount = 2;
            inner2InputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inner2InputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inner2InputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            inner2InputTableLayoutPanel.Size = new Size(165, 280);
            inner2InputTableLayoutPanel.TabIndex = 19;
            // 
            // inner1InputTableLayoutPanel
            // 
            inner1InputTableLayoutPanel.ColumnCount = 2;
            inner1InputTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            inner1InputTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            inner1InputTableLayoutPanel.Controls.Add(infoInputLabel, 0, 0);
            inner1InputTableLayoutPanel.Controls.Add(xMinInputLabel, 0, 1);
            inner1InputTableLayoutPanel.Controls.Add(xMinTextBox, 0, 2);
            inner1InputTableLayoutPanel.Controls.Add(xMaxInputLabel, 0, 3);
            inner1InputTableLayoutPanel.Controls.Add(xMaxTextBox, 0, 4);
            inner1InputTableLayoutPanel.Controls.Add(dxInputLabel, 0, 5);
            inner1InputTableLayoutPanel.Controls.Add(dxTextBox, 0, 6);
            inner1InputTableLayoutPanel.Controls.Add(calculateButton, 0, 9);
            inner1InputTableLayoutPanel.Controls.Add(alphaLabel, 0, 7);
            inner1InputTableLayoutPanel.Controls.Add(alphaTextBox, 0, 8);
            inner1InputTableLayoutPanel.Dock = DockStyle.Fill;
            inner1InputTableLayoutPanel.Location = new Point(0, 0);
            inner1InputTableLayoutPanel.Margin = new Padding(0);
            inner1InputTableLayoutPanel.Name = "inner1InputTableLayoutPanel";
            inner1InputTableLayoutPanel.RowCount = 10;
            inner1InputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inner1InputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inner1InputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inner1InputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inner1InputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inner1InputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inner1InputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inner1InputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inner1InputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inner1InputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inner1InputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            inner1InputTableLayoutPanel.Size = new Size(495, 280);
            inner1InputTableLayoutPanel.TabIndex = 18;
            // 
            // alphaLabel
            // 
            alphaLabel.AutoSize = true;
            alphaLabel.Dock = DockStyle.Fill;
            alphaLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            alphaLabel.Location = new Point(0, 171);
            alphaLabel.Margin = new Padding(0);
            alphaLabel.Name = "alphaLabel";
            alphaLabel.Size = new Size(272, 21);
            alphaLabel.TabIndex = 10;
            alphaLabel.Text = "Введіть константу α:";
            // 
            // alphaTextBox
            // 
            alphaTextBox.BorderStyle = BorderStyle.FixedSingle;
            alphaTextBox.Dock = DockStyle.Fill;
            alphaTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            alphaTextBox.Location = new Point(0, 192);
            alphaTextBox.Margin = new Padding(0);
            alphaTextBox.Name = "alphaTextBox";
            alphaTextBox.Size = new Size(272, 29);
            alphaTextBox.TabIndex = 11;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTableLayoutPanel.BackColor = Color.Transparent;
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(resultsTableLayoutPanel, 0, 1);
            mainTableLayoutPanel.Controls.Add(outerInputTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Location = new Point(12, 12);
            mainTableLayoutPanel.Margin = new Padding(0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Size = new Size(660, 518);
            mainTableLayoutPanel.TabIndex = 18;
            // 
            // f1ResultsRichTextBox
            // 
            f1ResultsRichTextBox.BorderStyle = BorderStyle.FixedSingle;
            f1ResultsRichTextBox.Dock = DockStyle.Fill;
            f1ResultsRichTextBox.Font = new Font("Segoe UI", 12F);
            f1ResultsRichTextBox.Location = new Point(0, 45);
            f1ResultsRichTextBox.Margin = new Padding(0, 3, 0, 0);
            f1ResultsRichTextBox.Name = "f1ResultsRichTextBox";
            f1ResultsRichTextBox.ReadOnly = true;
            f1ResultsRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            f1ResultsRichTextBox.Size = new Size(320, 172);
            f1ResultsRichTextBox.TabIndex = 19;
            f1ResultsRichTextBox.Text = "";
            // 
            // f2ResultsRichTextBox
            // 
            f2ResultsRichTextBox.BorderStyle = BorderStyle.FixedSingle;
            f2ResultsRichTextBox.Dock = DockStyle.Fill;
            f2ResultsRichTextBox.Font = new Font("Segoe UI", 12F);
            f2ResultsRichTextBox.Location = new Point(339, 45);
            f2ResultsRichTextBox.Margin = new Padding(0, 3, 0, 0);
            f2ResultsRichTextBox.Name = "f2ResultsRichTextBox";
            f2ResultsRichTextBox.ReadOnly = true;
            f2ResultsRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            f2ResultsRichTextBox.Size = new Size(321, 172);
            f2ResultsRichTextBox.TabIndex = 20;
            f2ResultsRichTextBox.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 160, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(684, 542);
            Controls.Add(mainTableLayoutPanel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 581);
            Name = "MainForm";
            Text = "Course Work Calculator";
            ((System.ComponentModel.ISupportInitialize)studentPhotoPictureBox).EndInit();
            resultsTableLayoutPanel.ResumeLayout(false);
            resultsTableLayoutPanel.PerformLayout();
            outerInputTableLayoutPanel.ResumeLayout(false);
            inner2InputTableLayoutPanel.ResumeLayout(false);
            inner2InputTableLayoutPanel.PerformLayout();
            inner1InputTableLayoutPanel.ResumeLayout(false);
            inner1InputTableLayoutPanel.PerformLayout();
            mainTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label infoInputLabel;
        private Label xMinInputLabel;
        private TextBox xMinTextBox;
        private TextBox xMaxTextBox;
        private Label xMaxInputLabel;
        private TextBox dxTextBox;
        private Label dxInputLabel;
        private PictureBox studentPhotoPictureBox;
        private Label studentInfoLabel;
        private Button calculateButton;
        private Label overallResultsLabel;
        private Label f1ResultsLabel;
        private Label f2ResultsLabel;
        private TableLayoutPanel resultsTableLayoutPanel;
        private Label f1CounterLabel;
        private Label f2CounterLabel;
        private TableLayoutPanel outerInputTableLayoutPanel;
        private TableLayoutPanel inner1InputTableLayoutPanel;
        private TableLayoutPanel inner2InputTableLayoutPanel;
        private TableLayoutPanel mainTableLayoutPanel;
        private Label alphaLabel;
        private TextBox alphaTextBox;
        private RichTextBox f1ResultsRichTextBox;
        private RichTextBox f2ResultsRichTextBox;
    }
}
