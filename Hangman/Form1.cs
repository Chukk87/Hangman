namespace Hangman
{
    public partial class Form1 : Form
    {
        string wordStored = string.Empty;
        List<char> letters = new List<char>();
        int numberOfTries = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void wordStoreButton_Click(object sender, EventArgs e)
        {
            wordStored = wordTextBox.Text; //Here we are storing the text in the textbox into our string variable which we named wordStored
            wordToFindLabel.Text = new string('_', wordStored.Length); //Here we are setting the label so a player can see how many letters to guess.
                                                                       // we replace the letters with "_" so the word is hidden
            letters = new List<char>();
            numberOfTries = 7; //Here we are setting the max number of guesses
            triesLabel.Text = numberOfTries.ToString(); //Here we are setting the tries label so a player can see how many tries they have left

            MessageBox.Show("Guess the word, Good Luck!"); //Here we give a player a messagebox so a player can see the game has started
        }

        private void guessButton_Click(object sender, EventArgs e)
        { 
            char guessLetter = guessTextBox.Text[0]; 

            foreach (char letter in letters) 
            { 
                if (letter == guessLetter)
                {
                    MessageBox.Show("Already guessed this letter");

                    return;
                }
            }

            letters.Add(guessLetter);

            if(!wordStored.Contains(guessLetter))
            {
                numberOfTries--;

                triesLabel.Text = numberOfTries.ToString();
            }

            if (numberOfTries == 0)
            {
                MessageBox.Show("No more guesses, the word was " + wordStored);
            }

            string displayWord = string.Empty;

            foreach (char letter in wordStored) 
            {
                if(letters.Contains(letter))
                {
                    displayWord = string.Concat(displayWord, " " + letter + " ");
                }
                else
                {
                    displayWord = string.Concat(displayWord, " _ ");
                }
            }

            wordToFindLabel.Text = displayWord;
        }
    }
}
