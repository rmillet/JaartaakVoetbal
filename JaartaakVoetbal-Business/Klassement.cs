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

        public Klassement()
        {
            _matchen = new List<Match>();
        }

        public List<Match> Matchen
        {
            get { return _matchen; }
        }     

        public void addMatch (Match match)
        {
			// code schrijven om een match toe te voegen aan de lijst
			_matchen.Add(match);

        }

        public List<Match> getMatchen( string ploegnaam)
        {
            List<Match> temp = new List<Match>();

            // code schrijft om alle matchen die voldoet aan de ploegnaam toe te voegen aan die lijst
            // zie cursus p.142
            foreach (Match item in _matchen)
            {
                if (item.BezoekersPloeg == ploegnaam || item.Thuisploeg == ploegnaam)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }

        public Ploegoverzicht getPloegOverzicht(string ploegNaam)
        {
            Ploegoverzicht temp = new Ploegoverzicht();
            int puntenPloeg = 0;
            int puntenTegenstander = 0;

            foreach (Match item in getMatchen(ploegNaam))
            {
                if (item.Thuisploeg == ploegNaam)
                {
                    puntenPloeg = item.ThuisScore;
                    puntenTegenstander = item.BezoekersScore;
                }
                else
                {
                    puntenPloeg = item.BezoekersScore;
                    puntenTegenstander = item.ThuisScore;
                }

                if (puntenPloeg < puntenTegenstander)
                    temp.AantalMatchLoss++;
                else
                {
                    if (puntenPloeg > puntenTegenstander)
                        temp.AantalMatchWins++;
                    else
                        temp.AantalMatchDraws++;
                }
            }
            return temp;
        }

    }
}
