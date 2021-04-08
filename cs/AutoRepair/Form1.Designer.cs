
namespace AutoRepair
{
    partial class AutoRepairForm
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
            this.cbOil = new System.Windows.Forms.CheckBox();
            this.cbLube = new System.Windows.Forms.CheckBox();
            this.cbInspection = new System.Windows.Forms.CheckBox();
            this.cbMuffler = new System.Windows.Forms.CheckBox();
            this.cbRotation = new System.Windows.Forms.CheckBox();
            this.cbRadiator = new System.Windows.Forms.CheckBox();
            this.getTotalBtn = new System.Windows.Forms.Button();
            this.resetAllBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.cbTransmission = new System.Windows.Forms.CheckBox();
            this.gbOilLube = new System.Windows.Forms.GroupBox();
            this.togBtnOilLube = new System.Windows.Forms.Button();
            this.gbFluidFlush = new System.Windows.Forms.GroupBox();
            this.togBtnFluid = new System.Windows.Forms.Button();
            this.gbMisc = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.togBtnMisc = new System.Windows.Forms.Button();
            this.gbPartsLabor = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resetPartsLaborBtn = new System.Windows.Forms.Button();
            this.textBoxLabor = new System.Windows.Forms.TextBox();
            this.textBoxParts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTotalSum = new System.Windows.Forms.TextBox();
            this.textBoxTaxSum = new System.Windows.Forms.TextBox();
            this.textBoxPartsSum = new System.Windows.Forms.TextBox();
            this.textBoxLaborSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbOilLube.SuspendLayout();
            this.gbFluidFlush.SuspendLayout();
            this.gbMisc.SuspendLayout();
            this.gbPartsLabor.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbOil
            // 
            this.cbOil.AutoSize = true;
            this.cbOil.Location = new System.Drawing.Point(39, 19);
            this.cbOil.Name = "cbOil";
            this.cbOil.Size = new System.Drawing.Size(87, 17);
            this.cbOil.TabIndex = 0;
            this.cbOil.Text = "Oil Change";
            this.cbOil.UseVisualStyleBackColor = true;
            // 
            // cbLube
            // 
            this.cbLube.AutoSize = true;
            this.cbLube.Location = new System.Drawing.Point(39, 42);
            this.cbLube.Name = "cbLube";
            this.cbLube.Size = new System.Drawing.Size(77, 17);
            this.cbLube.TabIndex = 1;
            this.cbLube.Text = "Lube Job";
            this.cbLube.UseVisualStyleBackColor = true;
            // 
            // cbInspection
            // 
            this.cbInspection.AutoSize = true;
            this.cbInspection.Location = new System.Drawing.Point(39, 19);
            this.cbInspection.Name = "cbInspection";
            this.cbInspection.Size = new System.Drawing.Size(84, 17);
            this.cbInspection.TabIndex = 2;
            this.cbInspection.Text = "Inspection";
            this.cbInspection.UseVisualStyleBackColor = true;
            // 
            // cbMuffler
            // 
            this.cbMuffler.AutoSize = true;
            this.cbMuffler.Location = new System.Drawing.Point(39, 42);
            this.cbMuffler.Name = "cbMuffler";
            this.cbMuffler.Size = new System.Drawing.Size(114, 17);
            this.cbMuffler.TabIndex = 3;
            this.cbMuffler.Text = "Replace Muffler";
            this.cbMuffler.UseVisualStyleBackColor = true;
            // 
            // cbRotation
            // 
            this.cbRotation.AutoSize = true;
            this.cbRotation.Location = new System.Drawing.Point(39, 65);
            this.cbRotation.Name = "cbRotation";
            this.cbRotation.Size = new System.Drawing.Size(101, 17);
            this.cbRotation.TabIndex = 4;
            this.cbRotation.Text = "Tire Rotation";
            this.cbRotation.UseVisualStyleBackColor = true;
            // 
            // cbRadiator
            // 
            this.cbRadiator.AutoSize = true;
            this.cbRadiator.Location = new System.Drawing.Point(25, 19);
            this.cbRadiator.Name = "cbRadiator";
            this.cbRadiator.Size = new System.Drawing.Size(106, 17);
            this.cbRadiator.TabIndex = 5;
            this.cbRadiator.Text = "Radiator Flush";
            this.cbRadiator.UseVisualStyleBackColor = true;
            // 
            // getTotalBtn
            // 
            this.getTotalBtn.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.getTotalBtn.Location = new System.Drawing.Point(498, 193);
            this.getTotalBtn.Name = "getTotalBtn";
            this.getTotalBtn.Size = new System.Drawing.Size(137, 23);
            this.getTotalBtn.TabIndex = 6;
            this.getTotalBtn.Text = "Calculate Total";
            this.getTotalBtn.UseVisualStyleBackColor = true;
            this.getTotalBtn.Click += new System.EventHandler(this.getTotalBtn_Click);
            // 
            // resetAllBtn
            // 
            this.resetAllBtn.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAllBtn.Location = new System.Drawing.Point(646, 193);
            this.resetAllBtn.Name = "resetAllBtn";
            this.resetAllBtn.Size = new System.Drawing.Size(75, 23);
            this.resetAllBtn.TabIndex = 7;
            this.resetAllBtn.Text = "Reset";
            this.resetAllBtn.UseVisualStyleBackColor = true;
            this.resetAllBtn.Click += new System.EventHandler(this.resetAllBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(727, 193);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(61, 23);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // cbTransmission
            // 
            this.cbTransmission.AutoSize = true;
            this.cbTransmission.Location = new System.Drawing.Point(25, 42);
            this.cbTransmission.Name = "cbTransmission";
            this.cbTransmission.Size = new System.Drawing.Size(134, 17);
            this.cbTransmission.TabIndex = 9;
            this.cbTransmission.Text = "Transmission Flush";
            this.cbTransmission.UseVisualStyleBackColor = true;
            // 
            // gbOilLube
            // 
            this.gbOilLube.Controls.Add(this.togBtnOilLube);
            this.gbOilLube.Controls.Add(this.cbLube);
            this.gbOilLube.Controls.Add(this.cbOil);
            this.gbOilLube.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbOilLube.Location = new System.Drawing.Point(12, 12);
            this.gbOilLube.Name = "gbOilLube";
            this.gbOilLube.Size = new System.Drawing.Size(233, 101);
            this.gbOilLube.TabIndex = 10;
            this.gbOilLube.TabStop = false;
            this.gbOilLube.Text = "Oil and Lube";
            // 
            // togBtnOilLube
            // 
            this.togBtnOilLube.Location = new System.Drawing.Point(39, 65);
            this.togBtnOilLube.Name = "togBtnOilLube";
            this.togBtnOilLube.Size = new System.Drawing.Size(75, 23);
            this.togBtnOilLube.TabIndex = 2;
            this.togBtnOilLube.Text = "Toggle All";
            this.togBtnOilLube.UseVisualStyleBackColor = true;
            this.togBtnOilLube.Click += new System.EventHandler(this.togBtnOilLube_Click);
            // 
            // gbFluidFlush
            // 
            this.gbFluidFlush.Controls.Add(this.togBtnFluid);
            this.gbFluidFlush.Controls.Add(this.cbTransmission);
            this.gbFluidFlush.Controls.Add(this.cbRadiator);
            this.gbFluidFlush.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbFluidFlush.Location = new System.Drawing.Point(251, 12);
            this.gbFluidFlush.Name = "gbFluidFlush";
            this.gbFluidFlush.Size = new System.Drawing.Size(241, 101);
            this.gbFluidFlush.TabIndex = 11;
            this.gbFluidFlush.TabStop = false;
            this.gbFluidFlush.Text = "Fluid Flushes";
            // 
            // togBtnFluid
            // 
            this.togBtnFluid.Location = new System.Drawing.Point(25, 66);
            this.togBtnFluid.Name = "togBtnFluid";
            this.togBtnFluid.Size = new System.Drawing.Size(75, 23);
            this.togBtnFluid.TabIndex = 10;
            this.togBtnFluid.Text = "Toggle All";
            this.togBtnFluid.UseVisualStyleBackColor = true;
            this.togBtnFluid.Click += new System.EventHandler(this.togBtnFluid_Click);
            // 
            // gbMisc
            // 
            this.gbMisc.Controls.Add(this.label10);
            this.gbMisc.Controls.Add(this.label9);
            this.gbMisc.Controls.Add(this.label8);
            this.gbMisc.Controls.Add(this.togBtnMisc);
            this.gbMisc.Controls.Add(this.cbInspection);
            this.gbMisc.Controls.Add(this.cbMuffler);
            this.gbMisc.Controls.Add(this.cbRotation);
            this.gbMisc.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbMisc.Location = new System.Drawing.Point(12, 118);
            this.gbMisc.Name = "gbMisc";
            this.gbMisc.Size = new System.Drawing.Size(233, 128);
            this.gbMisc.TabIndex = 12;
            this.gbMisc.TabStop = false;
            this.gbMisc.Text = "Miscellaneous";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "($15)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "($100)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "($20)";
            // 
            // togBtnMisc
            // 
            this.togBtnMisc.Location = new System.Drawing.Point(34, 88);
            this.togBtnMisc.Name = "togBtnMisc";
            this.togBtnMisc.Size = new System.Drawing.Size(75, 23);
            this.togBtnMisc.TabIndex = 5;
            this.togBtnMisc.Text = "Toggle All";
            this.togBtnMisc.UseVisualStyleBackColor = true;
            this.togBtnMisc.Click += new System.EventHandler(this.togBtnMisc_Click);
            // 
            // gbPartsLabor
            // 
            this.gbPartsLabor.Controls.Add(this.label7);
            this.gbPartsLabor.Controls.Add(this.resetPartsLaborBtn);
            this.gbPartsLabor.Controls.Add(this.textBoxLabor);
            this.gbPartsLabor.Controls.Add(this.textBoxParts);
            this.gbPartsLabor.Controls.Add(this.label2);
            this.gbPartsLabor.Controls.Add(this.label1);
            this.gbPartsLabor.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbPartsLabor.Location = new System.Drawing.Point(251, 119);
            this.gbPartsLabor.Name = "gbPartsLabor";
            this.gbPartsLabor.Size = new System.Drawing.Size(241, 110);
            this.gbPartsLabor.TabIndex = 13;
            this.gbPartsLabor.TabStop = false;
            this.gbPartsLabor.Text = "Variable Costs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "($20/hr)";
            // 
            // resetPartsLaborBtn
            // 
            this.resetPartsLaborBtn.Location = new System.Drawing.Point(97, 69);
            this.resetPartsLaborBtn.Name = "resetPartsLaborBtn";
            this.resetPartsLaborBtn.Size = new System.Drawing.Size(75, 23);
            this.resetPartsLaborBtn.TabIndex = 4;
            this.resetPartsLaborBtn.Text = "Reset";
            this.resetPartsLaborBtn.UseVisualStyleBackColor = true;
            this.resetPartsLaborBtn.Click += new System.EventHandler(this.resetPartsLaborBtn_Click);
            // 
            // textBoxLabor
            // 
            this.textBoxLabor.Location = new System.Drawing.Point(84, 43);
            this.textBoxLabor.Name = "textBoxLabor";
            this.textBoxLabor.Size = new System.Drawing.Size(88, 20);
            this.textBoxLabor.TabIndex = 3;
            this.textBoxLabor.Text = "0.00";
            this.textBoxLabor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxLabor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_OnKeyPress_ValidateNum);
            // 
            // textBoxParts
            // 
            this.textBoxParts.Location = new System.Drawing.Point(84, 15);
            this.textBoxParts.Name = "textBoxParts";
            this.textBoxParts.Size = new System.Drawing.Size(88, 20);
            this.textBoxParts.TabIndex = 2;
            this.textBoxParts.Text = "0.00";
            this.textBoxParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxParts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_OnKeyPress_ValidateNum);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts";
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.label6);
            this.gbSummary.Controls.Add(this.label5);
            this.gbSummary.Controls.Add(this.textBoxTotalSum);
            this.gbSummary.Controls.Add(this.textBoxTaxSum);
            this.gbSummary.Controls.Add(this.textBoxPartsSum);
            this.gbSummary.Controls.Add(this.textBoxLaborSum);
            this.gbSummary.Controls.Add(this.label4);
            this.gbSummary.Controls.Add(this.label3);
            this.gbSummary.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbSummary.Location = new System.Drawing.Point(498, 12);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(290, 173);
            this.gbSummary.TabIndex = 14;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(55, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Grand Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Taxes";
            // 
            // textBoxTotalSum
            // 
            this.textBoxTotalSum.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTotalSum.Location = new System.Drawing.Point(154, 121);
            this.textBoxTotalSum.Name = "textBoxTotalSum";
            this.textBoxTotalSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalSum.TabIndex = 5;
            this.textBoxTotalSum.Text = "$0.00";
            this.textBoxTotalSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTotalSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_DoNothing);
            // 
            // textBoxTaxSum
            // 
            this.textBoxTaxSum.Location = new System.Drawing.Point(154, 95);
            this.textBoxTaxSum.Name = "textBoxTaxSum";
            this.textBoxTaxSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxTaxSum.TabIndex = 4;
            this.textBoxTaxSum.Text = "$0.00";
            this.textBoxTaxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTaxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_DoNothing);
            // 
            // textBoxPartsSum
            // 
            this.textBoxPartsSum.Location = new System.Drawing.Point(154, 66);
            this.textBoxPartsSum.Name = "textBoxPartsSum";
            this.textBoxPartsSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartsSum.TabIndex = 3;
            this.textBoxPartsSum.Text = "$0.00";
            this.textBoxPartsSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPartsSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_DoNothing);
            // 
            // textBoxLaborSum
            // 
            this.textBoxLaborSum.Location = new System.Drawing.Point(154, 39);
            this.textBoxLaborSum.Name = "textBoxLaborSum";
            this.textBoxLaborSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxLaborSum.TabIndex = 2;
            this.textBoxLaborSum.Text = "$0.00";
            this.textBoxLaborSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxLaborSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_DoNothing);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Services and Labor";
            // 
            // AutoRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 257);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.gbPartsLabor);
            this.Controls.Add(this.gbMisc);
            this.Controls.Add(this.gbFluidFlush);
            this.Controls.Add(this.gbOilLube);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resetAllBtn);
            this.Controls.Add(this.getTotalBtn);
            this.Name = "AutoRepairForm";
            this.Text = "Auto Repair Shop";
            this.gbOilLube.ResumeLayout(false);
            this.gbOilLube.PerformLayout();
            this.gbFluidFlush.ResumeLayout(false);
            this.gbFluidFlush.PerformLayout();
            this.gbMisc.ResumeLayout(false);
            this.gbMisc.PerformLayout();
            this.gbPartsLabor.ResumeLayout(false);
            this.gbPartsLabor.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbOil;
        private System.Windows.Forms.CheckBox cbLube;
        private System.Windows.Forms.CheckBox cbInspection;
        private System.Windows.Forms.CheckBox cbMuffler;
        private System.Windows.Forms.CheckBox cbRotation;
        private System.Windows.Forms.CheckBox cbRadiator;
        private System.Windows.Forms.Button getTotalBtn;
        private System.Windows.Forms.Button resetAllBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.CheckBox cbTransmission;
        private System.Windows.Forms.GroupBox gbOilLube;
        private System.Windows.Forms.Button togBtnOilLube;
        private System.Windows.Forms.GroupBox gbFluidFlush;
        private System.Windows.Forms.Button togBtnFluid;
        private System.Windows.Forms.GroupBox gbMisc;
        private System.Windows.Forms.Button togBtnMisc;
        private System.Windows.Forms.GroupBox gbPartsLabor;
        private System.Windows.Forms.Button resetPartsLaborBtn;
        private System.Windows.Forms.TextBox textBoxLabor;
        private System.Windows.Forms.TextBox textBoxParts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTotalSum;
        private System.Windows.Forms.TextBox textBoxTaxSum;
        private System.Windows.Forms.TextBox textBoxPartsSum;
        private System.Windows.Forms.TextBox textBoxLaborSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

