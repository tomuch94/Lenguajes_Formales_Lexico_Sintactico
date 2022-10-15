using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_201314632
{
    public class vocabulario_lista
    {
       //simbolo simbolo;
        public vocabulario_nodo primero;
        //Nodo ultimo;
        int id = 1;

        //int tamaño;
        public vocabulario_lista()
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

        public void insertarFinal_lde(vocabulario dato)
        {
            vocabulario_nodo nuevo = new vocabulario_nodo();
                nuevo.vocabulario = dato;
                if (primero == null)
                {
                    primero = nuevo;
                }
                else
                {
                    vocabulario_nodo aux = primero;
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
            vocabulario_nodo actual;
            actual = primero;
            while (actual != null)
            {
                MessageBox.Show(actual.vocabulario.get_idioma());
                actual = actual.nsiguiente;     
            }
        }

        public vocabulario_nodo obtener()
        {
            return primero;
        }
        public void vacia_lista()
        {
            vocabulario_nodo actual;
            actual = primero;
            while (actual != null)
            {
                primero = actual;
                primero = null;
                actual = actual.nsiguiente;


            }
        }

        public int buscar(String idioma,int longitud)
        {
            vocabulario_nodo aux = primero;
            int c = 0;
            while (aux != null)
            {
                if (aux.vocabulario.get_idioma() == idioma) 
                {

                    if (aux.vocabulario.get_palabra().Length == longitud)
                    {

                        //llena lista de palabra a jugar
                        vocabulario palabra = aux.vocabulario;
                        Atributos.lvjuego.insertarFinal_lde(palabra);

                        c++;
                    }
                }
                aux = aux.get_siguiente();
            }


            return c;
        }
    }
}
