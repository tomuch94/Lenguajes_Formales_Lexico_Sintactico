using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_201314632
{
    public class vocabulario_nodo
    {
        public vocabulario vocabulario;
        public vocabulario_nodo nsiguiente;
        public vocabulario_nodo nanterior;

        public vocabulario_nodo()
        {
            nanterior = null;
            nsiguiente = null;
            this.vocabulario = null;
        }
        vocabulario_nodo(vocabulario vocabulario)
        {
            nanterior = null;
            nsiguiente = null;
            this.vocabulario = vocabulario;
        }

        public vocabulario_nodo get_siguiente()
        {
            return nsiguiente;
        }
        public vocabulario_nodo get_anterior()
        {
            return nanterior;
        }

        
    }
}

