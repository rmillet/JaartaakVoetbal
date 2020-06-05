namespace JaartaakVoetbal_Forms
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
			this.lblPloeg = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblSpeeldag = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnmatch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbxOverzichtP = new System.Windows.Forms.ListBox();
			this.lbxThuisploeg = new System.Windows.Forms.ListBox();
			this.TxtScoreUit = new System.Windows.Forms.TextBox();
			this.TxtScoreThuis = new System.Windows.Forms.TextBox();
			this.dtpSpeeldag = new System.Windows.Forms.DateTimePicker();
			this.lbxOverzichtM = new System.Windows.Forms.ListBox();
			this.cboploegen = new System.Windows.Forms.ComboBox();
			this.lbxBezoekers = new System.Windows.Forms.ListBox();
			this.lblAantPunten = new System.Windows.Forms.Label();
			this.lblAantGew = new System.Windows.Forms.Label();
			this.lblAantGel = new System.Windows.Forms.Label();
			this.lblAantVerl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblPloeg
			// 
			this.lblPloeg.AutoSize = true;
			this.lblPloeg.Location = new System.Drawing.Point(34, 9);
			this.lblPloeg.Name = "lblPloeg";
			this.lblPloeg.Size = new System.Drawing.Size(37, 13);
			this.lblPloeg.TabIndex = 0;
			this.lblPloeg.Text = "Ploeg:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Score:";
			// 
			// lblSpeeldag
			// 
			this.lblSpeeldag.AutoSize = true;
			this.lblSpeeldag.Location = new System.Drawing.Point(33, 145);
			this.lblSpeeldag.Name = "lblSpeeldag";
			this.lblSpeeldag.Size = new System.Drawing.Size(55, 13);
			this.lblSpeeldag.TabIndex = 2;
			this.lblSpeeldag.Text = "Speeldag:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(38, 183);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Overzicht matchen";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(33, 295);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Overzicht per ploeg";
			// 
			// btnmatch
			// 
			this.btnmatch.Location = new System.Drawing.Point(615, 12);
			this.btnmatch.Name = "btnmatch";
			this.btnmatch.Size = new System.Drawing.Size(173, 153);
			this.btnmatch.TabIndex = 5;
			this.btnmatch.Text = "VOEG MATCH TOE";
			this.btnmatch.UseVisualStyleBackColor = true;
			this.btnmatch.Click += new System.EventHandler(this.btnmatch_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(612, 304);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Aantal punten:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(612, 331);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Aantal gewonnen: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(612, 362);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Aantal gelijkspel: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(612, 390);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(101, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "Aantal verloren: ";
			// 
			// lbxOverzichtP
			// 
			this.lbxOverzichtP.FormattingEnabled = true;
			this.lbxOverzichtP.Location = new System.Drawing.Point(93, 343);
			this.lbxOverzichtP.Name = "lbxOverzichtP";
			this.lbxOverzichtP.Size = new System.Drawing.Size(513, 95);
			this.lbxOverzichtP.TabIndex = 10;
			// 
			// lbxThuisploeg
			// 
			this.lbxThuisploeg.FormattingEnabled = true;
			this.lbxThuisploeg.Location = new System.Drawing.Point(129, 12);
			this.lbxThuisploeg.Name = "lbxThuisploeg";
			this.lbxThuisploeg.Size = new System.Drawing.Size(224, 82);
			this.lbxThuisploeg.TabIndex = 11;
			this.lbxThuisploeg.SelectedIndexChanged += new System.EventHandler(this.lbxThuisploeg_SelectedIndexChanged);
			// 
			// TxtScoreUit
			// 
			this.TxtScoreUit.Location = new System.Drawing.Point(385, 114);
			this.TxtScoreUit.Name = "TxtScoreUit";
			this.TxtScoreUit.Size = new System.Drawing.Size(224, 20);
			this.TxtScoreUit.TabIndex = 13;
			// 
			// TxtScoreThuis
			// 
			this.TxtScoreThuis.Location = new System.Drawing.Point(129, 114);
			this.TxtScoreThuis.Name = "TxtScoreThuis";
			this.TxtScoreThuis.Size = new System.Drawing.Size(224, 20);
			this.TxtScoreThuis.TabIndex = 14;
			// 
			// dtpSpeeldag
			// 
			this.dtpSpeeldag.Location = new System.Drawing.Point(129, 145);
			this.dtpSpeeldag.Name = "dtpSpeeldag";
			this.dtpSpeeldag.Size = new System.Drawing.Size(479, 20);
			this.dtpSpeeldag.TabIndex = 15;
			// 
			// lbxOverzichtM
			// 
			this.lbxOverzichtM.FormattingEnabled = true;
			this.lbxOverzichtM.Location = new System.Drawing.Point(93, 197);
			this.lbxOverzichtM.Name = "lbxOverzichtM";
			this.lbxOverzichtM.Size = new System.Drawing.Size(516, 95);
			this.lbxOverzichtM.TabIndex = 16;
			// 
			// cboploegen
			// 
			this.cboploegen.FormattingEnabled = true;
			this.cboploegen.Location = new System.Drawing.Point(93, 316);
			this.cboploegen.Name = "cboploegen";
			this.cboploegen.Size = new System.Drawing.Size(512, 21);
			this.cboploegen.TabIndex = 17;
			this.cboploegen.SelectedIndexChanged += new System.EventHandler(this.cboploegen_SelectedIndexChanged);
			// 
			// lbxBezoekers
			// 
			this.lbxBezoekers.FormattingEnabled = true;
			this.lbxBezoekers.Location = new System.Drawing.Point(385, 12);
			this.lbxBezoekers.Name = "lbxBezoekers";
			this.lbxBezoekers.Size = new System.Drawing.Size(224, 82);
			this.lbxBezoekers.TabIndex = 18;
			// 
			// lblAantPunten
			// 
			this.lblAantPunten.AutoSize = true;
			this.lblAantPunten.Location = new System.Drawing.Point(740, 304);
			this.lblAantPunten.Name = "lblAantPunten";
			this.lblAantPunten.Size = new System.Drawing.Size(0, 13);
			this.lblAantPunten.TabIndex = 19;
			// 
			// lblAantGew
			// 
			this.lblAantGew.AutoSize = true;
			this.lblAantGew.Location = new System.Drawing.Point(740, 331);
			this.lblAantGew.Name = "lblAantGew";
			this.lblAantGew.Size = new System.Drawing.Size(0, 13);
			this.lblAantGew.TabIndex = 20;
			// 
			// lblAantGel
			// 
			this.lblAantGel.AutoSize = true;
			this.lblAantGel.Location = new System.Drawing.Point(740, 362);
			this.lblAantGel.Name = "lblAantGel";
			this.lblAantGel.Size = new System.Drawing.Size(0, 13);
			this.lblAantGel.TabIndex = 21;
			// 
			// lblAantVerl
			// 
			this.lblAantVerl.AutoSize = true;
			this.lblAantVerl.Location = new System.Drawing.Point(740, 390);
			this.lblAantVerl.Name = "lblAantVerl";
			this.lblAantVerl.Size = new System.Drawing.Size(0, 13);
			this.lblAantVerl.TabIndex = 22;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblAantVerl);
			this.Controls.Add(this.lblAantGel);
			this.Controls.Add(this.lblAantGew);
			this.Controls.Add(this.lblAantPunten);
			this.Controls.Add(this.lbxBezoekers);
			this.Controls.Add(this.cboploegen);
			this.Controls.Add(this.lbxOverzichtM);
			this.Controls.Add(this.dtpSpeeldag);
			this.Controls.Add(this.TxtScoreThuis);
			this.Controls.Add(this.TxtScoreUit);
			this.Controls.Add(this.lbxThuisploeg);
			this.Controls.Add(this.lbxOverzichtP);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnmatch);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblSpeeldag);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblPloeg);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label lblPloeg;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblSpeeldag;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnmatch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListBox lbxOverzichtP;
		private System.Windows.Forms.ListBox lbxThuisploeg;
		private System.Windows.Forms.TextBox TxtScoreUit;
		private System.Windows.Forms.TextBox TxtScoreThuis;
		private System.Windows.Forms.DateTimePicker dtpSpeeldag;
		private System.Windows.Forms.ListBox lbxOverzichtM;
		private System.Windows.Forms.ComboBox cboploegen;
		private System.Windows.Forms.ListBox lbxBezoekers;
		private System.Windows.Forms.Label lblAantPunten;
		private System.Windows.Forms.Label lblAantGew;
		private System.Windows.Forms.Label lblAantGel;
		private System.Windows.Forms.Label lblAantVerl;
	}
}

