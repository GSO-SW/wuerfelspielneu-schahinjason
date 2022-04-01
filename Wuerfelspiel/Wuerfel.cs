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

        int anzahlSeiten;

        public int AnzahlSeiten
        {
            get { return anzahlSeiten; }
        }
    }
}
