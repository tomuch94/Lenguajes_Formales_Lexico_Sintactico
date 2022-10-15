using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_201314632
{
    public class vocabulario
    {
        private String idioma;
        private String palabra;
        private int longitud;
        private String pista1;
        private String pista2;

        public void set_idioma(String idioma)
        {
            this.idioma = idioma;
        }

        public String get_idioma()
        {
            return idioma;
        }
        public void set_palabra(String palabra)
        {
            this.palabra = palabra;
        }
        public String get_palabra()
        {
            return palabra;
        }
        public void set_longitud(int longitud)
        {
            this.longitud = longitud;
        }
        public int get_longitud()
        {
            return longitud;
        }
        public void set_pista1(String pista1)
        {
            this.pista1 = pista1;
        }

        public String get_pista1()
        {
            return pista1;
        }
        public void set_pista2(String pista2)
        {
            this.pista2 = pista2;
        }
        public String get_pista2()
        {
            return pista2;
        }

    }
}
