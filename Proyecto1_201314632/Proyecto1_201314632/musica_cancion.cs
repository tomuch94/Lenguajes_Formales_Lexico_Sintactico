using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_201314632
{

    public class musica_cancion
    {
        private String nombre;
        private String url;

        public String getnombre()
        {
            return nombre;
        }
        public String geturl()
        {
            return url;
        }
        public void setnombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void seturl(String url)
        {
            this.url = url;
        }
    }
}
