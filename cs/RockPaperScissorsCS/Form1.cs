using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsCS
{
    public partial class formRPS : Form
    {
        public formRPS()
        {
            InitializeComponent();
        }

        string waitingText = "Choose your hand...";
        string winText = "You win!";
        string loseText = "You lost...";


        private void determineResult(int card)
        {
            //Disable selection buttions
            btnPaper.Enabled = false;
            btnRock.Enabled = false;
            btnScissors.Enabled = false;
            Random r = new Random();//Create a Random. A random data stream.
            //An evil way of RPS, where victory is determined in a 50/50
            if (r.Next(2) == 0) {
                //winning cases
                switch (card){
                    case 1://player rock
                        picBoxAI.Image = Properties.Resources.scissors;
                        break;
                    case 2://player paper
                        picBoxAI.Image = Properties.Resources.rock;
                        break;
                    case 3://player scissors
                        picBoxAI.Image = Properties.Resources.paper;
                        break;
                    default:
                       
                        break;
                }
                labelResult.Text = winText;
            } else {
                //losing cases
                switch (card)
                {
                    case 1://player rock
                        picBoxAI.Image = Properties.Resources.paper;
                        break;
                    case 2://player paper
                        picBoxAI.Image = Properties.Resources.scissors;
                        break;
                    case 3://player scissors
                        picBoxAI.Image = Properties.Resources.rock;
                        break;
                    default:
                        
                        break;
                }
                labelResult.Text = loseText;
            }
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            determineResult(1);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            determineResult(2);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            determineResult(3);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Change everything back to the defaults.
            labelResult.Text = waitingText;
            btnPaper.Enabled = true;
            btnRock.Enabled = true;
            btnScissors.Enabled = true;
            picBoxAI.Image = Properties.Resources.qmark;
        }
    }
}
