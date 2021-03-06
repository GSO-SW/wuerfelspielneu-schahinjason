using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        public Wuerfel() :this(6)
        {

        }
        public Wuerfel(int anzahlSeiten)
        {
            this.anzahlSeiten = anzahlSeiten;
            istGesichert = false;
        }

        public int Wuerfeln()
        {
            letztesErgebnis = rndWuerfel.Next(1, anzahlSeiten + 1);
            return letztesErgebnis;
        }
        public bool SicherungUmschalten()
        {
            istGesichert = !istGesichert;
            return istGesichert;
        }

        static Random rndWuerfel = new Random();
        int anzahlSeiten;
        int letztesErgebnis;
        bool istGesichert;

        public int AnzahlSeiten
        {
            get { return anzahlSeiten; }
        }
        public int LetztesErgebnis
        {
            get { return letztesErgebnis; }
        }
        public bool IstGesichert
        {
            get { return istGesichert; }
        }
    }
}
