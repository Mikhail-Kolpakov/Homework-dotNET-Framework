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
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            pictureBox = new PictureBox();
            ViewButton = new Button();
            SaveButton = new Button();
            CleanButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(432, 250);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.MouseMove += PictureBox_MouseMove;
            pictureBox.MouseUp += PictureBox_MouseUp;
            // 
            // ViewButton
            // 
            ViewButton.FlatAppearance.BorderColor = Color.Black;
            ViewButton.FlatStyle = FlatStyle.Flat;
            ViewButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ViewButton.Location = new Point(12, 268);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(140, 47);
            ViewButton.TabIndex = 1;
            ViewButton.Text = "Огляд";
            ViewButton.UseVisualStyleBackColor = true;
            ViewButton.Click += ViewButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.FlatAppearance.BorderColor = Color.Black;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SaveButton.Location = new Point(158, 268);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(140, 47);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Зберегти";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CleanButton
            // 
            CleanButton.FlatAppearance.BorderColor = Color.Black;
            CleanButton.FlatStyle = FlatStyle.Flat;
            CleanButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CleanButton.Location = new Point(304, 268);
            CleanButton.Name = "CleanButton";
            CleanButton.Size = new Size(140, 47);
            CleanButton.TabIndex = 3;
            CleanButton.Text = "Очистити";
            CleanButton.UseVisualStyleBackColor = true;
            CleanButton.Click += CleanButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 323);
            Controls.Add(CleanButton);
            Controls.Add(SaveButton);
            Controls.Add(ViewButton);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Ex1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private PictureBox pictureBox;
        private Button ViewButton;
        private Button SaveButton;
        private Button CleanButton;
    }
}
