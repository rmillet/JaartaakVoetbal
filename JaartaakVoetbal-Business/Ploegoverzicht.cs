using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakVoetbal_Business
{
    public class Ploegoverzicht
    {
        private int _aantalMatchWin;
        private int _aantalMatchLoss;
        private int _aanntalMatchDraws;

        // terug de eigenschappen gaan aanmaken 'zie ook match


        public int getPunten()
        {
            int totaal=0;
            // bepaal het aantal punten
            return totaal;
        }

        public Ploegoverzicht()
        {
            _aanntalMatchDraws = 0;
            _aantalMatchLoss = 0;
            _aantalMatchWin = 0;
        }
    }
}
