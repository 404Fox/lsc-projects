
namespace GuessingGame
{
    partial class FormGuessGame
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.guessBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.lblGuessCtHeader = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGuessBetween = new System.Windows.Forms.Label();
            this.lblAnd = new System.Windows.Forms.Label();
            this.minNum = new System.Windows.Forms.NumericUpDown();
            this.maxNum = new System.Windows.Forms.NumericUpDown();
            this.resetBtn = new System.Windows.Forms.Button();
            this.lblGuessCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(175, 219);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // guessBtn
            // 
            this.guessBtn.Enabled = false;
            this.guessBtn.Location = new System.Drawing.Point(175, 156);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(175, 47);
            this.guessBtn.TabIndex = 1;
            this.guessBtn.Text = "Guess";
            this.guessBtn.UseVisualStyleBackColor = true;
            this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(325, 79);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // lblGuessCtHeader
            // 
            this.lblGuessCtHeader.AutoSize = true;
            this.lblGuessCtHeader.Location = new System.Drawing.Point(346, 119);
            this.lblGuessCtHeader.Name = "lblGuessCtHeader";
            this.lblGuessCtHeader.Size = new System.Drawing.Size(71, 13);
            this.lblGuessCtHeader.TabIndex = 4;
            this.lblGuessCtHeader.Text = "Guess Count:";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Enabled = false;
            this.guessTextBox.Location = new System.Drawing.Point(201, 116);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(117, 20);
            this.guessTextBox.TabIndex = 5;
            this.guessTextBox.Text = "0";
            this.guessTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guessTextBox_KeyPress);
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(82, 119);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(113, 13);
            this.lblGuess.TabIndex = 6;
            this.lblGuess.Text = "Enter your guess here:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(130, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 36);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "The Guessing Game";
            // 
            // lblGuessBetween
            // 
            this.lblGuessBetween.AutoSize = true;
            this.lblGuessBetween.Location = new System.Drawing.Point(70, 84);
            this.lblGuessBetween.Name = "lblGuessBetween";
            this.lblGuessBetween.Size = new System.Drawing.Size(131, 13);
            this.lblGuessBetween.TabIndex = 8;
            this.lblGuessBetween.Text = "Guess a number between ";
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.Location = new System.Drawing.Point(246, 84);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(25, 13);
            this.lblAnd.TabIndex = 11;
            this.lblAnd.Text = "and";
            // 
            // minNum
            // 
            this.minNum.Location = new System.Drawing.Point(201, 82);
            this.minNum.Name = "minNum";
            this.minNum.Size = new System.Drawing.Size(39, 20);
            this.minNum.TabIndex = 12;
            // 
            // maxNum
            // 
            this.maxNum.Location = new System.Drawing.Point(277, 82);
            this.maxNum.Name = "maxNum";
            this.maxNum.Size = new System.Drawing.Size(39, 20);
            this.maxNum.TabIndex = 13;
            this.maxNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(275, 219);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 14;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // lblGuessCounter
            // 
            this.lblGuessCounter.AutoSize = true;
            this.lblGuessCounter.Location = new System.Drawing.Point(424, 119);
            this.lblGuessCounter.Name = "lblGuessCounter";
            this.lblGuessCounter.Size = new System.Drawing.Size(13, 13);
            this.lblGuessCounter.TabIndex = 15;
            this.lblGuessCounter.Text = "0";
            // 
            // FormGuessGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 265);
            this.Controls.Add(this.lblGuessCounter);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.maxNum);
            this.Controls.Add(this.minNum);
            this.Controls.Add(this.lblAnd);
            this.Controls.Add(this.lblGuessBetween);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.lblGuessCtHeader);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.guessBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "FormGuessGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label lblGuessCtHeader;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGuessBetween;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.NumericUpDown minNum;
        private System.Windows.Forms.NumericUpDown maxNum;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label lblGuessCounter;
    }
}

