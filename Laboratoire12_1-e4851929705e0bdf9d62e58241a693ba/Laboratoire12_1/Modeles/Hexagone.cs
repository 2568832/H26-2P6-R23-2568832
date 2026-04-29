using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeles
{
    public class Hexagone : Forme
    {
        private double _Côté;
        
        private double _Aire;

        public double Côté
        {
            get { return _Côté; }
            set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _Côté = value;
                }

            }
        }
        public override double Aire
        {
            get
            {
                _Aire = (0.5 * 3 * Math.Sqrt(3) * Math.Pow(Côté, 2));
                return _Aire;
            }
        }

        public Hexagone(ModeOperation pMode, double pCôté) : base(pMode)
        {
            Côté = pCôté;

        }
    }
}
