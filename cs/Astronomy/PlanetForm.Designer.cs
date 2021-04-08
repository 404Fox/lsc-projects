
namespace Astronomy
{
    partial class PlanetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanetForm));
            this.planetName = new System.Windows.Forms.Label();
            this.planetDesc = new System.Windows.Forms.Label();
            this.planetPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.planetPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // planetName
            // 
            this.planetName.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetName.Location = new System.Drawing.Point(15, 22);
            this.planetName.Name = "planetName";
            this.planetName.Size = new System.Drawing.Size(298, 39);
            this.planetName.TabIndex = 0;
            this.planetName.Text = "Name";
            this.planetName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // planetDesc
            // 
            this.planetDesc.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetDesc.Location = new System.Drawing.Point(12, 65);
            this.planetDesc.Name = "planetDesc";
            this.planetDesc.Size = new System.Drawing.Size(301, 152);
            this.planetDesc.TabIndex = 1;
            this.planetDesc.Text = "Description.";
            this.planetDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // planetPicBox
            // 
            this.planetPicBox.Image = global::Astronomy.Properties.Resources.earth;
            this.planetPicBox.Location = new System.Drawing.Point(341, 48);
            this.planetPicBox.Name = "planetPicBox";
            this.planetPicBox.Size = new System.Drawing.Size(211, 169);
            this.planetPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planetPicBox.TabIndex = 2;
            this.planetPicBox.TabStop = false;
            // 
            // PlanetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 242);
            this.Controls.Add(this.planetPicBox);
            this.Controls.Add(this.planetDesc);
            this.Controls.Add(this.planetName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlanetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanetForm";
            ((System.ComponentModel.ISupportInitialize)(this.planetPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label planetName;
        private System.Windows.Forms.Label planetDesc;
        private System.Windows.Forms.PictureBox planetPicBox;
    }
}