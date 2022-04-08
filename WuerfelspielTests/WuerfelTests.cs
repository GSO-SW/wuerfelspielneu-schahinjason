using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_WuerfelKannMitAnzahlErstelltWerden()
        {
            //Arrange
            int anzahl = 8;
            //Act
            Wuerfel wuerfel = new Wuerfel(anzahl);

            //Assert
            Assert.AreEqual(wuerfel.AnzahlSeiten, anzahl);
        }

        [TestMethod]
        public void Wuerfel_WuerfelWirdMitSechsSeitenErstellt()
        {
            //Arrange
            Wuerfel wuerfel = new Wuerfel();

            //Act
            int anzahlSeiten = wuerfel.AnzahlSeiten;

            //Assert
            Assert.AreEqual(anzahlSeiten, 6);
        }

        [TestMethod]
        public void AnzahlSeiten_AnzahlSeitenKannAbgefragtWerden()
        {
            //Arrange
            int anzahlSeiten = 8;
            Wuerfel wuerfel = new Wuerfel(anzahlSeiten);

            //Act
            int ergebniss = wuerfel.AnzahlSeiten;

            //Assert
            Assert.AreEqual(anzahlSeiten, ergebniss);
        }

        [TestMethod]
        public void Wuerfeln_DurchWuerfelnKannEineZufaelligeZahlErzeugtWerden()
        {
            //Arrange
            int anzahlSeiten = 12;
            Wuerfel wuerfel = new Wuerfel(anzahlSeiten);

            //Act
            int ergebniss = wuerfel.Wuerfeln();

            //Assert
            Assert.IsTrue(ergebniss >= 1 && ergebniss <= anzahlSeiten);
        }

        [TestMethod]
        public void LetztesErgebnis_DasLetzteErgebnisEinesWurfesKannAbgefragtWerden()
        {
            //Arrange
            Wuerfel wuerfel = new Wuerfel();

            //Act
            int wurf = wuerfel.Wuerfeln();

            //Assert
            Assert.AreEqual(wurf, wuerfel.LetztesErgebnis);
        }
    }
}
