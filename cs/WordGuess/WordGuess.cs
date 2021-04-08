using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuess
{
    public partial class WordGuessForm : Form
    {
        string[] wordList;
        Random random;

        public WordGuessForm()
        {
            InitializeComponent();
            //Attempt to read the wordlist.txt file
            try
            {
                wordList = System.IO.File.ReadAllLines(@"wordlist.txt");
            } catch (Exception e) {
                MessageBox.Show("Unable to read wordlist.txt Please make sure it is located in the same directory as this program.");
                Application.Exit();
            }
            random = new Random();

            newGameBtn_Click(this, EventArgs.Empty); //new game on start of the form
        }

        string dWord;
        string userInputWord; //Always matches the length of dWord. Fill with spaces.
        string charsAttempted;

        private string SetSingleChar(string input, int index, char myChar)
        {
            char[] array = input.ToCharArray(); //Convert the string to a character array
            array[index] = myChar; //Set the character
            return new string(array); //return the char array as a string
        }

        private void updateUserInput()
        {
            string makString = "";
            if (dWord.Length != userInputWord.Length)
            {
                throw new Exception("What did you doooooo");
            }
            for (int i = 0; i < userInputWord.Length; i++ )
            {
                if (dWord[i] != userInputWord[i]) {
                    //makString.Append('_');
                    makString += '_';
                } else {
                    //makString.Append(dWord[i]);
                    makString += dWord[i];
                }
            }
            displayWordLabel.Text = makString;
        }
        private void updateAttemptList()
        {
            string makString = "";
            if (charsAttempted != null) //I was trying to use charsAttempted without initializing it in the constructor but I ended up making this condition redundant by going the easy way
            {
                for (int i = 0; i < charsAttempted.Length; i++)
                {
                    //makString.Append(charsAttempted[i]);
                    makString += charsAttempted[i];
                    makString += " ";
                }
            }
            attemptList.Text = makString;

        }

        private bool isWordMatchDWord(string inputWord)
        {
            for (int i = 0; i < dWord.Length; i++) //loop on dword
            {
                if (dWord[i] != inputWord[i])
                {
                    return false; //if any char does not match, then false
                }
            }
            return true; //default case upon finishing the loop, return true
        }

        private void newGameBtn_Click(object sender, EventArgs e) {
            //Select a new dWord
            int wordIndex = random.Next(0, wordList.Length-1);
            dWord = wordList[wordIndex];

            //dWord = "test";
            //Fill the userINputWord iwth spaces matching the length of dWord
            userInputWord = dWord;
            for (int i = 0; i < userInputWord.Length; i++)
            {
                userInputWord = SetSingleChar(userInputWord, i, ' ');
            }
            charsAttempted = "";
            //Update
            updateUserInput();
            updateAttemptList();
        }

        private void gameOver() {
            //enter a game over state
            string winString = " --- GAME OVER";
            string nuString = dWord + winString;
            displayWordLabel.Text = nuString;
        }

        //test a letter
        private void sendLetterBtn_Click(object sender, EventArgs e) {
            //check for null input to prevent crash
            if (letterTextBox.Text == null || letterTextBox.Text.Length == 0) { return; }
            char inputChar = char.Parse(letterTextBox.Text);

            bool changeMade = false;
            //check if dWord contains the char
            for (int i = 0; i < dWord.Length; i++)
            {
                if (dWord[i] == inputChar)
                {
                    userInputWord = SetSingleChar(userInputWord, i, inputChar); //Update a single char in the user input array
                    changeMade = true; //use this IF we do not want to include a correct char in the attempted chars list
                }
            }
            updateUserInput();

            //check for he gameover condition
            if (isWordMatchDWord(userInputWord)) {
                gameOver();
            } else { //The dWord does not contain the char and the word is not completed
                if (!charsAttempted.Contains(inputChar)) { 
                    charsAttempted += inputChar;
                    updateAttemptList();
                }
                
            }
        }

        //word check button
        private void sendWordBtn_Click(object sender, EventArgs e) {
            //check for null input
            if (wordTextBox.Text == null || wordTextBox.Text.Length == 0) { return; }
            //Check if the user submitted the correct word.
            if (isWordMatchDWord(wordTextBox.Text)) {
                gameOver();
            }
        }

        //exit button
        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //sanitize inputs
        private void wordTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) { //provde the char held by e to static IsLetter and use that as the condition
                e.Handled = true; //after if NOT, then prevent futher usage of e this way
            } 
            if (char.IsUpper(e.KeyChar)) //Convert all upper case to lower case
            {
                e.KeyChar = char.ToLower(e.KeyChar);
            }

        }
    }
}
