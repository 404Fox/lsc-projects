
namespace FreezingBoiling
{
    partial class Form1
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
            this.enterBtn = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.progBarAlcohol = new System.Windows.Forms.ProgressBar();
            this.labelAlcohol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progBarMercury = new System.Windows.Forms.ProgressBar();
            this.progBarOxygen = new System.Windows.Forms.ProgressBar();
            this.progBarWater = new System.Windows.Forms.ProgressBar();
            this.stateLabelWater = new System.Windows.Forms.Label();
            this.stateLabelOxygen = new System.Windows.Forms.Label();
            this.stateLabelMercury = new System.Windows.Forms.Label();
            this.stateLabelAlcohol = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // enterBtn
            // 
            this.enterBtn.Font = new System.Drawing.Font("QuickType II", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBtn.Location = new System.Drawing.Point(431, 305);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(75, 23);
            this.enterBtn.TabIndex = 1;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(400, 279);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(142, 20);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.Text = "0";
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("QuickType II", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter a temperature in farenheit";
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("QuickType II", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(388, 334);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("QuickType II", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(469, 334);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // progBarAlcohol
            // 
            this.progBarAlcohol.Location = new System.Drawing.Point(131, 134);
            this.progBarAlcohol.Maximum = 345;
            this.progBarAlcohol.Name = "progBarAlcohol";
            this.progBarAlcohol.Size = new System.Drawing.Size(673, 12);
            this.progBarAlcohol.Step = 1;
            this.progBarAlcohol.TabIndex = 7;
            this.progBarAlcohol.Value = 173;
            // 
            // labelAlcohol
            // 
            this.labelAlcohol.AutoSize = true;
            this.labelAlcohol.Font = new System.Drawing.Font("QuickType II", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlcohol.Location = new System.Drawing.Point(16, 136);
            this.labelAlcohol.Name = "labelAlcohol";
            this.labelAlcohol.Size = new System.Drawing.Size(99, 13);
            this.labelAlcohol.TabIndex = 8;
            this.labelAlcohol.Text = "Ethynol Alcohol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("QuickType II", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mercury";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("QuickType II", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Oxygen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("QuickType II", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Water";
            // 
            // progBarMercury
            // 
            this.progBarMercury.Location = new System.Drawing.Point(131, 176);
            this.progBarMercury.Maximum = 714;
            this.progBarMercury.Name = "progBarMercury";
            this.progBarMercury.Size = new System.Drawing.Size(673, 12);
            this.progBarMercury.TabIndex = 0;
            this.progBarMercury.Value = 38;
            // 
            // progBarOxygen
            // 
            this.progBarOxygen.Location = new System.Drawing.Point(131, 93);
            this.progBarOxygen.MarqueeAnimationSpeed = 50;
            this.progBarOxygen.Maximum = 56;
            this.progBarOxygen.Name = "progBarOxygen";
            this.progBarOxygen.Size = new System.Drawing.Size(673, 12);
            this.progBarOxygen.TabIndex = 13;
            this.progBarOxygen.Value = 56;
            // 
            // progBarWater
            // 
            this.progBarWater.Location = new System.Drawing.Point(131, 218);
            this.progBarWater.Maximum = 180;
            this.progBarWater.Name = "progBarWater";
            this.progBarWater.Size = new System.Drawing.Size(673, 12);
            this.progBarWater.Step = 1;
            this.progBarWater.TabIndex = 14;
            // 
            // stateLabelWater
            // 
            this.stateLabelWater.AutoSize = true;
            this.stateLabelWater.Font = new System.Drawing.Font("QuickType II", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabelWater.Location = new System.Drawing.Point(823, 220);
            this.stateLabelWater.Name = "stateLabelWater";
            this.stateLabelWater.Size = new System.Drawing.Size(84, 13);
            this.stateLabelWater.TabIndex = 15;
            this.stateLabelWater.Text = "Frozen solid.";
            // 
            // stateLabelOxygen
            // 
            this.stateLabelOxygen.AutoSize = true;
            this.stateLabelOxygen.Font = new System.Drawing.Font("QuickType II", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabelOxygen.Location = new System.Drawing.Point(823, 95);
            this.stateLabelOxygen.Name = "stateLabelOxygen";
            this.stateLabelOxygen.Size = new System.Drawing.Size(91, 13);
            this.stateLabelOxygen.TabIndex = 16;
            this.stateLabelOxygen.Text = "Boils into gas.";
            // 
            // stateLabelMercury
            // 
            this.stateLabelMercury.AutoSize = true;
            this.stateLabelMercury.Font = new System.Drawing.Font("QuickType II", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabelMercury.Location = new System.Drawing.Point(823, 178);
            this.stateLabelMercury.Name = "stateLabelMercury";
            this.stateLabelMercury.Size = new System.Drawing.Size(168, 13);
            this.stateLabelMercury.TabIndex = 17;
            this.stateLabelMercury.Text = "No change. Remains liquid.";
            // 
            // stateLabelAlcohol
            // 
            this.stateLabelAlcohol.AutoSize = true;
            this.stateLabelAlcohol.Font = new System.Drawing.Font("QuickType II", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabelAlcohol.Location = new System.Drawing.Point(823, 136);
            this.stateLabelAlcohol.Name = "stateLabelAlcohol";
            this.stateLabelAlcohol.Size = new System.Drawing.Size(168, 13);
            this.stateLabelAlcohol.TabIndex = 18;
            this.stateLabelAlcohol.Text = "No change. Remains liquid.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FreezingBoiling.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(121, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(696, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 372);
            this.Controls.Add(this.stateLabelAlcohol);
            this.Controls.Add(this.stateLabelMercury);
            this.Controls.Add(this.stateLabelOxygen);
            this.Controls.Add(this.stateLabelWater);
            this.Controls.Add(this.progBarWater);
            this.Controls.Add(this.progBarOxygen);
            this.Controls.Add(this.progBarMercury);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAlcohol);
            this.Controls.Add(this.progBarAlcohol);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freezing and Boiling Points";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ProgressBar progBarAlcohol;
        private System.Windows.Forms.Label labelAlcohol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progBarMercury;
        private System.Windows.Forms.ProgressBar progBarOxygen;
        private System.Windows.Forms.ProgressBar progBarWater;
        private System.Windows.Forms.Label stateLabelWater;
        private System.Windows.Forms.Label stateLabelOxygen;
        private System.Windows.Forms.Label stateLabelMercury;
        private System.Windows.Forms.Label stateLabelAlcohol;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

