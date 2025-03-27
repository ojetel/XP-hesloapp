using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Kalkulacka kalkulator = new Kalkulacka();

        [TestMethod]
        public void TestSoucetPOS()// správně
        {
            int skutecnost = Kalkulacka.Soucet(5, 7); //skutečný výsledek PRG
            int predstava = 12;// teoretická představa výsledku
            Assert.AreEqual(skutecnost, predstava); // porovnání představy se skutečností
        }

        [TestMethod]
        public void TestSoucetNEG()//špatně
        {
            int skutecnost = Kalkulacka.Soucet(5, 9);// skutečný výsledek PRG
            int predstava = 10;// chybná představa
            Assert.AreEqual(skutecnost, predstava);// porovnání představy se skutečností
        }

        [TestMethod]
        public void TestPodilPOS()// správně
        {
            double vysledek = Kalkulacka.Podil(5, 2); //skutečný výsledek PRG
            double predstava = 2.5;// teoretická představa výsledku
            Assert.AreEqual(vysledek, predstava); // porovnání představy se skutečností
        }

        [TestMethod]
        public void TestPodilNEG()//špatně
        {
            double vysledek = Kalkulacka.Podil(5, 4);// skutečný výsledek PRG
            double predstava = 1;// chybná představa
            Assert.AreEqual(vysledek, predstava);// porovnání představy se skutečností
        }

        [TestMethod]
        public void TestPodil2POS()//správně
        {
            double vysledek = Kalkulacka.Podil(3, 2);// skutečný výsledek PRG
            double predstava = 1.5;// teoretická představa představa
            Assert.AreEqual(vysledek, predstava);// porovnání představy se skutečností
        }
        [TestMethod]
        public void TestPodil2NEG()//špatně
        {
            double vysledek = Kalkulacka.Podil(3, 2);// skutečný výsledek PRG
            double predstava = 1.88;// chybná představa
            Assert.AreEqual(vysledek, predstava);// porovnání představy se skutečností
        }

        [TestMethod]
        public void TestPodil3POS()//správně
        {
            double vysledek = Kalkulacka.Podil(3, 0);// skutečný výsledek PRG
            Assert.IsTrue(double.IsInfinity(vysledek));// porovnání představy se skutečností
        }
        [TestMethod]
        public void TestPodil3NEG()//špatně
        {
            double vysledek = Kalkulacka.Podil(3, 0);// skutečný výsledek PRG
            Assert.IsFalse(double.IsInfinity(vysledek));// porovnání představy se skutečností
        }








        [TestMethod]
        public void TestHesloPOS()
        {
            bool obsahujeRPR = Hesloapp.ObsahujeRPR("RPR5788as");
            Assert.IsTrue(obsahujeRPR);
        }
        [TestMethod]
        public void TestHesloNEG()
        {
            bool obsahujeRPR = Hesloapp.ObsahujeRPR("5788as");
            Assert.IsTrue(obsahujeRPR);
        }
        [TestMethod]
        public void TestHesloDelkaPOS()
        {
            bool jeDlouhe = Hesloapp.JeDlouhe("asegdswer");
            Assert.IsTrue(jeDlouhe);
        }
        [TestMethod]
        public void TestHesloDelkaNEG()
        {
            bool jeDlouhe = Hesloapp.JeDlouhe("asegds");
            Assert.IsTrue(jeDlouhe);
        }
        [TestMethod]
        public void HesloPrazdnePOS()
        {
            bool jeNeprazdne = Hesloapp.JeNeprazdne("a");
            Assert.IsTrue(jeNeprazdne);
        }
        [TestMethod]
        public void HesloPrazdneNEG()
        {
            bool jeNeprazdne = Hesloapp.JeNeprazdne("");
            Assert.IsTrue(jeNeprazdne);
        }
    }
}
