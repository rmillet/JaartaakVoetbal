using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JaartaakVoetbal_Business;

namespace JaartaakVoetbal_Forms
{
	public partial class Form1 : Form
    {
		private Ploegenlijst jupilerproleague = new Ploegenlijst();
		private Klassement scores;
		public Form1()
        {
            InitializeComponent();
			scores = new Klassement();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			jupilerproleague.addPloeg("Club Brugge");
			jupilerproleague.addPloeg("KRC Genk");
			jupilerproleague.addPloeg("Charleroi");
			jupilerproleague.addPloeg("Standard");

			lbxThuisploeg.DataSource = jupilerproleague.Ploegen;
			lbxBezoekers.BindingContext = new BindingContext();
			lbxBezoekers.DataSource = jupilerproleague.Ploegen;
			cboploegen.BindingContext = new BindingContext();
			cboploegen.DataSource = jupilerproleague.Ploegen;
		}

		private void lbxThuisploeg_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnmatch_Click(object sender, EventArgs e)
		{
			int ThuisScore = Convert.ToInt16(TxtScoreThuis.Text);
			int UitScore = Convert.ToInt16(TxtScoreUit.Text);
			string Thuisploeg = lbxThuisploeg.SelectedItem.ToString();
			string Uitploeg = lbxBezoekers.SelectedItem.ToString();
			DateTime datum = dtpSpeeldag.Value;
			Match wedstrijd = new Match(Thuisploeg, Uitploeg, ThuisScore, UitScore, datum);
			scores.addMatch(wedstrijd);
			lbxOverzichtM.DataSource = null;
			lbxOverzichtM.DataSource = scores.Matchen;
		}

		private void cboploegen_SelectedIndexChanged(object sender, EventArgs e)
		{
			string Ploeg = cboploegen.SelectedItem.ToString();
			lbxOverzichtP.DataSource = null;
			lbxOverzichtP.DataSource = scores.getMatchen(Ploeg);
			lblAantGew.Text = scores.getPloegOverzicht(Ploeg).AantalMatchWins.ToString();
			lblAantGel.Text = scores.getPloegOverzicht(Ploeg).AantalMatchDraws.ToString();
			lblAantVerl.Text = scores.getPloegOverzicht(Ploeg).AantalMatchLoss.ToString();
			lblAantPunten.Text = scores.getPloegOverzicht(Ploeg).getPunten().ToString();


		}
	}
}
