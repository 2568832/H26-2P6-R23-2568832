using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeles
{
    public class Triangle : Forme
    {
        private double _Base;
        private double _Hauteur;
        private double _Aire;

        public double Base
        {
            get { return _Base; }
            set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _Base = value;
                }

            }
        }
        public double Hauteur
        {
            get { return _Hauteur; }
            set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _Hauteur = value;
                }

            }
        }
        public override double Aire
        {
            get {
                _Aire = (_Base * _Hauteur) / 2;
                return _Aire; 
            }
            
        }

        public Triangle(ModeOperation pMode,double pBase, double pHauteur) : base(pMode)
        {
            Base = pBase;
            Hauteur = pHauteur;

        }
    }
}
