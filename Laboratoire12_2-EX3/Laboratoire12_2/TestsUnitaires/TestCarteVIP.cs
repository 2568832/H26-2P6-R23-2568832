#define _TESTS_CARTE_VIP

using Modeles;

namespace TestsUnitaires
{

    [TestClass]
    public sealed class TestCarteVIP
    {
        const double LIMITE_TEST = 3000;
        const double TAUX_TEST = 0.02;
        const double TAUX_POINT_TEST = 0.05;

        const double EMPRUNT_MONTANT_TEST_A = 100;
        const double EMPRUNT_MONTANT_TEST_B = 500;

        const double EMPRUNT_MONTANT_VIP_TEST = 250;
        
        const double TAUX_POINTS_TAUX_LIMITE_A = TAUX_POINT_TEST + 0.01;
        const double TAUX_POINTS_TAUX_LIMITE_B = TAUX_POINT_TEST + 0.02;
        const double TAUX_POINTS_TAUX_LIMITE_C = TAUX_POINT_TEST + 0.03;
#if _TESTS_CARTE_VIP
        CarteVIP CréerCarteValide()
        {            
            return new CarteVIP(LIMITE_TEST, TAUX_TEST,TAUX_POINT_TEST);
        }

        [TestMethod]
        public void TestLimiteNégative()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CarteVIP(-1, 0.02, TAUX_POINT_TEST));
        }
        [TestMethod]
        public void TestTauxNégatif()
        {            
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CarteVIP(1000, -0.02, TAUX_POINT_TEST));
        }

        [TestMethod]
        public void TestTauxBoniInférieur()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CarteVIP(LIMITE_TEST, TAUX_TEST, 0.01));
        }
        [TestMethod]
        public void TestTauxBoniSupérieur()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CarteVIP(LIMITE_TEST, TAUX_TEST, 0.11));
        }

        [TestMethod]
        public void TestEmpruntNégatif()
        {
            CarteVIP carte = CréerCarteValide();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carte.Emprunter(-1));
        }

        [TestMethod]
        public void TestRembourserNégatif()
        {
            CarteVIP carte = CréerCarteValide();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carte.Rembourser(-1));
        }

        [TestMethod]
        public void TestLimite()
        {
            CarteVIP carte = CréerCarteValide();
            Assert.AreEqual(carte.Limite, LIMITE_TEST);
        }

        [TestMethod]
        public void TestTaux()
        {
            CarteVIP carte = CréerCarteValide();            
            
            Assert.AreEqual(carte.TauxIntérêt, TAUX_TEST);            
            Assert.AreEqual(carte.TauxPointsBonis, TAUX_POINT_TEST);
        }

        [TestMethod]
        public void TestAvantage()
        {
            CarteVIP carte = CréerCarteValide();
            Assert.AreEqual( carte.Avantage, "Points bonis: 0. Points VIP: 0.");
        }
               

        [TestMethod]
        public void TestEmpruntValide1()
        {
            CarteVIP carte = CréerCarteValide();
            Assert.IsTrue(carte.Emprunter(EMPRUNT_MONTANT_TEST_A-1));
            Assert.AreEqual(carte.Solde, EMPRUNT_MONTANT_TEST_A-1);
        }
        [TestMethod]
        public void TestEmpruntValide1Boni()
        {
            CarteVIP carte = CréerCarteValide();
            Assert.IsTrue(carte.Emprunter(EMPRUNT_MONTANT_TEST_A - 1));            
            Assert.AreEqual(carte.PointsBonis, (int)((EMPRUNT_MONTANT_TEST_A - 1) * TAUX_POINTS_TAUX_LIMITE_A));
        }
        [TestMethod]
        public void TestEmpruntValide2()
        {
            CarteVIP carte = CréerCarteValide();
            Assert.IsTrue(carte.Emprunter(EMPRUNT_MONTANT_TEST_A));
            Assert.AreEqual(carte.Solde, EMPRUNT_MONTANT_TEST_A);            
        }
        [TestMethod]
        public void TestEmpruntValide2Boni()
        {
            CarteVIP carte = CréerCarteValide();
            Assert.IsTrue(carte.Emprunter(EMPRUNT_MONTANT_TEST_A));            
            Assert.AreEqual(carte.PointsBonis, (int)((EMPRUNT_MONTANT_TEST_A) * TAUX_POINTS_TAUX_LIMITE_B));
        }
        [TestMethod]
        public void TestEmpruntValide3()
        {
            CarteVIP carte = CréerCarteValide();
            Assert.IsTrue(carte.Emprunter(EMPRUNT_MONTANT_TEST_B));
            Assert.AreEqual(carte.Solde, EMPRUNT_MONTANT_TEST_B);
         
        }
        [TestMethod]
        public void TestEmpruntValide3Boni()
        {
            CarteVIP carte = CréerCarteValide();
            Assert.IsTrue(carte.Emprunter(EMPRUNT_MONTANT_TEST_B));            
            Assert.AreEqual(carte.PointsBonis, (int)((EMPRUNT_MONTANT_TEST_B) * TAUX_POINTS_TAUX_LIMITE_C));
        }
        [TestMethod]
        public void TestEmpruntMontantVIP()
        {
            CarteVIP carte = CréerCarteValide();
            Assert.IsTrue(carte.Emprunter(EMPRUNT_MONTANT_VIP_TEST));
            Assert.AreEqual(carte.PointsVIP, 1);
        }
        public void TestEmpruntMontantNonVIP()
        {
            CarteVIP carte = CréerCarteValide();
            Assert.IsTrue(carte.Emprunter(EMPRUNT_MONTANT_VIP_TEST-1));
            Assert.AreEqual(carte.PointsVIP, 0);
        }

        [TestMethod]
        public void TestRemboursementValide1()
        {
            CarteVIP carte = CréerCarteValide();
            double montant = EMPRUNT_MONTANT_TEST_A - 1;
            carte.Emprunter(montant);            
            carte.Rembourser(montant);

            Assert.AreEqual(carte.Solde, 0);
            Assert.AreEqual(carte.PointsBonis, (int)(montant * TAUX_POINTS_TAUX_LIMITE_A));
        }

        [TestMethod]
        public void TestRemboursementValide2()
        {
            CarteBoni carte = CréerCarteValide();
            double montant = EMPRUNT_MONTANT_TEST_A;
            carte.Emprunter(montant);
            carte.Emprunter(montant);
            carte.Rembourser(montant);

            Assert.AreEqual(carte.Solde, montant - (int)(2 * montant * TAUX_POINTS_TAUX_LIMITE_B));
            Assert.AreEqual(carte.PointsBonis, 0);
        }

        [TestMethod]
        public void TestRemboursementValide3()
        {
            CarteVIP carte = CréerCarteValide();
            double montant = EMPRUNT_MONTANT_TEST_A - 1;
            carte.Emprunter(montant);            
            carte.Rembourser(montant - 2);

            Assert.AreEqual(carte.Solde, 0);
            Assert.AreEqual(carte.PointsBonis, (int)(montant * TAUX_POINTS_TAUX_LIMITE_A) -2);
        }


        [TestMethod]
        public void TestAppliquerIntérêtsSansPointsVIP()
        {
            CarteVIP carte = CréerCarteValide();
            carte.Emprunter(EMPRUNT_MONTANT_TEST_A);
            carte.AppliquerIntérêt();

            Assert.AreEqual(carte.Solde, EMPRUNT_MONTANT_TEST_A + EMPRUNT_MONTANT_TEST_A * carte.TauxIntérêt);
        }

        [TestMethod]
        public void TestAppliquerIntérêtsAvecPointVIP()
        {
            CarteVIP carte = CréerCarteValide();

            double montant = 250;
            double montant_total = montant * 5;
            Assert.IsTrue(carte.Emprunter(montant));
            Assert.IsTrue(carte.Emprunter(montant));
            Assert.IsTrue(carte.Emprunter(montant));
            Assert.IsTrue(carte.Emprunter(montant));
            Assert.IsTrue(carte.Emprunter(montant));

            Assert.AreEqual(carte.PointsVIP, 5);

            carte.AppliquerIntérêt();

            // Rabais de taux d'intérêts avec points VIP
            Assert.AreEqual(carte.Solde, montant_total + montant_total * (carte.TauxIntérêt - 0.01));

            // Point VIP remis à zéro après avoir appliqué les intérêts
            Assert.AreEqual(carte.PointsVIP, 0);
        }

        [TestMethod]
        public void TestAppliquerIntérêtsAvecBeaucoupDePointVIP()
        {
            CarteVIP carte = CréerCarteValide();

            double montant = 250;
            double montant_total = montant * 10;
            Assert.IsTrue(carte.Emprunter(montant));
            Assert.IsTrue(carte.Emprunter(montant));
            Assert.IsTrue(carte.Emprunter(montant));
            Assert.IsTrue(carte.Emprunter(montant));
            Assert.IsTrue(carte.Emprunter(montant));
            Assert.IsTrue(carte.Emprunter(montant));
            Assert.IsTrue(carte.Emprunter(montant));
            Assert.IsTrue(carte.Emprunter(montant));
            Assert.IsTrue(carte.Emprunter(montant));
            Assert.IsTrue(carte.Emprunter(montant));

            Assert.AreEqual(carte.PointsVIP, 10);

            carte.AppliquerIntérêt();

            // Rabais de taux maximal parce qu'on a beaucoup trop de points
            Assert.AreEqual(carte.Solde, carte.Solde);

            // Point VIP remis à zéro après avoir appliqué les intérêts
            Assert.AreEqual(carte.PointsVIP, 0);
        }
    }
#endif
}
