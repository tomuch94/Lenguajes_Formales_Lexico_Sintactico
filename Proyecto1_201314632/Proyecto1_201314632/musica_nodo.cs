using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_201314632
{
    public class musica_nodo
    {
        public musica_cancion cancion;
        public musica_nodo nsiguiente;
        public musica_nodo nanterior;

        public musica_nodo()
        {
            nanterior = null;
            nsiguiente = null;
            this.cancion = null;
        }
        musica_nodo(musica_cancion cancion)
        {
            nanterior = null;
            nsiguiente = null;
            this.cancion = cancion;
        }

        public musica_nodo get_siguiente()
        {
            return nsiguiente;
        }
        public musica_nodo get_anterior()
        {
            return nanterior;
        }

        
    }
}
