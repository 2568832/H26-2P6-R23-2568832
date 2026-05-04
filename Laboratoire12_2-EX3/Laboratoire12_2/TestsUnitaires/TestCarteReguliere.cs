#define _TESTS_CARTE_REGULIERE

using Modeles;

namespace TestsUnitaires
{
    [TestClass]
    public sealed class TestCarteReguliere
    {
        const double LIMITE_TEST = 2000;
        const double TAUX_TEST = 0.02;

        const double EMPRUNT_MONTANT_TEST = 100;
#if _TESTS_CARTE_REGULIERE
        Carte CréerCarteValide()
        {            
            return new CarteReguliere(LIMITE_TEST, TAUX_TEST);
        }

        [TestMethod]
        public void TestLimiteNégative()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CarteReguliere(-1, 0.02));
        }
        [TestMethod]
        public void TestTauxNégatif()
        {            
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CarteReguliere(1000, -0.02));
        }

        [TestMethod]
        public void TestEmpruntNégatif()
        {
            Carte carte = CréerCarteValide();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carte.Emprunter(-1));
        }

        [TestMethod]
        public void TestRembourserNégatif()
        {
            Carte carte = CréerCarteValide();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carte.Rembourser(-1));
        }

        [TestMethod]
        public void TestLimite()
        {
            Carte carte = CréerCarteValide();
            Assert.AreEqual(carte.Limite, LIMITE_TEST);
        }

        [TestMethod]
        public void TestTaux()
        {
            Carte carte = CréerCarteValide();            
            Assert.AreEqual(carte.TauxIntérêt, TAUX_TEST);
        }

        [TestMethod]
        public void TestAvantage()
        {
            Carte carte = CréerCarteValide();
            Assert.AreEqual( carte.Avantage, "Aucun" );
        }

        [TestMethod]
        public void TestEmpruntValide()
        {
            Carte carte = CréerCarteValide();
            Assert.IsTrue(carte.Emprunter(EMPRUNT_MONTANT_TEST));
            Assert.AreEqual(carte.Solde, EMPRUNT_MONTANT_TEST);
        }

        [TestMethod]
        public void TestEmpruntAuDessusLimite()
        {
            Carte carte = CréerCarteValide();
            Assert.IsFalse(carte.Emprunter(carte.Limite+1));
        }

        [TestMethod]
        public void TestRemboursementValide()
        {
            Carte carte = CréerCarteValide();
            Assert.IsTrue(carte.Emprunter(EMPRUNT_MONTANT_TEST));
            Assert.IsTrue(carte.Emprunter(EMPRUNT_MONTANT_TEST));
            Assert.IsTrue(carte.Rembourser(EMPRUNT_MONTANT_TEST));

            Assert.AreEqual(carte.Solde, EMPRUNT_MONTANT_TEST);
        }


        [TestMethod]
        public void TestAppliquerIntérêts()
        {
            Carte carte = CréerCarteValide();
            Assert.IsTrue(carte.Emprunter(EMPRUNT_MONTANT_TEST));
            carte.AppliquerIntérêt();

            Assert.AreEqual(carte.Solde, EMPRUNT_MONTANT_TEST+EMPRUNT_MONTANT_TEST * carte.TauxIntérêt);
        }
#endif
    }
}
