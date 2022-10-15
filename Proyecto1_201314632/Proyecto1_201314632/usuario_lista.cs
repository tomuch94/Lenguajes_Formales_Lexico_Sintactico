using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_201314632
{
    public class usuario_lista
    {
        //simbolo simbolo;
        usuario_nodo primero;
        //Nodo ultimo;
        int id = 1;

        //int tamaño;
        public usuario_lista()
        {
            primero = null;
            //ultimo = null;
        }
        public Boolean estavacio()
        {
            if (primero == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void insertarFinal_lde(String dato)
        {
            usuario_nodo nuevo = new usuario_nodo();
                nuevo.nombre = dato;
                if (primero == null)
                {
                    primero = nuevo;
                }
                else
                {
                    usuario_nodo aux = primero;
                    while (aux.get_siguiente() != null)
                    {
                        aux = aux.get_siguiente();
                    }
                    aux.nsiguiente = nuevo;
                    nuevo.nanterior = aux;
                    id++;
                }


        }
        public void imprimir()
        {
            usuario_nodo actual;
            actual = primero;
            while (actual != null)
            {
                
                actual = actual.nsiguiente;

                
            }
        }

        public usuario_nodo obtener()
        {
            return primero;
        }
        public void vacia_lista()
        {
            usuario_nodo actual;
            actual = primero;
            while (actual != null)
            {
                primero = actual;
                primero = null;
                actual = actual.nsiguiente;


            }
        }
    }
}
