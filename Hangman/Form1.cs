namespace Hangman
{
    public partial class Form1 : Form
    {
        string wordStored = string.Empty;
        List<char> letters = new List<char>();
        int numberOfTries = 0;
        bool finished = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void wordStoreButton_Click(object sender, EventArgs e)
        {
            ResetHangman();

            finished = false;
            guessedLettersLabel.Text = string.Empty;
            wordStored = wordTextBox.Text.ToUpper(); //Here we are storing the text in the textbox into our string variable which we named wordStored
            wordTextBox.Text = string.Empty;
            wordToFindLabel.Text = new string('_', wordStored.Length); //Here we are setting the label so a player can see how many letters to guess.
                                                                       // we replace the letters with "_" so the word is hidden
            letters = new List<char>();
            numberOfTries = 7; //Here we are setting the max number of guesses
            triesLabel.Text = numberOfTries.ToString(); //Here we are setting the tries label so a player can see how many tries they have left

            MessageBox.Show("Guess the word, Good Luck!"); //Here we give a player a messagebox so a player can see the game has started
        }

        private void guessButton_Click(object sender, EventArgs e)
        { 
            if(finished)
            {
                MessageBox.Show("Game has completed, start a new game");

                return;
            }

            char guessLetter = guessTextBox.Text.ToUpper()[0]; 

            foreach (char letter in letters) 
            { 
                if (letter == guessLetter)
                {
                    MessageBox.Show("Already guessed this letter");

                    return;
                }
            }

            letters.Add(guessLetter);

            if (!wordStored.Contains(guessLetter) && numberOfTries > 0)
            {
                guessedLettersLabel.Text = string.Join(" ", guessedLettersLabel.Text, guessLetter);
                numberOfTries--;

                triesLabel.Text = numberOfTries.ToString();

                SetHangman();
            }

            if (numberOfTries == 0)
            {
                finished = true;
                MessageBox.Show("No more guesses, the word was " + wordStored);

                return;
            }

            string displayWord = string.Empty;

            int letterFound = 0;
            int storedWordCount = wordStored.Length;

            foreach (char letter in wordStored) 
            {
                if(letters.Contains(letter))
                {
                    displayWord = string.Concat(displayWord, letter);

                    letterFound++;
                }
                else
                {
                    displayWord = string.Concat(displayWord, "_");
                }
            }

            wordToFindLabel.Text = displayWord;

            if (letterFound == storedWordCount)
            {
                finished = true;

                MessageBox.Show("You win!");
            }
        }

        private void ResetHangman()
        {
            hangmanPic1.Visible = false;
            hangmanPic2.Visible = false;
            hangmanPic3.Visible = false;
            hangmanPic4.Visible = false;
            hangmanPic5.Visible = false;
            hangmanPic6a.Visible = false;
            hangmanPic6b.Visible = false;
            hangmanPic7a.Visible = false;
            hangmanPic7b.Visible = false;
            hangmanPic7c.Visible = false;
        }

        private void SetHangman()
        {
            switch(numberOfTries)
            {
                case 6:
                    hangmanPic1.Visible = true;
                    break;
                case 5:
                    hangmanPic2.Visible = true;
                    break;
                case 4:
                    hangmanPic3.Visible = true;
                    break;
                case 3:
                    hangmanPic4.Visible = true;
                    break;
                case 2:
                    hangmanPic5.Visible = true;
                    break;
                case 1:
                    hangmanPic6a.Visible = true;
                    hangmanPic6b.Visible = true;
                    break;
                case 0:
                    hangmanPic7a.Visible = true;
                    hangmanPic7b.Visible = true;
                    hangmanPic7c.Visible = true;
                    break;
            }
        }
    }
}
