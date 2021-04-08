using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreezingBoiling
{
    public partial class Form1 : Form
    {
        double currentTemp = 0;

        //Constant strings that are the only representative of the state of the liquid
        const string frzText = "Frozen solid.";
        const string liqText = "No change. Remains liquid.";
        const string gasText = "Boils into gas.";
        
        //A list of the liquids that are used in this program.
        enum itLiquid { water, alcohol, mercury, oxygen }

        public Form1()
        {
            InitializeComponent();
        }

        //All relevant conditions regarding temperature freeze/boil are handled here.
        private string getState(double temp, itLiquid liquid)
        {
            //These are instanced within this function and are not needed anywhere else.
            double frzTemp;
            double evapTemp;

            //set each seperate liquid state change temperatures.
            if (liquid == itLiquid.alcohol) {
                frzTemp = -173; //Set the minmax within this instance of these variables.
                evapTemp = 172;
            } else if (liquid == itLiquid.mercury) {
                frzTemp = -38;
                evapTemp = 676;
            } else if (liquid == itLiquid.oxygen) {
                frzTemp = -362;
                evapTemp = -306;
            } else { //water
                frzTemp = 32;
                evapTemp = 212;
            }

            // determine the text that will be used to represent the state
            if (temp <= evapTemp && temp >= frzTemp)
            {
                return liqText;
            } else if (temp >= evapTemp) {
                return gasText;
            } else { //determined by elimination
                return frzText;
            }
            //end of getState. these three if() catch all possible circumstances.
        }

        //Pure function which applies a min and max to a value.
        private double minMax(double min, double max, double val)
        {
            if (val > min && val < max) {
                return val;
            } else if (val < min) {
                return min;
            } else { return max; }
        }

        //On enter button click
        private void enterBtn_Click(object sender, EventArgs e)
        {
            currentTemp = Double.Parse(inputTextBox.Text);
            //All the progBars have a min of zero and max equal to the range of degrees between freezing and boiling
            //Thus, to convert the temp to progress bar's value, we need to offset the difference from zero
            //Because progBars do not like numbers outside of min/max, this is limited to their min and max values using minMax()
            progBarAlcohol.Value = Convert.ToInt32(minMax(0, 345, currentTemp+173)); 
            progBarMercury.Value = Convert.ToInt32(minMax(0, 714, currentTemp+38));
            progBarOxygen.Value = Convert.ToInt32(minMax(0, 56, currentTemp+362));
            progBarWater.Value = Convert.ToInt32(minMax(0, 180, currentTemp-32));

            //Assign the state texts
            stateLabelAlcohol.Text = getState(currentTemp, itLiquid.alcohol);
            stateLabelMercury.Text = getState(currentTemp, itLiquid.mercury);
            stateLabelOxygen.Text = getState(currentTemp, itLiquid.oxygen);
            stateLabelWater.Text = getState(currentTemp, itLiquid.water);

            //Recolor the labels. This is janky and could probably be simplified.
            labelReColor(stateLabelAlcohol);
            labelReColor(stateLabelMercury);
            labelReColor(stateLabelOxygen);
            labelReColor(stateLabelWater);
        }

        //Checks the label's text and sets its color if it is freezing or boiling, or revert to black.
        void labelReColor(Label label)
        {
            if (label.Text == frzText) { //This works because of the constant and since label texts only ever equal one of these constants
                label.ForeColor = Color.Blue;
            } else if (label.Text == gasText) {
                label.ForeColor = Color.Red;
            } else { //This also acts as a fail-safe, just in case. Otherwise, this represents the case of liquid state.
                label.ForeColor = Color.Black;
            }
        }

        //Sets the text box to zero and enters it. Essentially emulates the user.
        private void resetBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = 0.ToString(); //convert an integer zero to a string and set it
            enterBtn.PerformClick(); //press the enter button
        }
        //The exit button.
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
