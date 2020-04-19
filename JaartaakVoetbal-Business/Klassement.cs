using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakVoetbal_Business
{
    public class Klassement
    {
        private List<Match> _matchen;

        public List<Match> Matchen
        {
            get { return _matchen; }
        }

        public Klassement()
        {
            _matchen = new List<Match>();
        }

        public void addMatch (Match match)
        {
            // code schrijven om een match toe te voegen aan de lijst

        }

        public List<Match> getMatchen( string ploegnaam)
        {
            List<Match> temp = new List<Match>();

            // code schrijft om alle matchen die voldoet aan de ploegnaam toe te voegen aan die lijst
            // zie cursus p.142

            return temp;
        }

    }
}
