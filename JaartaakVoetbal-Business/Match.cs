using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakVoetbal_Business
{
    public class Match
    {

        //hier komen je private fields
        private string _thuisPloeg;
        private string _bezoekersPloeg;
        private int _thuisScore;
        private int _bezoekersScore;
        private DateTime _speeldag;


        //methode
        //override van ToString
        public override string ToString()
        {
            return _thuisPloeg + " - " + _bezoekersPloeg + " (" + _thuisScore.ToString() + "-" + _bezoekersScore.ToString() + ")";
        }

    }
}
