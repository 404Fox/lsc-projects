
namespace Astronomy
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.myMainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuPlanetsListBtn = new System.Windows.Forms.MenuItem();
            this.menuSun = new System.Windows.Forms.MenuItem();
            this.menuMercury = new System.Windows.Forms.MenuItem();
            this.menuVenus = new System.Windows.Forms.MenuItem();
            this.menuEarth = new System.Windows.Forms.MenuItem();
            this.menuMars = new System.Windows.Forms.MenuItem();
            this.menuJupiter = new System.Windows.Forms.MenuItem();
            this.menuSaturn = new System.Windows.Forms.MenuItem();
            this.menuUranus = new System.Windows.Forms.MenuItem();
            this.menuNeptune = new System.Windows.Forms.MenuItem();
            this.menuPluto = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // myMainMenu
            // 
            this.myMainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuPlanetsListBtn,
            this.menuExit});
            // 
            // menuPlanetsListBtn
            // 
            this.menuPlanetsListBtn.Index = 0;
            this.menuPlanetsListBtn.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuSun,
            this.menuMercury,
            this.menuVenus,
            this.menuEarth,
            this.menuMars,
            this.menuJupiter,
            this.menuSaturn,
            this.menuUranus,
            this.menuNeptune,
            this.menuPluto});
            this.menuPlanetsListBtn.Text = "The Planets";
            // 
            // menuSun
            // 
            this.menuSun.Index = 0;
            this.menuSun.Text = "The Sun";
            this.menuSun.Visible = false;
            this.menuSun.Click += new System.EventHandler(this.menuSun_Click);
            // 
            // menuMercury
            // 
            this.menuMercury.Index = 1;
            this.menuMercury.Text = "Mercury";
            this.menuMercury.Click += new System.EventHandler(this.menuMercury_Click);
            // 
            // menuVenus
            // 
            this.menuVenus.Index = 2;
            this.menuVenus.Text = "Venus";
            this.menuVenus.Click += new System.EventHandler(this.menuVenus_Click);
            // 
            // menuEarth
            // 
            this.menuEarth.Index = 3;
            this.menuEarth.Text = "Earth";
            this.menuEarth.Click += new System.EventHandler(this.menuEarth_Click);
            // 
            // menuMars
            // 
            this.menuMars.Index = 4;
            this.menuMars.Text = "Mars";
            this.menuMars.Click += new System.EventHandler(this.menuMars_Click);
            // 
            // menuJupiter
            // 
            this.menuJupiter.Index = 5;
            this.menuJupiter.Text = "Jupiter";
            this.menuJupiter.Click += new System.EventHandler(this.menuJupiter_Click);
            // 
            // menuSaturn
            // 
            this.menuSaturn.Index = 6;
            this.menuSaturn.Text = "Saturn";
            this.menuSaturn.Click += new System.EventHandler(this.menuSaturn_Click);
            // 
            // menuUranus
            // 
            this.menuUranus.Index = 7;
            this.menuUranus.Text = "Uranus";
            this.menuUranus.Click += new System.EventHandler(this.menuUranus_Click);
            // 
            // menuNeptune
            // 
            this.menuNeptune.Index = 8;
            this.menuNeptune.Text = "Neptune";
            this.menuNeptune.Click += new System.EventHandler(this.menuNeptune_Click);
            // 
            // menuPluto
            // 
            this.menuPluto.Index = 9;
            this.menuPluto.Text = "Pluto";
            this.menuPluto.Click += new System.EventHandler(this.menuPluto_Click);
            // 
            // menuExit
            // 
            this.menuExit.Index = 1;
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Astronomy.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(719, 424);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.myMainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Solar System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu myMainMenu;
        private System.Windows.Forms.MenuItem menuPlanetsListBtn;
        private System.Windows.Forms.MenuItem menuSun;
        private System.Windows.Forms.MenuItem menuMercury;
        private System.Windows.Forms.MenuItem menuVenus;
        private System.Windows.Forms.MenuItem menuEarth;
        private System.Windows.Forms.MenuItem menuMars;
        private System.Windows.Forms.MenuItem menuJupiter;
        private System.Windows.Forms.MenuItem menuSaturn;
        private System.Windows.Forms.MenuItem menuUranus;
        private System.Windows.Forms.MenuItem menuNeptune;
        private System.Windows.Forms.MenuItem menuPluto;
        private System.Windows.Forms.MenuItem menuExit;
    }
}

