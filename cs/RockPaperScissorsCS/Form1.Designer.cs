
namespace RockPaperScissorsCS
{
    partial class formRPS
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
            this.picBoxRock = new System.Windows.Forms.PictureBox();
            this.picBoxPaper = new System.Windows.Forms.PictureBox();
            this.picBoxScissors = new System.Windows.Forms.PictureBox();
            this.picBoxAI = new System.Windows.Forms.PictureBox();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAI)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxRock
            // 
            this.picBoxRock.Image = global::RockPaperScissorsCS.Properties.Resources.rock;
            this.picBoxRock.Location = new System.Drawing.Point(38, 37);
            this.picBoxRock.Name = "picBoxRock";
            this.picBoxRock.Size = new System.Drawing.Size(133, 122);
            this.picBoxRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRock.TabIndex = 0;
            this.picBoxRock.TabStop = false;
            // 
            // picBoxPaper
            // 
            this.picBoxPaper.Image = global::RockPaperScissorsCS.Properties.Resources.paper;
            this.picBoxPaper.Location = new System.Drawing.Point(208, 37);
            this.picBoxPaper.Name = "picBoxPaper";
            this.picBoxPaper.Size = new System.Drawing.Size(133, 122);
            this.picBoxPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPaper.TabIndex = 1;
            this.picBoxPaper.TabStop = false;
            // 
            // picBoxScissors
            // 
            this.picBoxScissors.Image = global::RockPaperScissorsCS.Properties.Resources.scissors;
            this.picBoxScissors.Location = new System.Drawing.Point(376, 37);
            this.picBoxScissors.Name = "picBoxScissors";
            this.picBoxScissors.Size = new System.Drawing.Size(133, 122);
            this.picBoxScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxScissors.TabIndex = 2;
            this.picBoxScissors.TabStop = false;
            // 
            // picBoxAI
            // 
            this.picBoxAI.Image = global::RockPaperScissorsCS.Properties.Resources.qmark;
            this.picBoxAI.Location = new System.Drawing.Point(589, 148);
            this.picBoxAI.Name = "picBoxAI";
            this.picBoxAI.Size = new System.Drawing.Size(133, 122);
            this.picBoxAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAI.TabIndex = 3;
            this.picBoxAI.TabStop = false;
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.Location = new System.Drawing.Point(38, 182);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(133, 35);
            this.btnRock.TabIndex = 4;
            this.btnRock.Text = "Play Rock!";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.Location = new System.Drawing.Point(208, 182);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(133, 35);
            this.btnPaper.TabIndex = 5;
            this.btnPaper.Text = "Play Paper!";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.Location = new System.Drawing.Point(376, 182);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(133, 35);
            this.btnScissors.TabIndex = 6;
            this.btnScissors.Text = "Play Scissors!";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(161, 261);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(254, 42);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "Choose your hand...";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(589, 37);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 74);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // formRPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 345);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.picBoxAI);
            this.Controls.Add(this.picBoxScissors);
            this.Controls.Add(this.picBoxPaper);
            this.Controls.Add(this.picBoxRock);
            this.Name = "formRPS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxRock;
        private System.Windows.Forms.PictureBox picBoxPaper;
        private System.Windows.Forms.PictureBox picBoxScissors;
        private System.Windows.Forms.PictureBox picBoxAI;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnReset;
    }
}

