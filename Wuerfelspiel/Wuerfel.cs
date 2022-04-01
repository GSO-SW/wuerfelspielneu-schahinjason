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
        }

        public int Wuerfeln()
        {
            return rndWuerfel.Next(0, anzahlSeiten);
        }

        static Random rndWuerfel = new Random();
        int anzahlSeiten;

        public int AnzahlSeiten
        {
            get { return anzahlSeiten; }
        }
    }
}
