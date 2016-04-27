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
            throw new NotImplementedException();
        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {

        }

        private void PromjeniTaktikuUNapipavanje()
        {
            TrenutnaTaktika = TaktikaGađanja.Napipavanje;
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
    }
}
()