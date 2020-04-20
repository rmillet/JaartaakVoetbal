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

        public Match()
        {
            _thuisPloeg = "";
            _bezoekersPloeg = "";
            _thuisScore = 0;
            _bezoekersScore = 0;
            _speeldag = DateTime.Today;
        }

        public Match (string thuisploeg, string bezoekersploeg, int thuisScore, int bezoekersScore, DateTime speeldag)
        {
            _thuisPloeg = thuisploeg;
            _bezoekersPloeg = bezoekersploeg;
            _thuisScore = thuisScore;
            _bezoekersScore = bezoekersScore;
            _speeldag = speeldag;
        }

        public string Thuisploeg
        {
            get { return _thuisPloeg; }
            set { _thuisPloeg = value; }
        }

        public string BezoekersPloeg
        {
            get { return _bezoekersPloeg; }
            set { _bezoekersPloeg = value; }
        }

        public int ThuisScore
        {
            get { return _thuisScore; }
            set { _thuisScore = value; }
        }

        public int BezoekersScore
        {
            get { return _bezoekersScore; }
            set { _bezoekersScore = value; }
        }

        public DateTime Speeldag
        {
            get { return _speeldag; }
            set { _speeldag = value; }
        }

    }
}
