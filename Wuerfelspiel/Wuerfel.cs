using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        int anzahlSeiten;
        int ergebnis;
        int letztesErgebnis;
        Random rnd = new Random();
        public Wuerfel(int anzahlSeiten)
        {
            if (anzahlSeiten < 2)
            {
                throw new ArgumentOutOfRangeException("Der Würfel kann nicht weniger als zwei Seiten haben.");
            }
            else
            {
                this.anzahlSeiten = anzahlSeiten;
            }
        }
        public Wuerfel()
        {
            this.anzahlSeiten = 6;
            this.letztesErgebnis = 0;
        }


        public int AnzahlSeiten { get => anzahlSeiten; }
        public int Ergebnis { get => ergebnis;}
        public int LetztesErgebnis { get => letztesErgebnis; }

        public void Wuerfeln()
        {
            this.ergebnis = rnd.Next(1, 7);
        }
    }
}
