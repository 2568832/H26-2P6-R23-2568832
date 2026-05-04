
using Modeles;

namespace TestsUnitaires
{
    [TestClass]
    public sealed class TestFormes
    {
        [TestMethod]
        public void TestAireCercle()
        {
            //Forme c = new Cercle(ModeOperation.Addition, 10.0);
            //Assert.AreEqual(c.Aire, 314.15926535897933);
        }
        [TestMethod]
        public void TestAireCercleFractionné ()
        {
            //Forme c = new CercleFractionné(ModeOperation.Addition, 10.0, 0.5);
            //Assert.AreEqual(c.Aire, 314.15926535897933 * 0.5);
        }
        [TestMethod]
        public void TestAireHexagone()
        {
           //Forme c = new Hexagone(ModeOperation.Addition, 6.0);
           //Assert.AreEqual(c.Aire, 93.530743608719376);
        }
        [TestMethod]
        public void TestAireRectangle()
        {
            //Forme c = new Rectangle(ModeOperation.Addition, 6.0, 10.0);
            //Assert.AreEqual(c.Aire, 6.0 * 10.0);
        }
        [TestMethod]
        public void TestAireTriangle()
        {
            //Forme c = new Triangle(ModeOperation.Addition, 6.0, 10.0);
            //Assert.AreEqual(c.Aire, 6.0 * 10.0 / 2);
        }

        [TestMethod]
        public void TestAireOperateurAddition()
        {
            // addition pure
            //Calculateur calculateur = new Calculateur();
            //calculateur.AppliquerForme(new Rectangle(ModeOperation.Addition, 1.0, 2.0));
            //calculateur.AppliquerForme(new Rectangle(ModeOperation.Addition, 1.0, 2.0));
                        
            //Assert.AreEqual(calculateur.AireTotale, 2.0 + 2.0 );
        }
        [TestMethod]
        public void TestAireOperateurSoustraction()
        {
            // addition pure
            //Calculateur calculateur = new Calculateur();
            //calculateur.AppliquerForme(new Rectangle(ModeOperation.Soustraction, 1.0, 2.0));
            //calculateur.AppliquerForme(new Rectangle(ModeOperation.Soustraction, 1.0, 2.0));

            //Assert.AreEqual(calculateur.AireTotale, -(2.0 + 2.0) );
        }
        [TestMethod]
        public void TestAireOperateurSommeNulle()
        {
            // addition pure
            //Calculateur calculateur = new Calculateur();
            //calculateur.AppliquerForme(new Rectangle(ModeOperation.Addition, 2.0, 4.0));
            //calculateur.AppliquerForme(new Rectangle(ModeOperation.Soustraction, 2.0, 4.0));

            //Assert.AreEqual(calculateur.AireTotale, 0.0);
        }
    }
}
