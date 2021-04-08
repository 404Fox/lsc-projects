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
    public partial class PlanetForm : Form
    {
        public PlanetForm()
        {
            InitializeComponent();
        }

        //Variables exposed using getters/setters. This is C# style for variable access from outside a class.
        public string PlanetName { set => planetName.Text = value; } //Does not provide public getters. They only need to be set.
        public string PlanetDesc { set => planetDesc.Text = value; }
        public Image PlanetImage { set => planetPicBox.Image = value; }
    }
}
