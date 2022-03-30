using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        int anzahlSeiten;
        private int ergebnis;
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



        public int AnzahlSeiten { get => anzahlSeiten; }
        public int Ergebnis { get => ergebnis;}

        public void Wuerfeln()
        {
            this.ergebnis = rnd.Next(1, 7);
        }
    }
}
