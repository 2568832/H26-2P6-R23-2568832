#define _TESTS_CARTE_BONI

using Modeles;

namespace TestsUnitaires
{
    [TestClass]
    public sealed class TestCarteBoni
    {
        const double LIMITE_TEST = 2000;
        const double TAUX_TEST = 0.02;
        const double TAUX_POINT_TEST = 0.05;

        const double EMPRUNT_MONTANT_TEST = 100;
#if _TESTS_CARTE_BONI
        CarteBoni CréerCarteValide()
        {            
            return new CarteBoni(LIMITE_TEST, TAUX_TEST,TAUX_POINT_TEST);
        }

        [TestMethod]
        public void TestLimiteNégative()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CarteBoni(-1, 0.02, TAUX_POINT_TEST));
        }
        [TestMethod]
        public void TestTauxNégatif()
        {            
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CarteBoni(1000, -0.02, TAUX_POINT_TEST));
        }

        [TestMethod]
        public void TestTauxBoniInférieur()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CarteBoni(LIMITE_TEST, TAUX_TEST, 0.01));
        }
        [TestMethod]
        public void TestTauxBoniSupérieur()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CarteBoni(LIMITE_TEST, TAUX_TEST, 0.11));
        }

        [TestMethod]
        public void TestEmpruntNégatif()
        {
            CarteBoni carte = CréerCarteValide();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carte.Emprunter(-1));
        }

        [TestMethod]
        public void TestRembourserNégatif()
        {
            CarteBoni carte = CréerCarteValide();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carte.Rembourser(-1));
        }

        [TestMethod]
        public void TestLimite()
        {
            CarteBoni carte = CréerCarteValide();
            Assert.AreEqual(carte.Limite, LIMITE_TEST);
        }

        [TestMethod]
        public void TestTaux()
        {
            CarteBoni carte = CréerCarteValide();            
            
            Assert.AreEqual(carte.TauxIntérêt, TAUX_TEST);            
            Assert.AreEqual(carte.TauxPointsBonis, TAUX_POINT_TEST);
        }

        [TestMethod]
        public void TestAvantage()
        {
            CarteBoni carte = CréerCarteValide();
            Assert.AreEqual( carte.Avantage, "Points bonis: 0.");
        }

        [TestMethod]
        public void TestEmpruntValide()
        {
            CarteBoni carte = CréerCarteValide();
            carte.Emprunter(EMPRUNT_MONTANT_TEST);
            Assert.AreEqual(carte.Solde, EMPRUNT_MONTANT_TEST);
            Assert.AreEqual(carte.PointsBonis, (int)(EMPRUNT_MONTANT_TEST*TAUX_POINT_TEST));
        }

        [TestMethod]
        public void TestRemboursementValide1()
        {
            CarteBoni carte = CréerCarteValide();
            carte.Emprunter(EMPRUNT_MONTANT_TEST);            
            carte.Rembourser(EMPRUNT_MONTANT_TEST);

            Assert.AreEqual(carte.Solde, 0);
            Assert.AreEqual(carte.PointsBonis, (int)(EMPRUNT_MONTANT_TEST * TAUX_POINT_TEST));
        }

        [TestMethod]
        public void TestRemboursementValide2()
        {
            CarteBoni carte = CréerCarteValide();
            carte.Emprunter(EMPRUNT_MONTANT_TEST);
            carte.Emprunter(EMPRUNT_MONTANT_TEST);
            carte.Rembourser(EMPRUNT_MONTANT_TEST);

            Assert.AreEqual(carte.Solde, EMPRUNT_MONTANT_TEST - (int)(2*EMPRUNT_MONTANT_TEST * TAUX_POINT_TEST));
            Assert.AreEqual(carte.PointsBonis, 0);
        }

        [TestMethod]
        public void TestRemboursementValide3()
        {
            CarteBoni carte = CréerCarteValide();
            carte.Emprunter(EMPRUNT_MONTANT_TEST);            
            carte.Rembourser(EMPRUNT_MONTANT_TEST-2);

            Assert.AreEqual(carte.Solde, 0);
            Assert.AreEqual(carte.PointsBonis, (int)(EMPRUNT_MONTANT_TEST * TAUX_POINT_TEST)-2);
        }


        [TestMethod]
        public void TestAppliquerIntérêts()
        {
            Carte carte = CréerCarteValide();
            carte.Emprunter(EMPRUNT_MONTANT_TEST);
            carte.AppliquerIntérêt();

            Assert.AreEqual(carte.Solde, EMPRUNT_MONTANT_TEST+EMPRUNT_MONTANT_TEST * carte.TauxIntérêt);
        }
#endif
    }
}
