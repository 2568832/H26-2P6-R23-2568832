namespace Modeles
{
    public class Calculateur
    {
        private List<Forme> polygones;
        public Calculateur() 
        { 
            polygones = new List<Forme>();
        }

        public void AppliquerForme( Forme polygone )
        {
            polygones.Add( polygone );
        }

        public double AireTotale
        {
            get
            {
                // 1. Déclarer une somme

                // 2. Pour tous les polygones dans la liste
                //      a. Obtenir l'aire
                //      b. Appliquer la bonne opération et mettre à jour la somme
                // 3. Retourner la somme
                return 0f;
            }
        }
    }
}
