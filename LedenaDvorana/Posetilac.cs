using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedenaDvorana
{
    class Posetilac
    {
        private string ime;
        private int godine;

        public string Ime { get => ime; set => ime = value; }
        public int Godine { get => godine; set => godine = value; }

        public Posetilac () { }

        public Posetilac (string i, int g)
        {
            ime = i;
            godine = g;
        }
    }
}
