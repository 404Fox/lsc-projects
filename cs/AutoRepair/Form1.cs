using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRepair
{
    public partial class AutoRepairForm : Form
    {
        public AutoRepairForm()
        {
            InitializeComponent();
        }

        bool invertBool(bool input) { return !input; }

        //returns zero if the value was invalid and 
        double getAnyDoubleFromText(string input) {
            //Create a local variable for tryparse
            double myDouble;
            if(Double.TryParse(input, out myDouble))//pass mydouble by reference so that tryparse can set it
            {
                return myDouble;
            } else { return 0; }
        }

        private void togBtnOilLube_Click(object sender, EventArgs e) {
            //Enable all if both boxes have the same value
            if(cbLube.Checked == cbOil.Checked) {
                cbLube.Checked = invertBool(cbLube.Checked); //there's a more interesting and compact way to do this
                cbOil.Checked = invertBool(cbOil.Checked); //but I didn't take the time to research it
            } else { //Else (mixed values) make all boxes true
                cbLube.Checked = true;
                cbOil.Checked = true;
            }
        }
        //Enable all if both boxes have the same value
        private void togBtnMisc_Click(object sender, EventArgs e) {
            if (cbInspection.Checked == cbMuffler.Checked && cbMuffler.Checked == cbRotation.Checked) {
                cbInspection.Checked = invertBool(cbInspection.Checked);
                cbMuffler.Checked = invertBool(cbMuffler.Checked);
                cbRotation.Checked = invertBool(cbRotation.Checked);
            } else {
                cbInspection.Checked = true;
                cbMuffler.Checked = true;
                cbRotation.Checked = true;
            }
        }
        //Enable all if both boxes have the same value
        private void togBtnFluid_Click(object sender, EventArgs e) {
            if (cbTransmission.Checked == cbRadiator.Checked) {
                cbRadiator.Checked = invertBool(cbRadiator.Checked);
                cbTransmission.Checked = invertBool(cbTransmission.Checked);
            } else {
                cbTransmission.Checked = true;
                cbRadiator.Checked = true;
            }
        }
        //Reset input text boxes to 0.00
        private void resetPartsLaborBtn_Click(object sender, EventArgs e) {
            textBoxLabor.Text = "0.00";
            textBoxParts.Text = "0.00";
        }

        private void getTotalBtn_Click(object sender, EventArgs e) {
            //temporary definitions for this function
            double sumLabor = 0;
            double sumParts = 0;
            double sumTax = 0;
            double sumTotal = 0;
            //hardcoded rates for each check box
            if (cbOil.Checked) { sumLabor += 26.0d; }
            if (cbLube.Checked) { sumLabor += 18; }
            if (cbRadiator.Checked) { sumLabor += 30; }
            if (cbTransmission.Checked) { sumLabor += 80; }
            if (cbInspection.Checked) { sumLabor += 15; }
            if (cbMuffler.Checked) { sumLabor += 100; }
            if (cbRotation.Checked) { sumLabor += 20; }
            //calculate the total
            sumParts = getAnyDoubleFromText(textBoxParts.Text);
            sumLabor += getAnyDoubleFromText(textBoxLabor.Text);
            sumTax = (sumParts + sumLabor) * 0.0875; //Apply tax rate on total
            sumTotal = sumLabor + sumLabor + sumTax; //save total to teh variable
            //display summary texts
            const string myFormat = "C2";
            textBoxLaborSum.Text = sumLabor.ToString(myFormat); //Use currency formatting
            textBoxPartsSum.Text = sumParts.ToString(myFormat);
            textBoxTaxSum.Text = sumTax.ToString(myFormat);
            textBoxTotalSum.Text = sumTotal.ToString(myFormat);

        }

        private void resetMisc() {
            cbInspection.Checked = false;
            cbMuffler.Checked = false;
            cbRotation.Checked = false;
        }
        private void resetOilLube() {
            cbOil.Checked = false;
            cbLube.Checked = false;
        }

        private void resetFluids() {
            cbRadiator.Checked = false;
            cbTransmission.Checked = false;
        }

        private void resetSummary() {
            const String muhDefault = "$0.00";
            textBoxLaborSum.Text = muhDefault;
            textBoxPartsSum.Text = muhDefault;
            textBoxTaxSum.Text = muhDefault;
            textBoxTotalSum.Text = muhDefault;
        }

        private void resetAllBtn_Click(object sender, EventArgs e) {
            resetPartsLaborBtn_Click(this, e);
            resetMisc();
            resetOilLube();
            resetFluids();
            resetSummary();
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //Validate to only allow number input. Used for all the text boxes.
        private void textBox_OnKeyPress_ValidateNum(object sender, KeyPressEventArgs e)
        {//On keypress in the text box
            // Prevent the input of unallowed characters
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar == '.')) {
                e.Handled = true; //Prevents further usage of the event - the invalid key
            }//Otherwise, continues and the value is handled properly
        }

        private void textBox_KeyPress_DoNothing(object sender, KeyPressEventArgs e) {
            e.Handled = true; //prematurely ends teh keypress event, thus keypress is not processed at all;
        }

    }
}
