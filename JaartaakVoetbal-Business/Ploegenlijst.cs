using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakVoetbal_Business
{
    public class Ploegenlijst
    {
        private List<string> _ploegen;

        // terug een RO eigenschap aanmaken voor dit veld
		 public List<Match> Ploegen
        {
            get { return _ploegen; }
        }

        // een constructor aanmaken
		public Ploegenlijst()
        {
            _ploegen = new List<Ploegenlijst>();
        }

        // een mogelijkheid om een ploeg toe te voegen aan de lijst
		_ploegen.Add(Ploegenlijst);
    }
}
