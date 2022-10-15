using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_201314632
{
    public class Atributos
    {

        public static int id;
        public static int nivel;
        //tipo_nivel,numerocaracteres,tiempo
        public static decimal[,] niveles = new decimal[3, 3];


        //LISTAS
        public static usuario_lista usuario = new usuario_lista();


        public static musica_lista musica = new musica_lista();
        public static vocabulario_lista lvocabulario = new vocabulario_lista();

        public static vocabulario_lista lvjuego = new vocabulario_lista();


        public static void vacia_niveles()
        {
            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    niveles[fila, col] = 0;
                }

            }
        }


        public class etiqueta{
            public static int
                APERTURA=1,
                CONFIGURACION=2,
                SHARP=3,
                JUEGO=4,
                NIVELES=5,
                FACIL=6;
                

        }





    }
    

}
