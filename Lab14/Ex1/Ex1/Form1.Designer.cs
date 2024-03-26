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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            startButton = new Button();
            xMinLabel = new Label();
            xMaxLabel = new Label();
            dx = new Label();
            xMinTextBox = new TextBox();
            xMaxTextBox = new TextBox();
            dxTextBox = new TextBox();
            resultsListBox = new ListBox();
            pictureBox1 = new PictureBox();
            constTextBox = new TextBox();
            constLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startButton.Location = new Point(12, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(288, 41);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += button1_Click;
            // 
            // xMinLabel
            // 
            xMinLabel.AutoSize = true;
            xMinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            xMinLabel.Location = new Point(12, 125);
            xMinLabel.Name = "xMinLabel";
            xMinLabel.Size = new Size(49, 21);
            xMinLabel.TabIndex = 1;
            xMinLabel.Text = "xMin";
            xMinLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // xMaxLabel
            // 
            xMaxLabel.AutoSize = true;
            xMaxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            xMaxLabel.Location = new Point(12, 172);
            xMaxLabel.Name = "xMaxLabel";
            xMaxLabel.Size = new Size(52, 21);
            xMaxLabel.TabIndex = 2;
            xMaxLabel.Text = "xMax";
            xMaxLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // dx
            // 
            dx.AutoSize = true;
            dx.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dx.Location = new Point(12, 214);
            dx.Name = "dx";
            dx.Size = new Size(29, 21);
            dx.TabIndex = 3;
            dx.Text = "dx";
            dx.TextAlign = ContentAlignment.TopCenter;
            // 
            // xMinTextBox
            // 
            xMinTextBox.Font = new Font("Segoe UI", 12F);
            xMinTextBox.Location = new Point(67, 123);
            xMinTextBox.Name = "xMinTextBox";
            xMinTextBox.Size = new Size(233, 29);
            xMinTextBox.TabIndex = 4;
            // 
            // xMaxTextBox
            // 
            xMaxTextBox.Font = new Font("Segoe UI", 12F);
            xMaxTextBox.Location = new Point(67, 164);
            xMaxTextBox.Name = "xMaxTextBox";
            xMaxTextBox.Size = new Size(233, 29);
            xMaxTextBox.TabIndex = 5;
            // 
            // dxTextBox
            // 
            dxTextBox.Font = new Font("Segoe UI", 12F);
            dxTextBox.Location = new Point(67, 206);
            dxTextBox.Name = "dxTextBox";
            dxTextBox.Size = new Size(233, 29);
            dxTextBox.TabIndex = 6;
            // 
            // resultsListBox
            // 
            resultsListBox.FormattingEnabled = true;
            resultsListBox.ItemHeight = 15;
            resultsListBox.Location = new Point(318, 12);
            resultsListBox.Name = "resultsListBox";
            resultsListBox.Size = new Size(303, 274);
            resultsListBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // constTextBox
            // 
            constTextBox.Font = new Font("Segoe UI", 12F);
            constTextBox.Location = new Point(67, 246);
            constTextBox.Name = "constTextBox";
            constTextBox.Size = new Size(233, 29);
            constTextBox.TabIndex = 10;
            // 
            // constLabel
            // 
            constLabel.AutoSize = true;
            constLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            constLabel.Location = new Point(10, 254);
            constLabel.Name = "constLabel";
            constLabel.Size = new Size(51, 21);
            constLabel.TabIndex = 9;
            constLabel.Text = "const";
            constLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 299);
            Controls.Add(constTextBox);
            Controls.Add(constLabel);
            Controls.Add(pictureBox1);
            Controls.Add(resultsListBox);
            Controls.Add(dxTextBox);
            Controls.Add(xMaxTextBox);
            Controls.Add(xMinTextBox);
            Controls.Add(dx);
            Controls.Add(xMaxLabel);
            Controls.Add(xMinLabel);
            Controls.Add(startButton);
            Name = "Form1";
            Text = "Ex1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label xMinLabel;
        private Label xMaxLabel;
        private Label dx;
        private TextBox xMinTextBox;
        private TextBox xMaxTextBox;
        private TextBox dxTextBox;
        private ListBox resultsListBox;
        private PictureBox pictureBox1;
        private TextBox constTextBox;
        private Label constLabel;
    }
}
