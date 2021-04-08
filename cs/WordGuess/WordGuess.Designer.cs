
namespace WordGuess
{
    partial class WordGuessForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.attemptList = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayWordLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.letterTextBox = new System.Windows.Forms.TextBox();
            this.sendWordBtn = new System.Windows.Forms.Button();
            this.sendLetterBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.attemptList);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Word Game";
            // 
            // attemptList
            // 
            this.attemptList.AutoSize = true;
            this.attemptList.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attemptList.Location = new System.Drawing.Point(191, 89);
            this.attemptList.Name = "attemptList";
            this.attemptList.Size = new System.Drawing.Size(56, 15);
            this.attemptList.TabIndex = 3;
            this.attemptList.Text = "ddddddd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Submitted letter history: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 11);
            this.label1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.displayWordLabel);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 55);
            this.panel1.TabIndex = 0;
            // 
            // displayWordLabel
            // 
            this.displayWordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayWordLabel.Font = new System.Drawing.Font("QuickType Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayWordLabel.Location = new System.Drawing.Point(5, 12);
            this.displayWordLabel.Name = "displayWordLabel";
            this.displayWordLabel.Size = new System.Drawing.Size(523, 35);
            this.displayWordLabel.TabIndex = 0;
            this.displayWordLabel.Text = "label1";
            this.displayWordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.wordTextBox);
            this.groupBox2.Controls.Add(this.letterTextBox);
            this.groupBox2.Controls.Add(this.sendWordBtn);
            this.groupBox2.Controls.Add(this.sendLetterBtn);
            this.groupBox2.Controls.Add(this.exitBtn);
            this.groupBox2.Controls.Add(this.newGameBtn);
            this.groupBox2.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(257, 33);
            this.wordTextBox.MaxLength = 20;
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(174, 18);
            this.wordTextBox.TabIndex = 5;
            this.wordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wordTextBox_KeyPress);
            // 
            // letterTextBox
            // 
            this.letterTextBox.Location = new System.Drawing.Point(161, 33);
            this.letterTextBox.MaxLength = 1;
            this.letterTextBox.Name = "letterTextBox";
            this.letterTextBox.Size = new System.Drawing.Size(45, 18);
            this.letterTextBox.TabIndex = 4;
            this.letterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wordTextBox_KeyPress);
            // 
            // sendWordBtn
            // 
            this.sendWordBtn.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendWordBtn.Location = new System.Drawing.Point(278, 59);
            this.sendWordBtn.Name = "sendWordBtn";
            this.sendWordBtn.Size = new System.Drawing.Size(129, 34);
            this.sendWordBtn.TabIndex = 3;
            this.sendWordBtn.Text = "Submit Word";
            this.sendWordBtn.UseVisualStyleBackColor = true;
            this.sendWordBtn.Click += new System.EventHandler(this.sendWordBtn_Click);
            // 
            // sendLetterBtn
            // 
            this.sendLetterBtn.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendLetterBtn.Location = new System.Drawing.Point(114, 59);
            this.sendLetterBtn.Name = "sendLetterBtn";
            this.sendLetterBtn.Size = new System.Drawing.Size(133, 34);
            this.sendLetterBtn.TabIndex = 2;
            this.sendLetterBtn.Text = "Submit Letter";
            this.sendLetterBtn.UseVisualStyleBackColor = true;
            this.sendLetterBtn.Click += new System.EventHandler(this.sendLetterBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exitBtn.Location = new System.Drawing.Point(462, 115);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // newGameBtn
            // 
            this.newGameBtn.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.newGameBtn.Location = new System.Drawing.Point(6, 113);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(75, 23);
            this.newGameBtn.TabIndex = 0;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // WordGuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WordGuessForm";
            this.Text = "Word Guessing Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label displayWordLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.TextBox letterTextBox;
        private System.Windows.Forms.Button sendWordBtn;
        private System.Windows.Forms.Button sendLetterBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label attemptList;
    }
}

