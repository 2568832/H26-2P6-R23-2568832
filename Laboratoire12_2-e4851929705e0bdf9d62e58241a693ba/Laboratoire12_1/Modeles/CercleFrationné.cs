using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeles
{
    public class CercleFractionné : Cercle
    {
        private double _Fraction;

        private double _Rayon;

        private double _Aire;

        public double Fraction
        {
            get { return _Fraction; }
            set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _Fraction = value;
                }

            }
        }
        public double Rayon
        {
            get { return _Rayon; }
            set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _Rayon = value;
                }

            }
        }
        public override double Aire
        {
            get
            {
                _Aire = ((Math.PI * (Rayon*Rayon))* Fraction);
                return _Aire;
            }
        }
        public CercleFractionné(ModeOperation pMode, double pRayon, double pFraction) : base(pMode, pRayon)
        {
            Fraction = pFraction;
            Rayon = pRayon;
        }
    }
}
