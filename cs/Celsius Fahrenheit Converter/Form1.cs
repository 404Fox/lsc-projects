using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_Fahrenheit_Converter
{
    public partial class TempConvForm : Form
    {
        public TempConvForm()
        {
            InitializeComponent();
        }

        //Further conditional checks to prevent possible errors.
        private bool verifyString(string input) {
            if (input == "" || input == ".") { //Other likely textbox contents.
                return false;
            } else {
                return true;
            }
        }

        //Input conditions, prevent any non-number inputs to textboxes.
        private void textBoxKeyPress_numberOnly(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.') { //if the char is not a digit nor '.', then
                e.Handled = true; //prematurely discard the event keypress and its character.
            }
        }

        //Convert the contents of fahrenheit textbox to assign the number in the celsius textbox
        private void fhtBtn_Click(object sender, EventArgs e) {
            if (verifyString(fhtTextBox.Text)) { //Pass this through the verify function defined earlier.
                clsTextBox.Text = Convert.ToString(9 / 5 * (Double.Parse(fhtTextBox.Text) - 32)); //Calculate and assign celsius
            } else { //If verify return false, then:
                MessageBox.Show("The input for fahrenheit was invalid. Please try again."); //Fail-safe just in case.
                
            }
        }

        //Convert celsius to fahrenheit. This function is essentially same as above, but different formula and messagebox text.
        private void clsBtn_Click(object sender, EventArgs e) {
            if (verifyString(clsTextBox.Text)) {
                fhtTextBox.Text = Convert.ToString(9 / 5 * Double.Parse(clsTextBox.Text) + 32);
            } else {
                MessageBox.Show("The input for celsius was invalid. Please try again.");
            }
        }

        //Clear the contents of both text boxes.
        private void clearBtn_Click(object sender, EventArgs e) {
            clsTextBox.Text = "";
            fhtTextBox.Text = "";
        }
    }
}
