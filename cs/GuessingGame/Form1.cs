using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class FormGuessGame : Form
    {
        public FormGuessGame()
        {
            InitializeComponent();
        }

        //guessTextBox
        //minNum (numeric updown)
        //maxNum

        int minimum;
        int maximum;
        int target; // the correct number
        int tryCount = 0;
        String lowText = "Too low!";
        String highText = "Too high!";
        String winText = "You win!";

        private void guessBtn_Click(object sender, EventArgs e) {
            //determine hit
            if (int.Parse(guessTextBox.Text) == target) {
                //winning
                lblGuess.Text = winText;
                //disbale guessing
                guessBtn.Enabled = false;
            } else if (int.Parse(guessTextBox.Text) < target) {//if below
                lblGuess.Text = lowText;
            } else {//else, is above
                lblGuess.Text = highText;
            }
            tryCount++;
            lblGuessCounter.Text = tryCount.ToString();
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void resetBtn_Click(object sender, EventArgs e) {
            //reset min and max
            minNum.Value = minNum.Minimum;
            maxNum.Value = maxNum.Maximum;
            //enable min/max and start
            minNum.Enabled = true;
            maxNum.Enabled = true;
            startBtn.Enabled = true;
            //disable guessing
            guessTextBox.Enabled = false;
            guessBtn.Enabled = false;
            //reset counter
            tryCount = 0;
            lblGuessCounter.Text = tryCount.ToString();
        }

        private void startBtn_Click(object sender, EventArgs e) {
            //save min and max to local
            minimum = Decimal.ToInt32(minNum.Value);
            maximum = Decimal.ToInt32(maxNum.Value);
            //disable min/max and start
            minNum.Enabled = false;
            maxNum.Enabled = false;
            startBtn.Enabled = false;
            //enable guessing
            guessBtn.Enabled = true;
            guessTextBox.Enabled = true;
            //set the target using Random between minimum and maximum
            Random r = new Random();
            target = r.Next(minimum, maximum);
        }

        private void guessTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            //discard invalid inputs (any non-numeric)
            if (!char.IsDigit(e.KeyChar)) {
                e.Handled = true; //Prevents further usage of the event - the invalid key
            }
        }
    }
}
