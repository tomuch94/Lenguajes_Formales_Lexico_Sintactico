using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_201314632
{
    public class usuario_nodo
    {
        public String nombre;
        public usuario_nodo nsiguiente;
        public usuario_nodo nanterior;

        public usuario_nodo()
        {
            nanterior = null;
            nsiguiente = null;
            this.nombre = null;
        }
        usuario_nodo(String nombre)
        {
            nanterior = null;
            nsiguiente = null;
            this.nombre = nombre;
        }

        public usuario_nodo get_siguiente()
        {
            return nsiguiente;
        }
        public usuario_nodo get_anterior()
        {
            return nanterior;
        }

        
    }
}
