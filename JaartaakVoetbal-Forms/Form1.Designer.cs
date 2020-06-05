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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.lbxThuisploeg = new System.Windows.Forms.ListBox();
			this.ScoreUit = new System.Windows.Forms.TextBox();
			this.ScoreThuis = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.listBox4 = new System.Windows.Forms.ListBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.lbxBezoekers = new System.Windows.Forms.ListBox();
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
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(93, 343);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(513, 95);
			this.listBox1.TabIndex = 10;
			// 
			// lbxThuisploeg
			// 
			this.lbxThuisploeg.FormattingEnabled = true;
			this.lbxThuisploeg.Items.AddRange(new object[] {
            "Club Brugge",
            "KAA Gent",
            "Charleroi",
            "Antwerp",
            "Standard",
            "KV Mechelen",
            "KRC Genk",
            "Anderlecht",
            "Zulte Waregem",
            "Excel Moeskroen",
            "KV Kortrijk",
            "STVV",
            "KAS Eupen",
            "Cercle Brugge",
            "KV Oostende",
            "Waasland-Beveren"});
			this.lbxThuisploeg.Location = new System.Drawing.Point(129, 12);
			this.lbxThuisploeg.Name = "lbxThuisploeg";
			this.lbxThuisploeg.Size = new System.Drawing.Size(224, 82);
			this.lbxThuisploeg.TabIndex = 11;
			// 
			// ScoreUit
			// 
			this.ScoreUit.Location = new System.Drawing.Point(385, 114);
			this.ScoreUit.Name = "ScoreUit";
			this.ScoreUit.Size = new System.Drawing.Size(224, 20);
			this.ScoreUit.TabIndex = 13;
			// 
			// ScoreThuis
			// 
			this.ScoreThuis.Location = new System.Drawing.Point(129, 114);
			this.ScoreThuis.Name = "ScoreThuis";
			this.ScoreThuis.Size = new System.Drawing.Size(224, 20);
			this.ScoreThuis.TabIndex = 14;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(129, 145);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(479, 20);
			this.dateTimePicker1.TabIndex = 15;
			// 
			// listBox4
			// 
			this.listBox4.FormattingEnabled = true;
			this.listBox4.Location = new System.Drawing.Point(93, 197);
			this.listBox4.Name = "listBox4";
			this.listBox4.Size = new System.Drawing.Size(516, 95);
			this.listBox4.TabIndex = 16;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(93, 316);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(512, 21);
			this.comboBox1.TabIndex = 17;
			// 
			// lbxBezoekers
			// 
			this.lbxBezoekers.FormattingEnabled = true;
			this.lbxBezoekers.Items.AddRange(new object[] {
            "Club Brugge",
            "KAA Gent",
            "Charleroi",
            "Antwerp",
            "Standard",
            "KV Mechelen",
            "KRC Genk",
            "Anderlecht",
            "Zulte Waregem",
            "Excel Moeskroen",
            "KV Kortrijk",
            "STVV",
            "KAS Eupen",
            "Cercle Brugge",
            "KV Oostende",
            "Waasland-Beveren"});
			this.lbxBezoekers.Location = new System.Drawing.Point(385, 12);
			this.lbxBezoekers.Name = "lbxBezoekers";
			this.lbxBezoekers.Size = new System.Drawing.Size(224, 82);
			this.lbxBezoekers.TabIndex = 18;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lbxBezoekers);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.listBox4);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.ScoreThuis);
			this.Controls.Add(this.ScoreUit);
			this.Controls.Add(this.lbxThuisploeg);
			this.Controls.Add(this.listBox1);
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
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox lbxThuisploeg;
		private System.Windows.Forms.TextBox ScoreUit;
		private System.Windows.Forms.TextBox ScoreThuis;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ListBox listBox4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ListBox lbxBezoekers;
	}
}

