namespace The_Cat_API_in_C_
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
            CatRequestButton = new Button();
            PictureBox = new PictureBox();
            UILabel1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // CatRequestButton
            // 
            CatRequestButton.Location = new Point(191, 386);
            CatRequestButton.Name = "CatRequestButton";
            CatRequestButton.Size = new Size(90, 23);
            CatRequestButton.TabIndex = 0;
            CatRequestButton.Text = "Request Cat!";
            CatRequestButton.UseVisualStyleBackColor = true;
            CatRequestButton.Click += CatRequestButton_Click;
            // 
            // PictureBox
            // 
            PictureBox.Location = new Point(12, 12);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(452, 348);
            PictureBox.TabIndex = 1;
            PictureBox.TabStop = false;
            // 
            // UILabel1
            // 
            UILabel1.AutoSize = true;
            UILabel1.BackColor = Color.Transparent;
            UILabel1.ForeColor = SystemColors.ActiveCaptionText;
            UILabel1.Location = new Point(12, 426);
            UILabel1.Name = "UILabel1";
            UILabel1.Size = new Size(237, 15);
            UILabel1.TabIndex = 2;
            UILabel1.Text = "Note: First image grab might take a second!";
            // 
            // button1
            // 
            button1.Location = new Point(334, 418);
            button1.Name = "button1";
            button1.Size = new Size(133, 23);
            button1.TabIndex = 3;
            button1.Text = "Copy Cat to Clipboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(479, 450);
            Controls.Add(button1);
            Controls.Add(UILabel1);
            Controls.Add(PictureBox);
            Controls.Add(CatRequestButton);
            Name = "Form1";
            ShowIcon = false;
            Text = "The Cat API In C#!";
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CatRequestButton;
        private PictureBox PictureBox;
        private Label UILabel1;
        private Button button1;
    }
}
