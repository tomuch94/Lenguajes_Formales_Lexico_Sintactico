using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_201314632
{
    public class simbolo
    {
        private int id;
        private String lexema;
        private String token;
        private int fila;
        private int columna;
        private String error;

        //valor
        private int valor;
        public simbolo()
        {
            this.id = 0;
            this.lexema = "";
            this.token = "";
            this.fila = 0;
            this.columna = 0;
            this.error = "";

        }
        public int get_id()
        {
            return this.id;
        }
        public void set_id(int id){
            this.id=id;
        }
        public String get_lexema()
        {
            return this.lexema;
        }
        public void set_lexema(String lexema)
        {
            this.lexema = lexema;
        }
        public String get_token()
        {
            return this.token;
        }
        public void set_token(String token)
        {
            this.token = token;
        }
        public int get_fila()
        {
            return this.fila;
        }
        public void set_fila(int fila)
        {
            this.fila = fila;
        }
        public int get_columna()
        {
            return columna;
        }
        public void set_columna(int columna)
        {
            this.columna = columna;
        }
        public String get_error()
        {
            return error;
        }
        public void set_error(String error)
        {
            this.error = error;
        }

        public int get_valor()
        {
            return valor;
        }
        public void set_valor(int valor)
        {
            this.valor = valor;
        }

    }
}
