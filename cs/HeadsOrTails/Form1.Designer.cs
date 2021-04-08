namespace HeadsOrTails
{
    partial class formHeadsOrTails
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
            this.picCoins = new System.Windows.Forms.PictureBox();
            this.btnShowHeads = new System.Windows.Forms.Button();
            this.btnShowTails = new System.Windows.Forms.Button();
            this.btnFlipCoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCoins)).BeginInit();
            this.SuspendLayout();
            // 
            // picCoins
            // 
            this.picCoins.BackColor = System.Drawing.SystemColors.Window;
            this.picCoins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCoins.Image = global::HeadsOrTails.Properties.Resources.Heads1;
            this.picCoins.InitialImage = global::HeadsOrTails.Properties.Resources.Heads1;
            this.picCoins.Location = new System.Drawing.Point(141, 67);
            this.picCoins.Name = "picCoins";
            this.picCoins.Size = new System.Drawing.Size(159, 155);
            this.picCoins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoins.TabIndex = 0;
            this.picCoins.TabStop = false;
            // 
            // btnShowHeads
            // 
            this.btnShowHeads.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnShowHeads.Location = new System.Drawing.Point(28, 266);
            this.btnShowHeads.Name = "btnShowHeads";
            this.btnShowHeads.Size = new System.Drawing.Size(95, 23);
            this.btnShowHeads.TabIndex = 1;
            this.btnShowHeads.Text = "Show Heads";
            this.btnShowHeads.UseVisualStyleBackColor = true;
            this.btnShowHeads.Click += new System.EventHandler(this.btnShowHeads_Click);
            // 
            // btnShowTails
            // 
            this.btnShowTails.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnShowTails.Location = new System.Drawing.Point(321, 266);
            this.btnShowTails.Name = "btnShowTails";
            this.btnShowTails.Size = new System.Drawing.Size(91, 23);
            this.btnShowTails.TabIndex = 2;
            this.btnShowTails.Text = "Show Tails";
            this.btnShowTails.UseVisualStyleBackColor = true;
            this.btnShowTails.Click += new System.EventHandler(this.btnShowTails_Click);
            // 
            // btnFlipCoin
            // 
            this.btnFlipCoin.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlipCoin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFlipCoin.Location = new System.Drawing.Point(161, 266);
            this.btnFlipCoin.Name = "btnFlipCoin";
            this.btnFlipCoin.Size = new System.Drawing.Size(122, 67);
            this.btnFlipCoin.TabIndex = 3;
            this.btnFlipCoin.Text = "Flip Coin";
            this.btnFlipCoin.UseVisualStyleBackColor = true;
            this.btnFlipCoin.Click += new System.EventHandler(this.btnFlipCoin_Click);
            // 
            // formHeadsOrTails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 386);
            this.Controls.Add(this.btnFlipCoin);
            this.Controls.Add(this.btnShowTails);
            this.Controls.Add(this.btnShowHeads);
            this.Controls.Add(this.picCoins);
            this.Name = "formHeadsOrTails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeadsOrTails";
            ((System.ComponentModel.ISupportInitialize)(this.picCoins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCoins;
        private System.Windows.Forms.Button btnShowHeads;
        private System.Windows.Forms.Button btnShowTails;
        private System.Windows.Forms.Button btnFlipCoin;
    }
}

