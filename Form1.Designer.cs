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
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // CatRequestButton
            // 
            CatRequestButton.Location = new Point(191, 366);
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
            PictureBox.Size = new Size(452, 268);
            PictureBox.TabIndex = 1;
            PictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 450);
            Controls.Add(PictureBox);
            Controls.Add(CatRequestButton);
            Name = "Form1";
            Text = "The Cat API In C#!";
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CatRequestButton;
        private PictureBox PictureBox;
    }
}
