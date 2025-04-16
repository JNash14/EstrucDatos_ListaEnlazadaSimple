using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_enlazada_simple
{
    class Nodo
    {
        private int edad;
        private Nodo sgte;

        public int Edad { get => edad; set => edad = value; } // este es el constructor get para obtener y set para editar
        internal Nodo Sgte { get => sgte; set => sgte = value; }
    }
}
