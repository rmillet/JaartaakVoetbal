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
			this.SuspendLayout();
			// 
			// lblPloeg
			// 
			this.lblPloeg.AutoSize = true;
			this.lblPloeg.Location = new System.Drawing.Point(33, 35);
			this.lblPloeg.Name = "lblPloeg";
			this.lblPloeg.Size = new System.Drawing.Size(37, 13);
			this.lblPloeg.TabIndex = 0;
			this.lblPloeg.Text = "Ploeg:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 163);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Score:";
			// 
			// lblSpeeldag
			// 
			this.lblSpeeldag.AutoSize = true;
			this.lblSpeeldag.Location = new System.Drawing.Point(33, 193);
			this.lblSpeeldag.Name = "lblSpeeldag";
			this.lblSpeeldag.Size = new System.Drawing.Size(55, 13);
			this.lblSpeeldag.TabIndex = 2;
			this.lblSpeeldag.Text = "Speeldag:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(33, 233);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Overzicht matchen";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(33, 337);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "label5";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}

