using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedenaDvorana
{
    abstract class TerminNaLedu
    {
        protected int maksPosetilaca;
        protected int BrojPosetilaca;
        protected Posetilac[] posetioci;

        public void dodajPosetioca(Posetilac p)
        {
            if(BrojPosetilaca<maksPosetilaca)
            {
                posetioci[BrojPosetilaca++] = p;
            }
        }
        public abstract float zarada();

        public TerminNaLedu()
        {
            BrojPosetilaca = 0;
            maksPosetilaca = 100;

            posetioci = new Posetilac[maksPosetilaca];
        }

        public TerminNaLedu(int maks)
        {
            BrojPosetilaca = 0;
            maksPosetilaca = maks;

            posetioci = new Posetilac[maksPosetilaca];
        }

        public override string ToString()
        {
            return "Na ledenoj povrsini kapaciteta do " + maksPosetilaca + " koja ima " + BrojPosetilaca + " Posetilaca.";
        }
    }
}
