using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_WuerfelKannErstelltWerden()
        {
            //Act
            Wuerfel wuerfel = new Wuerfel();
        }

        [TestMethod]
        public void Wuerfel_WuerfelKannMitAnzahlErstelltWerden()
        {
            //Arrange
            int anzahl = 8;
            //Act
            Wuerfel wuerfel = new Wuerfel(anzahl);
        }

        [TestMethod]
        public void Wuerfel_WuerfelWirdMitSechsSeitenErstellt()
        {
            //Arrange
            Wuerfel wuerfel = new Wuerfel();

            //Act
            int anzahlSeiten = wuerfel.AnzahlSeiten;
        }
    }
}
