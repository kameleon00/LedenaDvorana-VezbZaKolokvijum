using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedenaDvorana
{
    class Klub:TerminNaLedu
    {
        private float osnovica;

        private bool Takmicenje;

        public Klub(int maks, float os, bool tak):base(maks)
        {
            osnovica = os;
            Takmicenje = tak;
        }

        public Klub():base()
        {
            osnovica = 10000;
            Takmicenje = false;
        }

        public override float zarada()
        {
            if (Takmicenje)
                return osnovica + 5000;
            else
                return osnovica;
        }

        public override string ToString()
        {
            return "Klubski termin " + base.ToString() + " u kojem je odrzan turnir - " + Takmicenje + " Ostvaruje zaradu " + zarada();
        }
    }
}
