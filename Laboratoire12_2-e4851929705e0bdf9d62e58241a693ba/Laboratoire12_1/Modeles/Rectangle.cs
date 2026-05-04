using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeles
{
    public class Rectangle : Forme
    {
        
        private double Hauteur { get; set; }
        private double Base { get; set; }

        public Rectangle(ModeOperation pMode, double pHauteur,double pBase ) : base(pMode)
        {
            Hauteur = pHauteur;
            Base = pBase ;
        }

        public override double Aire
        {
            get { return Hauteur * Base; }
        }
    }
}
