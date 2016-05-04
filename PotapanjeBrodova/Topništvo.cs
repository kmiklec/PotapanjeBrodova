using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public enum TaktikaGađanja
    {
            Napipavanje,
            Okruživanje,
            SustavnoUništavanje
    }
    public class Topništvo
    {
        public Topništvo()
        {
            PromjeniTaktikuUNapipavanje();
        }
        public Polje UputiPucanj(Flota flota)
        {
            return pucač.UputiPucanj();
        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            // implementirati logiku za dz
        }

        private void PromjeniTaktikuUNapipavanje()
        {
            TrenutnaTaktika = TaktikaGađanja.Napipavanje;
            pucač = new Napipač(mreža, duljinaBroda);

        }

        private void PromjeniTaktikuUSustavnoUništavanje()
        {
            TrenutnaTaktika = TaktikaGađanja.SustavnoUništavanje;
        }

        private void PromjeniTaktikuUOkruživanje()
        {
            TrenutnaTaktika = TaktikaGađanja.Okruživanje;
        }

        public TaktikaGađanja TrenutnaTaktika
        {
            get; private set;
        }
        private Flota flota;
        IPucač pucač;
    }
}