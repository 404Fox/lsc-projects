
namespace Celsius_Fahrenheit_Converter
{
    partial class TempConvForm
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
            this.fhtLabel = new System.Windows.Forms.Label();
            this.clsLabel = new System.Windows.Forms.Label();
            this.titlePictureBox = new System.Windows.Forms.PictureBox();
            this.fhtTextBox = new System.Windows.Forms.TextBox();
            this.clsTextBox = new System.Windows.Forms.TextBox();
            this.fhtBtn = new System.Windows.Forms.Button();
            this.clsBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fhtLabel
            // 
            this.fhtLabel.AutoSize = true;
            this.fhtLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fhtLabel.Location = new System.Drawing.Point(34, 157);
            this.fhtLabel.Name = "fhtLabel";
            this.fhtLabel.Size = new System.Drawing.Size(71, 17);
            this.fhtLabel.TabIndex = 0;
            this.fhtLabel.Text = "Fahrenheit:";
            // 
            // clsLabel
            // 
            this.clsLabel.AutoSize = true;
            this.clsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsLabel.Location = new System.Drawing.Point(54, 198);
            this.clsLabel.Name = "clsLabel";
            this.clsLabel.Size = new System.Drawing.Size(51, 17);
            this.clsLabel.TabIndex = 1;
            this.clsLabel.Text = "Celsius:";
            // 
            // titlePictureBox
            // 
            this.titlePictureBox.Image = global::Celsius_Fahrenheit_Converter.Properties.Resources.celsiustofahrenheit;
            this.titlePictureBox.Location = new System.Drawing.Point(101, 21);
            this.titlePictureBox.Name = "titlePictureBox";
            this.titlePictureBox.Size = new System.Drawing.Size(241, 108);
            this.titlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titlePictureBox.TabIndex = 2;
            this.titlePictureBox.TabStop = false;
            // 
            // fhtTextBox
            // 
            this.fhtTextBox.AcceptsTab = true;
            this.fhtTextBox.Location = new System.Drawing.Point(111, 157);
            this.fhtTextBox.Name = "fhtTextBox";
            this.fhtTextBox.Size = new System.Drawing.Size(120, 20);
            this.fhtTextBox.TabIndex = 3;
            this.fhtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fhtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress_numberOnly);
            // 
            // clsTextBox
            // 
            this.clsTextBox.AcceptsTab = true;
            this.clsTextBox.Location = new System.Drawing.Point(111, 198);
            this.clsTextBox.Name = "clsTextBox";
            this.clsTextBox.Size = new System.Drawing.Size(120, 20);
            this.clsTextBox.TabIndex = 5;
            this.clsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress_numberOnly);
            // 
            // fhtBtn
            // 
            this.fhtBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fhtBtn.Location = new System.Drawing.Point(237, 151);
            this.fhtBtn.Name = "fhtBtn";
            this.fhtBtn.Size = new System.Drawing.Size(149, 29);
            this.fhtBtn.TabIndex = 4;
            this.fhtBtn.Text = "Convert to Celsius";
            this.fhtBtn.UseVisualStyleBackColor = true;
            this.fhtBtn.Click += new System.EventHandler(this.fhtBtn_Click);
            // 
            // clsBtn
            // 
            this.clsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsBtn.Location = new System.Drawing.Point(237, 192);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(149, 29);
            this.clsBtn.TabIndex = 6;
            this.clsBtn.Text = "Convert to Fahrenheit";
            this.clsBtn.UseVisualStyleBackColor = true;
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(180, 241);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // TempConvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 276);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.clsBtn);
            this.Controls.Add(this.fhtBtn);
            this.Controls.Add(this.clsTextBox);
            this.Controls.Add(this.fhtTextBox);
            this.Controls.Add(this.titlePictureBox);
            this.Controls.Add(this.clsLabel);
            this.Controls.Add(this.fhtLabel);
            this.Name = "TempConvForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fhtLabel;
        private System.Windows.Forms.Label clsLabel;
        private System.Windows.Forms.PictureBox titlePictureBox;
        private System.Windows.Forms.TextBox fhtTextBox;
        private System.Windows.Forms.TextBox clsTextBox;
        private System.Windows.Forms.Button fhtBtn;
        private System.Windows.Forms.Button clsBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

