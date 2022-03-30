using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        int anzahlSeiten;
       public Wuerfel(int anzahlSeiten)
        {
            if (anzahlSeiten < 2)
            {
                throw new  ArgumentOutOfRangeException("Der Würfel kann nicht weniger als zwei Seiten haben.");
            }
            else
            {
                this.anzahlSeiten = anzahlSeiten;
            }
        }

        

        public int AnzahlSeiten { get => anzahlSeiten;}
    }
}
