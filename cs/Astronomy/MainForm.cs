using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astronomy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            myPlanet = new PlanetForm(); //The object will be destroyed and created by the button clicks, not persistent
        }

        PlanetForm myPlanet;

        //This is delegated to its own function in case it needs to be expanded or changed.
        //Makes sure that the PlanetForm is open/visible
        private void planetFormVisible() {
            if (myPlanet.IsDisposed) { //If the window was closed
                myPlanet = new PlanetForm(); //Make a new one
            }
            myPlanet.Show();
            myPlanet.Activate(); //bring it to the front
        }

        //The contents of the PlanetForm are defined by the button that activates it.
        //Since it isn't necessary to use this information elsewhere, it only needs to be in one place.

        String[] distfromsun = { "0.387 AU", "0.7223 AU", "1 AU", "1.5237 AU", "5.2028 AU", "9.5388 AU", "19.18 AU", "30.0611 AU", "39.44 AU" };
        String[] planetmass = { "3.31 x 10^23 kg", "4.87 x 10^24 kg", "5.967 x 10^24 kg", ".6424 x 10^24 kg", "1.899 x 10^27 kg", "5.69 x 10^26 kg", "8.69 x 10^25 kg", "1.03 x 10^26 kg", "1.2 x 10^22 kg" };
        String[] planettempo = { "-173 C to 430 C", "472 C", "-50 C to 50 C", "-140 C to 20 C", "-110 C", "-180 C", "-220 C", "-216 C", "-230 C" };
        String[] planettype = { "Terrestrial", "Terrestrial", "Terrestrial", "Terrestrial", "Jovian", "Jovian", "Jovian", "Jovian", "Low density" };

        //just to be easy, the copy/pasted the provided arrays to make a string for the text box
        private string makeDesc(int index) {
            string output = "Distance from the sun: "+distfromsun[index]+"\nMass: "+planetmass[index]+"\nTemperature: "+planettempo[index]+"\nType: "+planettype[index];
            return output;
        }

        private void menuSun_Click(object sender, EventArgs e) {
            planetFormVisible();
            myPlanet.PlanetName = "The Sun";
            myPlanet.PlanetDesc = "Mass:\t\twww";
            myPlanet.PlanetImage = Properties.Resources.earth;
        }

        private void menuMercury_Click(object sender, EventArgs e) {
            planetFormVisible();
            myPlanet.PlanetName = "Mercury";
            myPlanet.PlanetDesc = makeDesc(0);
            myPlanet.PlanetImage = Properties.Resources.mercury;
        }

        private void menuVenus_Click(object sender, EventArgs e) {
            planetFormVisible();
            myPlanet.PlanetName = "Venus";
            myPlanet.PlanetDesc = makeDesc(1);
            myPlanet.PlanetImage = Properties.Resources.venus;
        }

        private void menuEarth_Click(object sender, EventArgs e) {
            planetFormVisible();
            myPlanet.PlanetName = "Earth";
            myPlanet.PlanetDesc = makeDesc(2);
            myPlanet.PlanetImage = Properties.Resources.earth;
        }

        private void menuJupiter_Click(object sender, EventArgs e) {
            planetFormVisible();
            myPlanet.PlanetName = "Jupiter";
            myPlanet.PlanetDesc = makeDesc(3);
            myPlanet.PlanetImage = Properties.Resources.jupiter;
        }

        private void menuMars_Click(object sender, EventArgs e) {
            planetFormVisible();
            myPlanet.PlanetName = "Mars";
            myPlanet.PlanetDesc = makeDesc(4);
            myPlanet.PlanetImage = Properties.Resources.mars;
        }

        private void menuSaturn_Click(object sender, EventArgs e) {
            planetFormVisible();
            myPlanet.PlanetName = "Saturn";
            myPlanet.PlanetDesc = makeDesc(5);
            myPlanet.PlanetImage = Properties.Resources.satrun;
        }

        private void menuUranus_Click(object sender, EventArgs e) {
            planetFormVisible();
            myPlanet.PlanetName = "Uranus";
            myPlanet.PlanetDesc = makeDesc(6);
            myPlanet.PlanetImage = Properties.Resources.uranus;
        }

        private void menuNeptune_Click(object sender, EventArgs e) {
            planetFormVisible();
            myPlanet.PlanetName = "Neptune";
            myPlanet.PlanetDesc = makeDesc(7);
            myPlanet.PlanetImage = Properties.Resources.neptune;
        }

        private void menuPluto_Click(object sender, EventArgs e) {
            planetFormVisible();
            myPlanet.PlanetName = "Pluto";
            myPlanet.PlanetDesc = makeDesc(8);
            myPlanet.PlanetImage = Properties.Resources.pluto;
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
