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

        // een constructor aanmaken
        public Ploegenlijst()
        {
            _ploegen = new List<string>();
        }

        // terug een RO eigenschap aanmaken voor dit veld
        public List<string> Ploegen
        {
            get { return _ploegen; }
        }

        // een mogelijkheid om een ploeg toe te voegen aan de lijst
        public void addPloeg(string ploeg)
        {
            _ploegen.Add(ploeg);
        }
    }
}
