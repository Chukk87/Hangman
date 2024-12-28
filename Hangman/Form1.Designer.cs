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
            triesLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel2.Controls.Add(triesLabel);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(wordToFindLabel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(guessButton);
            panel2.Controls.Add(guessTextBox);
            panel2.Location = new Point(12, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(462, 204);
            panel2.TabIndex = 10;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 334);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
    }
}
