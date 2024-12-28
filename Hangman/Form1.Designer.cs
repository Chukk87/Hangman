namespace Hangman
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
            label1 = new Label();
            wordTextBox = new TextBox();
            guessTextBox = new TextBox();
            label2 = new Label();
            wordToFindLabel = new Label();
            label5 = new Label();
            wordStoreButton = new Button();
            guessButton = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            hangmanPic7c = new PictureBox();
            hangmanPic7b = new PictureBox();
            hangmanPic7a = new PictureBox();
            hangmanPic6b = new PictureBox();
            hangmanPic6a = new PictureBox();
            hangmanPic5 = new PictureBox();
            hangmanPic4 = new PictureBox();
            hangmanPic3 = new PictureBox();
            hangmanPic2 = new PictureBox();
            hangmanPic1 = new PictureBox();
            triesLabel = new Label();
            label4 = new Label();
            guessedLettersLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hangmanPic7c).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic7b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic7a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic6b).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic6a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 40);
            label1.TabIndex = 0;
            label1.Text = "HANGMAN";
            // 
            // wordTextBox
            // 
            wordTextBox.Location = new Point(6, 23);
            wordTextBox.Name = "wordTextBox";
            wordTextBox.Size = new Size(222, 23);
            wordTextBox.TabIndex = 1;
            // 
            // guessTextBox
            // 
            guessTextBox.Location = new Point(176, 119);
            guessTextBox.Name = "guessTextBox";
            guessTextBox.Size = new Size(53, 23);
            guessTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 110);
            label2.Name = "label2";
            label2.Size = new Size(152, 30);
            label2.TabIndex = 3;
            label2.Text = "Letter to Guess";
            // 
            // wordToFindLabel
            // 
            wordToFindLabel.AutoSize = true;
            wordToFindLabel.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wordToFindLabel.Location = new Point(3, 9);
            wordToFindLabel.Name = "wordToFindLabel";
            wordToFindLabel.Size = new Size(172, 86);
            wordToFindLabel.TabIndex = 5;
            wordToFindLabel.Text = "*****";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 157);
            label5.Name = "label5";
            label5.Size = new Size(161, 30);
            label5.TabIndex = 6;
            label5.Text = "Number of Tries";
            // 
            // wordStoreButton
            // 
            wordStoreButton.Location = new Point(234, 23);
            wordStoreButton.Name = "wordStoreButton";
            wordStoreButton.Size = new Size(83, 23);
            wordStoreButton.TabIndex = 7;
            wordStoreButton.Text = "Create Game";
            wordStoreButton.UseVisualStyleBackColor = true;
            wordStoreButton.Click += wordStoreButton_Click;
            // 
            // guessButton
            // 
            guessButton.Location = new Point(235, 118);
            guessButton.Name = "guessButton";
            guessButton.Size = new Size(83, 23);
            guessButton.TabIndex = 8;
            guessButton.Text = "Guess";
            guessButton.UseVisualStyleBackColor = true;
            guessButton.Click += guessButton_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(wordTextBox);
            panel1.Controls.Add(wordStoreButton);
            panel1.Location = new Point(12, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 63);
            panel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 5);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 0;
            label3.Text = "Word to Guess";
            // 
            // panel2
            // 
            panel2.Controls.Add(guessedLettersLabel);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(hangmanPic7c);
            panel2.Controls.Add(hangmanPic7b);
            panel2.Controls.Add(hangmanPic7a);
            panel2.Controls.Add(hangmanPic6b);
            panel2.Controls.Add(hangmanPic6a);
            panel2.Controls.Add(hangmanPic5);
            panel2.Controls.Add(hangmanPic4);
            panel2.Controls.Add(hangmanPic3);
            panel2.Controls.Add(hangmanPic2);
            panel2.Controls.Add(hangmanPic1);
            panel2.Controls.Add(triesLabel);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(wordToFindLabel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(guessButton);
            panel2.Controls.Add(guessTextBox);
            panel2.Location = new Point(12, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 285);
            panel2.TabIndex = 10;
            // 
            // hangmanPic7c
            // 
            hangmanPic7c.BackColor = SystemColors.ActiveCaptionText;
            hangmanPic7c.Location = new Point(501, 155);
            hangmanPic7c.Name = "hangmanPic7c";
            hangmanPic7c.Size = new Size(10, 30);
            hangmanPic7c.TabIndex = 18;
            hangmanPic7c.TabStop = false;
            hangmanPic7c.Visible = false;
            // 
            // hangmanPic7b
            // 
            hangmanPic7b.BackColor = SystemColors.ActiveCaptionText;
            hangmanPic7b.Location = new Point(475, 155);
            hangmanPic7b.Name = "hangmanPic7b";
            hangmanPic7b.Size = new Size(10, 30);
            hangmanPic7b.TabIndex = 13;
            hangmanPic7b.TabStop = false;
            hangmanPic7b.Visible = false;
            // 
            // hangmanPic7a
            // 
            hangmanPic7a.BackColor = SystemColors.ActiveCaptionText;
            hangmanPic7a.Location = new Point(475, 141);
            hangmanPic7a.Name = "hangmanPic7a";
            hangmanPic7a.Size = new Size(36, 14);
            hangmanPic7a.TabIndex = 17;
            hangmanPic7a.TabStop = false;
            hangmanPic7a.Visible = false;
            // 
            // hangmanPic6b
            // 
            hangmanPic6b.BackColor = SystemColors.ActiveCaptionText;
            hangmanPic6b.Location = new Point(497, 91);
            hangmanPic6b.Name = "hangmanPic6b";
            hangmanPic6b.Size = new Size(36, 14);
            hangmanPic6b.TabIndex = 16;
            hangmanPic6b.TabStop = false;
            hangmanPic6b.Visible = false;
            // 
            // hangmanPic6a
            // 
            hangmanPic6a.BackColor = SystemColors.ActiveCaptionText;
            hangmanPic6a.Location = new Point(453, 91);
            hangmanPic6a.Name = "hangmanPic6a";
            hangmanPic6a.Size = new Size(36, 14);
            hangmanPic6a.TabIndex = 12;
            hangmanPic6a.TabStop = false;
            hangmanPic6a.Visible = false;
            // 
            // hangmanPic5
            // 
            hangmanPic5.BackColor = SystemColors.ActiveCaptionText;
            hangmanPic5.Location = new Point(488, 75);
            hangmanPic5.Name = "hangmanPic5";
            hangmanPic5.Size = new Size(10, 66);
            hangmanPic5.TabIndex = 12;
            hangmanPic5.TabStop = false;
            hangmanPic5.Visible = false;
            // 
            // hangmanPic4
            // 
            hangmanPic4.BackColor = SystemColors.ActiveCaptionText;
            hangmanPic4.Location = new Point(478, 44);
            hangmanPic4.Name = "hangmanPic4";
            hangmanPic4.Size = new Size(30, 31);
            hangmanPic4.TabIndex = 14;
            hangmanPic4.TabStop = false;
            hangmanPic4.Visible = false;
            // 
            // hangmanPic3
            // 
            hangmanPic3.BackColor = SystemColors.ActiveCaptionText;
            hangmanPic3.Location = new Point(488, 19);
            hangmanPic3.Name = "hangmanPic3";
            hangmanPic3.Size = new Size(10, 25);
            hangmanPic3.TabIndex = 13;
            hangmanPic3.TabStop = false;
            hangmanPic3.Visible = false;
            // 
            // hangmanPic2
            // 
            hangmanPic2.BackColor = SystemColors.ActiveCaptionText;
            hangmanPic2.Location = new Point(382, 9);
            hangmanPic2.Name = "hangmanPic2";
            hangmanPic2.Size = new Size(116, 10);
            hangmanPic2.TabIndex = 12;
            hangmanPic2.TabStop = false;
            hangmanPic2.Visible = false;
            // 
            // hangmanPic1
            // 
            hangmanPic1.BackColor = SystemColors.ActiveCaptionText;
            hangmanPic1.Location = new Point(382, 19);
            hangmanPic1.Name = "hangmanPic1";
            hangmanPic1.Size = new Size(10, 180);
            hangmanPic1.TabIndex = 11;
            hangmanPic1.TabStop = false;
            hangmanPic1.Visible = false;
            // 
            // triesLabel
            // 
            triesLabel.AutoSize = true;
            triesLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            triesLabel.Location = new Point(176, 157);
            triesLabel.Name = "triesLabel";
            triesLabel.Size = new Size(24, 30);
            triesLabel.TabIndex = 10;
            triesLabel.Text = "7";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 204);
            label4.Name = "label4";
            label4.Size = new Size(159, 30);
            label4.TabIndex = 19;
            label4.Text = "Letters Guessed";
            // 
            // guessedLettersLabel
            // 
            guessedLettersLabel.AutoSize = true;
            guessedLettersLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guessedLettersLabel.Location = new Point(176, 204);
            guessedLettersLabel.Name = "guessedLettersLabel";
            guessedLettersLabel.Size = new Size(0, 30);
            guessedLettersLabel.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 418);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hangmanPic7c).EndInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic7b).EndInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic7a).EndInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic6b).EndInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic6a).EndInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic5).EndInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic4).EndInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hangmanPic1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox wordTextBox;
        private TextBox guessTextBox;
        private Label label2;
        private Label wordToFindLabel;
        private Label label5;
        private Button wordStoreButton;
        private Button guessButton;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Label triesLabel;
        private PictureBox hangmanPic7a;
        private PictureBox hangmanPic6b;
        private PictureBox hangmanPic6a;
        private PictureBox hangmanPic5;
        private PictureBox hangmanPic4;
        private PictureBox hangmanPic3;
        private PictureBox hangmanPic2;
        private PictureBox hangmanPic1;
        private PictureBox hangmanPic7b;
        private PictureBox hangmanPic7c;
        private Label guessedLettersLabel;
        private Label label4;
    }
}
