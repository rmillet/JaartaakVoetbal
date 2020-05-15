using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakVoetbal_Business
{
    public class Ploegoverzicht
    {
        private int _aantalMatchWins;
        private int _aantalMatchLoss;
        private int _aantalMatchDraws;

        public Ploegoverzicht()
        {
            _aantalMatchDraws = 0;
            _aantalMatchLoss = 0;
            _aantalMatchWins = 0;
        }

        // terug de eigenschappen gaan aanmaken 'zie ook match
        public int AantalMatchWins
        {
            get { return _aantalMatchWins; }
            set { _aantalMatchWins = value; }
        }

        public int AantalMatchLoss
        {
            get { return _aantalMatchLoss; }
            set { _aantalMatchLoss = value; }
        }

        public int AantalMatchDraws
        {
            get { return _aantalMatchDraws; }
            set { _aantalMatchDraws = value; }
        }

        public int getPunten()
        {
            int totaal=0;
            // bepaal het aantal punten
            totaal = _aantalMatchDraws + _aantalMatchWins * 3;
            return totaal;
        }     
    }
}
