using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_201314632
{
    public class musica_lista
    {
        //simbolo simbolo;
        public musica_nodo primero;
        //Nodo ultimo;
        int id = 1;

        //int tamaño;
        public musica_lista()
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

        public void insertarFinal_lde(musica_cancion dato)
        {

            musica_nodo nuevo = new musica_nodo();
                nuevo.cancion = dato;
                //nuevo.cancion.set_token("tk_" + dato.get_le);
                if (primero == null)
                {
                    //nuevo.cancion.set_id(id);
                    primero = nuevo;
                    id++;
                }
                else
                {
                    musica_nodo aux = primero;
                    while (aux.get_siguiente() != null)
                    {
                        aux = aux.get_siguiente();
                    }
                    //nuevo.simbolo.set_id(id);
                    aux.nsiguiente = nuevo;
                    nuevo.nanterior = aux;
                    id++;
                }


        }
        public void imprimir()
        {
            musica_nodo actual;
            actual = primero;
            while (actual != null)
            {
                //MessageBox.Show("Id: " +actual.simbolo.get_id() + "\nLexema: " +actual.simbolo.get_lexema() + "\nToken: " + actual.simbolo.get_token());
                MessageBox.Show("Nombre: " + actual.cancion.getnombre() + "\nUrl: " + actual.cancion.geturl());
                
                actual = actual.nsiguiente;

                
            }
        }

        public String buscar(string ruta)
        {
            musica_nodo actual;
            actual = primero;
            while (actual != null)
            {
                //MessageBox.Show("Id: " +actual.simbolo.get_id() + "\nLexema: " +actual.simbolo.get_lexema() + "\nToken: " + actual.simbolo.get_token());
                if(actual.cancion.geturl()==ruta){
                    return actual.cancion.getnombre();
                }
                actual = actual.nsiguiente;


            }
            return "";
        }

        public musica_nodo obtener()
        {
            return primero;
        }
        public void vacia_lista()
        {
            musica_nodo
                actual;
            actual = primero;
            while (actual != null)
            {
                primero = actual;
                primero = null;
                actual = actual.nsiguiente;


            }
            id = 1;

        }

    }
}