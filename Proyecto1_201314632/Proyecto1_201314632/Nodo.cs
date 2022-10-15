using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_201314632
{
    public class Nodo
    {
        public simbolo simbolo;
        public Nodo nsiguiente;
        public Nodo nanterior;

        public Nodo()
        {
            nanterior = null;
            nsiguiente = null;
            this.simbolo = null;
        }
        Nodo(simbolo simbolo)
        {
            nanterior = null;
            nsiguiente = null;
            this.simbolo = simbolo;
        }

        public Nodo get_siguiente()
        {
            return nsiguiente;
        }
        public Nodo get_anterior()
        {
            return nanterior;
        }

        
    }
}
