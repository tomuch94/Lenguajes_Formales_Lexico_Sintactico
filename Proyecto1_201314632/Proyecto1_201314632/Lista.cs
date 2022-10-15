using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

using System.ComponentModel;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_201314632
{
    public class Lista
    {
        //simbolo simbolo;
        Nodo primero;
        //Nodo ultimo;
        int id = 1;

        //int tamaño;
        public Lista()
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
        public int reservada(String lexema)
        {

            if(lexema.ToLower()=="/**"){
                return 1;
            }
            if (lexema.ToLower() == "configuracion")
            {
                return 2;
            }
            if (lexema.ToLower() == "#")
            {
                return 3;
            }
            if (lexema.ToLower() == "juego")
            {
                return 4;
            }
            if (lexema.ToLower() == "niveles")
            {
                return 5;
            }
            if (lexema.ToLower() == "facil")
            {
                return 6;
            }
            if (lexema.ToLower() == "=")
            {
                return 7;
            }
            if (lexema.ToLower() == "\"")
            {
                return 8;
            }
            decimal number2 = 0;
            Boolean canConvert = decimal.TryParse(lexema, out number2);
            if (canConvert)
            {
                 return 9;
            }
            if (lexema.ToLower() == "intermedio")
            {
                return 10;
            }
            if (lexema.ToLower() == "dificil")
            {
                return 11;
            }
            if (lexema.ToLower() == "tiempo")
            {
                return 12;
            }
            if (lexema.ToLower() == "sonido")
            {
                return 13;
            }
            if (lexema.ToLower() == "nombre")
            {
                return 14;
            }
            if (lexema.ToLower() == "ruta")
            {
                return 16;
            }
            if (lexema.ToLower() == "ahorcado")
            {
                return 18;
            }
            if (lexema.ToLower() == "usuario")
            {
                return 19;
            }
            if (lexema.ToLower() == "vocabulario")
            {
                return 20;
            }
            if (lexema.ToLower() == "idioma")
            {
                return 21;
            }
            if (lexema.ToLower() == "palabra")
            {
                return 22;
            }
            if (lexema.ToLower() == "longitud")
            {
                return 23;
            }
            if (lexema.ToLower() == "pista1")
            {
                return 24;
            }
            if (lexema.ToLower() == "pista2")
            {
                return 25;
            }
            if (lexema.ToLower() == "**/")
            {
                return 26;
            }
   

                


            return 15;
        }

        public void insertarFinal_lde(simbolo dato)
        {
                dato.set_valor(reservada(dato.get_lexema().TrimEnd()));
                Nodo nuevo = new Nodo();
                nuevo.simbolo = dato;
                nuevo.simbolo.set_token("tk_" + dato.get_lexema());
                if (primero == null)
                {
                    nuevo.simbolo.set_id(id);
                    primero = nuevo;
                    id++;
                }
                else
                {
                    Nodo aux = primero;
                    while (aux.get_siguiente() != null)
                    {
                        aux = aux.get_siguiente();
                    }
                    nuevo.simbolo.set_id(id);
                    aux.nsiguiente = nuevo;
                    nuevo.nanterior = aux;
                    id++;
                }


        }
        public void imprimir()
        {
            Nodo actual;
            actual = primero;
            while (actual != null)
            {
                MessageBox.Show("Id: " +actual.simbolo.get_id() + "\nLexema: " +actual.simbolo.get_lexema() + "\nToken: " + actual.simbolo.get_token());
                actual = actual.nsiguiente;

                
            }
        }

        public Nodo obtener()
        {
            return primero;
        }
        public void vacia_lista()
        {
            Nodo actual;
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
