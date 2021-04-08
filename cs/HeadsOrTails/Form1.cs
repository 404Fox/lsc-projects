using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadsOrTails
{
    public partial class formHeadsOrTails : Form
    {
        public formHeadsOrTails() {
            InitializeComponent();
        }

        private void btnFlipCoin_Click(object sender, EventArgs e) { //Open bracket of this event-function thingy which is called upon button press
            Random random = new Random(); //Declares and instantiates a Random. Some kind of data object which provides a stream of random numbers I guess.
            int randomSide = random.Next(2); //Use the next function on the random Random to assign an integer to randomSide which is essentially boolean in nature.
            if(randomSide == 1) { //First case, if the randomSide int is equivalent to 1
                picCoins.Image = Properties.Resources.Tails1; //Set the image in piccoins to the tails1 in resources
            } else { //All-else. Thus includes possible int value of RandomSide being 2 or anything else jic.
                picCoins.Image = Properties.Resources.Heads1; //Set the image in piccoins to the heads1 in resources
            }//End of if statement for randomside
        }

        private void btnShowTails_Click(object sender, EventArgs e) { //Function definition for the behavior of the button btnShowTails
            picCoins.Image = Properties.Resources.Tails1; //Set the image in piccoins to the tails1 in resources
        }

        private void btnShowHeads_Click(object sender, EventArgs e) { //Function definition for the behavior of the button btnShowHeads
            picCoins.Image = Properties.Resources.Heads1; //Set the image in piccoins to the heads1 in resources
        }//End of definition for the function which defines behavior on click for btnShowHeads
    }//End of partial class which inherits from Form, is a Form itself.
}//End bracket that opened usage of namespace HeadsOrTails (this project)