namespace Modeles
{
    public abstract class Carte
    {
        public Carte( double pLimite, double pTauxIntérêt)
        {
            Limite = pLimite;
            TauxIntérêt = pTauxIntérêt;
        }

        private double mTauxIntérêt;
        public double TauxIntérêt
        {
            get
            {
                return mTauxIntérêt;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("TauxIntérêt");
                mTauxIntérêt = value;
            }
        }

        private double mLimite;
        public double Limite
        {
            get
            {
                return mLimite;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Limite");
                mLimite = value;
            }
        }

        protected double mSolde;
        public double Solde 
        { 
            get 
            { 
                return mSolde; 
            }
            protected set
            {
                if( value < 0 )
                    throw new ArgumentOutOfRangeException("Solde");
                mSolde = value;
            }
        }

        public abstract string Avantage { get; }
                
        public abstract bool Emprunter(double pMontant);
        public abstract bool Rembourser(double pMontant);
        
        public abstract void AppliquerIntérêt();        
    }
}
