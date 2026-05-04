using Modeles;

namespace Laboratoire12_1
{
    internal class Program
    {
        // TODO 3: Créer les 3 fonctions d'illustration ici
        static void AfficherAireIllustration1()
        {
           
        }
        static void AfficherAireIllustration2()
        {
        }
        static void AfficherAireIllustration3()
        {
        }

        static void Main(string[] args)
        {
            // Exercice 1 (pas dans le code mais visio)

            // Exercice 2
            // TODO 1: Dans la librairie Modeles, créer les classes de formes nécessaires à partir
            // de la classe de base Forme

            // Exercice 3
            // TODO 2: Compléter la classe Caculateur

            // TODO 4: Appeler les 3 fonctions d'illustration ici et afficher l'aire totale pour chacune à la console.

            
            Calculateur calculateur = new Calculateur();
            
            Cercle Cercle = new Cercle(ModeOperation.Addition,3.2);

            Cercle Cercle1 = new Cercle(ModeOperation.Soustraction, 1.1);
            Cercle Cercle2 = new Cercle(ModeOperation.Soustraction, 1.1);
            CercleFractionné demiCercle = new CercleFractionné(ModeOperation.Soustraction, 2.2,0.5);

            calculateur.AppliquerForme(Cercle);
            calculateur.AppliquerForme(Cercle1);
            calculateur.AppliquerForme(Cercle2);
            calculateur.AppliquerForme(demiCercle);

            Console.WriteLine(calculateur.AireTotale);


            Calculateur calculateur2 = new Calculateur();

            Cercle CercleIl3 = new Cercle(ModeOperation.Addition, 6.2);

            CercleFractionné demiCercle1 = new CercleFractionné(ModeOperation.Soustraction, 1.3, 0.75);
            CercleFractionné demiCercleBouche = new CercleFractionné(ModeOperation.Soustraction, 3.1, 0.5);
            Cercle petitCercle = new Cercle(ModeOperation.Soustraction,0.9);
            Triangle T1 = new Triangle(ModeOperation.Addition,1.9,2.7);
            Rectangle R1 = new Rectangle(ModeOperation.Soustraction, 1.2, 1.1);
            Hexagone hexagone = new Hexagone(ModeOperation.Addition, 1.5);

            
            calculateur2.AppliquerForme(demiCercle1);
            calculateur2.AppliquerForme(demiCercle1);
            calculateur2.AppliquerForme(hexagone);
            calculateur2.AppliquerForme(hexagone);
            calculateur2.AppliquerForme(T1);
            calculateur2.AppliquerForme(T1);
            calculateur2.AppliquerForme(T1);
            calculateur2.AppliquerForme(R1);
            calculateur2.AppliquerForme(demiCercleBouche);
            calculateur2.AppliquerForme(petitCercle);

            calculateur2.AppliquerForme(CercleIl3);



            Console.WriteLine(calculateur2.AireTotale);






        }
    }
}
