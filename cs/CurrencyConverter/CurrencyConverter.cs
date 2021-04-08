using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CurrencyConverter
{
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
        }

        double amountUsd;
        double amountJpy;
        double amountFrf;
        double amountGbp;
        double amountDem;

        enum ECurrencies { USD, JPY, FRF, GBP, DEM }

        private void updateValues(ECurrencies source) {
            switch (source) { //Switch on source, which we change for the call.
                case ECurrencies.JPY:
                    {
                        amountUsd = amountJpy / 104.92;
                        break;
                    }
                case ECurrencies.GBP:
                    {
                        amountUsd = amountGbp / 0.72158;
                        break;
                    }
                case ECurrencies.FRF:
                    {
                        amountUsd = amountFrf / 5.41129;
                        break;
                    }
                case ECurrencies.DEM:
                    {
                        amountUsd = amountDem / 1.61345;
                        break;
                    }
                default: break;
            }
            convertFromUsd();//Sets the values for all other currencies.
            // Detatch the event handler functions that trigger by text changing.
            // This prevents a stack overflow resulting from triggering the event by changing the text in this function.
            textBoxUsd.TextChanged -= textBoxUsd_TextChanged;
            textBoxJpy.TextChanged -= textBoxJpy_TextChanged;
            textBoxGbp.TextChanged -= textBoxGbp_TextChanged;
            textBoxFrf.TextChanged -= textBoxFrf_TextChanged;
            textBoxDem.TextChanged -= textBoxDem_TextChanged;
            //textBoxUsd.Text = String.Format("{0:N0}", amountUsd);
            //I tried this, but then I would have to parse input which had a variety of characters thrown into it.
            textBoxUsd.Text = amountUsd.ToString();
            textBoxDem.Text = amountDem.ToString();
            textBoxFrf.Text = amountFrf.ToString();
            textBoxGbp.Text = amountGbp.ToString();
            textBoxJpy.Text = amountJpy.ToString();
            //Reattach the event handlers that trigger by text changing.
            //This conundrum results because OnChange works better than OnKeyPress.
            //OnKeyPress will only update AFTER a press which meant that conversions were happening a step behind a change in the text.
            textBoxUsd.TextChanged += textBoxUsd_TextChanged;
            textBoxJpy.TextChanged += textBoxJpy_TextChanged;
            textBoxGbp.TextChanged += textBoxGbp_TextChanged;
            textBoxFrf.TextChanged += textBoxFrf_TextChanged;
            textBoxDem.TextChanged += textBoxDem_TextChanged;
        }

        private void convertFromUsd()//Converts all other currencies. Always set USD first.
        {
            amountJpy = amountUsd * 104.92;
            amountDem = amountUsd * 1.61345;
            amountGbp = amountUsd * 0.72158;
            amountFrf = amountUsd * 5.41129;
        }

        //Validate to only allow number input. Used for all the text boxes.
        private void textBox_KeyPress_ValidateNum(object sender, KeyPressEventArgs e) {//On keypress in the text box
            // Prevent the input of unallowed characters
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true; //Prevents further usage of the event - the invalid key
            }//Otherwise, continues and the value is handled properly
        }


        private void textBoxUsd_TextChanged(object sender, EventArgs e)
        {
            //Attempt to parse the text to a double. If successful, the value is assigned to amountUsd.
            if (!double.TryParse(textBoxUsd.Text, out amountUsd)) { }
            updateValues(ECurrencies.USD);
        }

        private void textBoxGbp_TextChanged(object sender, EventArgs e)
        {
            //Attempt to parse the text to a double. If successful, the value is assigned to amountUsd.
            if (!double.TryParse(textBoxGbp.Text, out amountGbp)) { }
            updateValues(ECurrencies.GBP);
        }

        private void textBoxJpy_TextChanged(object sender, EventArgs e)
        {
            //Attempt to parse the text to a double. If successful, the value is assigned to amountUsd.
            if (!double.TryParse(textBoxJpy.Text, out amountJpy)) { }
            updateValues(ECurrencies.JPY);
        }

        private void textBoxFrf_TextChanged(object sender, EventArgs e)
        {
            //Attempt to parse the text to a double. If successful, the value is assigned to amountUsd.
            if (!double.TryParse(textBoxFrf.Text, out amountFrf)) { }
            updateValues(ECurrencies.FRF);
        }

        private void textBoxDem_TextChanged(object sender, EventArgs e)
        {
            //Attempt to parse the text to a double. If successful, the value is assigned to amountUsd.
            if (!double.TryParse(textBoxDem.Text, out amountDem)) { }
            updateValues(ECurrencies.DEM);
        }
    }
}
