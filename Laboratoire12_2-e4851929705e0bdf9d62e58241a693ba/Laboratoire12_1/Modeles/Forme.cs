using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeles
{
    public enum ModeOperation
    {
        Addition,
        Soustraction
    }
    public abstract class Forme
    {
        public ModeOperation ModeOpération { get; set; }
        public abstract double Aire {  get; }
        public Forme(ModeOperation pMode)
        {
            ModeOpération = pMode;
        }

    }
}
