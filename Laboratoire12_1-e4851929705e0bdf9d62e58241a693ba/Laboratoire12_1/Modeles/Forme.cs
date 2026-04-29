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
    public class Forme
    {
        public ModeOperation ModeOpération { get; set; }
        public virtual double Aire {  get; }
        public Forme(ModeOperation pMode)
        {
            ModeOpération = pMode;
        }

    }
}
