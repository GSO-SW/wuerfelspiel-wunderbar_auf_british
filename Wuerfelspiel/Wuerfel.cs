using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        int anzahlSeiten;
       public Wuerfel(int anzahlSeiten)
        {
            this.anzahlSeiten = anzahlSeiten;
        }

        public int AnzahlSeiten { get => anzahlSeiten;}
    }
}
