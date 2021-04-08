namespace CurrencyConverter
{
    partial class CurrencyConverter
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
            this.textBoxUsd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGbp = new System.Windows.Forms.TextBox();
            this.textBoxJpy = new System.Windows.Forms.TextBox();
            this.textBoxFrf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxFlagUsa = new System.Windows.Forms.PictureBox();
            this.textBoxDem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxGbp = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagUsa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGbp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsd
            // 
            this.textBoxUsd.AcceptsTab = true;
            this.textBoxUsd.Location = new System.Drawing.Point(267, 75);
            this.textBoxUsd.MaxLength = 12;
            this.textBoxUsd.Name = "textBoxUsd";
            this.textBoxUsd.Size = new System.Drawing.Size(138, 20);
            this.textBoxUsd.TabIndex = 0;
            this.textBoxUsd.Text = "0.00";
            this.textBoxUsd.TextChanged += new System.EventHandler(this.textBoxUsd_TextChanged);
            this.textBoxUsd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_ValidateNum);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dollars (USD)";
            // 
            // textBoxGbp
            // 
            this.textBoxGbp.AcceptsTab = true;
            this.textBoxGbp.Location = new System.Drawing.Point(267, 133);
            this.textBoxGbp.MaxLength = 12;
            this.textBoxGbp.Name = "textBoxGbp";
            this.textBoxGbp.Size = new System.Drawing.Size(138, 20);
            this.textBoxGbp.TabIndex = 2;
            this.textBoxGbp.Text = "0.00";
            this.textBoxGbp.TextChanged += new System.EventHandler(this.textBoxGbp_TextChanged);
            this.textBoxGbp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_ValidateNum);
            // 
            // textBoxJpy
            // 
            this.textBoxJpy.AcceptsTab = true;
            this.textBoxJpy.Location = new System.Drawing.Point(267, 194);
            this.textBoxJpy.MaxLength = 12;
            this.textBoxJpy.Name = "textBoxJpy";
            this.textBoxJpy.Size = new System.Drawing.Size(138, 20);
            this.textBoxJpy.TabIndex = 3;
            this.textBoxJpy.Text = "0.00";
            this.textBoxJpy.TextChanged += new System.EventHandler(this.textBoxJpy_TextChanged);
            this.textBoxJpy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_ValidateNum);
            // 
            // textBoxFrf
            // 
            this.textBoxFrf.AcceptsTab = true;
            this.textBoxFrf.Location = new System.Drawing.Point(267, 258);
            this.textBoxFrf.MaxLength = 12;
            this.textBoxFrf.Name = "textBoxFrf";
            this.textBoxFrf.Size = new System.Drawing.Size(138, 20);
            this.textBoxFrf.TabIndex = 4;
            this.textBoxFrf.Text = "0.00";
            this.textBoxFrf.TextChanged += new System.EventHandler(this.textBoxFrf_TextChanged);
            this.textBoxFrf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_ValidateNum);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pounds (GBP)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yen (JPY)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Francs (FRF)";
            // 
            // pictureBoxFlagUsa
            // 
            this.pictureBoxFlagUsa.Image = global::CurrencyConverter.Properties.Resources.usa;
            this.pictureBoxFlagUsa.Location = new System.Drawing.Point(29, 64);
            this.pictureBoxFlagUsa.Name = "pictureBoxFlagUsa";
            this.pictureBoxFlagUsa.Size = new System.Drawing.Size(65, 43);
            this.pictureBoxFlagUsa.TabIndex = 8;
            this.pictureBoxFlagUsa.TabStop = false;
            // 
            // textBoxDem
            // 
            this.textBoxDem.Location = new System.Drawing.Point(267, 315);
            this.textBoxDem.MaxLength = 12;
            this.textBoxDem.Name = "textBoxDem";
            this.textBoxDem.Size = new System.Drawing.Size(138, 20);
            this.textBoxDem.TabIndex = 9;
            this.textBoxDem.Text = "0.00";
            this.textBoxDem.TextChanged += new System.EventHandler(this.textBoxDem_TextChanged);
            this.textBoxDem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_ValidateNum);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Marks (DEM)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(438, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter a value into any text box, and it will automatically be converted to the ot" +
    "her currencies";
            // 
            // pictureBoxGbp
            // 
            this.pictureBoxGbp.Image = global::CurrencyConverter.Properties.Resources.uk;
            this.pictureBoxGbp.Location = new System.Drawing.Point(29, 123);
            this.pictureBoxGbp.Name = "pictureBoxGbp";
            this.pictureBoxGbp.Size = new System.Drawing.Size(65, 40);
            this.pictureBoxGbp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGbp.TabIndex = 12;
            this.pictureBoxGbp.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CurrencyConverter.Properties.Resources.japan;
            this.pictureBox1.Location = new System.Drawing.Point(29, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CurrencyConverter.Properties.Resources.france;
            this.pictureBox2.Location = new System.Drawing.Point(29, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CurrencyConverter.Properties.Resources.germany;
            this.pictureBox3.Location = new System.Drawing.Point(29, 306);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 380);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxGbp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDem);
            this.Controls.Add(this.pictureBoxFlagUsa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFrf);
            this.Controls.Add(this.textBoxJpy);
            this.Controls.Add(this.textBoxGbp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsd);
            this.Name = "CurrencyConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagUsa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGbp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGbp;
        private System.Windows.Forms.TextBox textBoxJpy;
        private System.Windows.Forms.TextBox textBoxFrf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxFlagUsa;
        private System.Windows.Forms.TextBox textBoxDem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxGbp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

