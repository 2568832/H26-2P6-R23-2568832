using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeles
{
    public class Cercle : Forme
    {
        private double _Rayon;
        private double _Aire;

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
                _Aire = (Math.PI * Math.Pow(Rayon, 2));
                return _Aire;
            }
        }

        public Cercle(ModeOperation pMode, double pRayon) : base(pMode)
        {
            Rayon = pRayon;
        }
    }
}
