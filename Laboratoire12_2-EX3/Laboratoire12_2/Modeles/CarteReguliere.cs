namespace Modeles
{
    public class CarteReguliere : Carte
    {
        // TODO
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


        public CarteReguliere(double pLimite, double pTauxIntérêt) : base(pLimite,pTauxIntérêt)
        { 
           Limite = pLimite;
            TauxIntérêt = pTauxIntérêt;

            

        }

        public override string Avantage {
            get { return "limite annuelle du Taux d'intérêt"; } 
        }
        public override void AppliquerIntérêt()
        {
            Limite = Limite;
        }

        public override bool Emprunter(double pMontant)
        {
            if ((TauxIntérêt -= pMontant) <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            

        }
        public override bool Rembourser(double pMontant)
        {
            if ((TauxIntérêt += pMontant) >= Limite)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
