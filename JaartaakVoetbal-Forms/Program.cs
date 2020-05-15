using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using JaartaakVoetbal_Business;

namespace JaartaakVoetbal_Forms
{
    static class Program
    {
		Ploegenlijst jupilerproleague = new Ploegenlijst();
		
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

		lboThuisPloeg.DataSource = _ploegenlijst.Ploegen;
		lboBezoekrsPloeg.BindingContext=new BindingContext();
		lboBezoekersPloeg.DataSource=_ploegenlijstt.Ploegen;
		cboPloegen.BindingContext = new BindingContext();
		cboPloegen.DataSource=_ploegenlijst.Ploegen;

		
    }
}
