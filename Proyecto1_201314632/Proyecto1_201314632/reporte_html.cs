using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_201314632
{
    public class reporte_html
    {
        Lista nreporte = new Lista();
        public void nodo(Lista tabla)
        {
            this.nreporte = tabla;

        }
        public void crea_reporte_error()
        {
            StreamWriter reporte2 = new StreamWriter("tabla_errores.html");
            
            reporte2.WriteLine("<!DOCTYPE html>");
            reporte2.WriteLine("<html>");
            reporte2.WriteLine("<head>");
            reporte2.WriteLine("<title>Reporte_html</title>");
            //estilo
            reporte2.WriteLine("<style>");
            reporte2.WriteLine("table {");
            reporte2.WriteLine("font-family: arial, sans-serif;");
            reporte2.WriteLine("border: 1px solid #dddddd;");
            //reporte2.WriteLine("border-collapse: collapse;");
            reporte2.WriteLine("width: 100%;");
            reporte2.WriteLine("}");
            reporte2.WriteLine("td, th {");
            reporte2.WriteLine("border: 1px solid #dddddd;");
            reporte2.WriteLine("text-align: left;");
            reporte2.WriteLine("padding: 8px;");
            reporte2.WriteLine("}");
            reporte2.WriteLine("th{");
            reporte2.WriteLine("background-color:#2196F3;");
            reporte2.WriteLine("color: white;");
            reporte2.WriteLine("}");
            reporte2.WriteLine("</style>");

            reporte2.WriteLine("</head>");



            reporte2.WriteLine("<body>");
            reporte2.WriteLine("<h2>TABLA DE ERRORES</h2>");
            //encabezados de la tabla
            reporte2.WriteLine("<table>");
            reporte2.WriteLine("<tr>");
            reporte2.WriteLine("<th>NO.</th>");
            reporte2.WriteLine("<th>LEXEMA</th>");
            reporte2.WriteLine("<th>FILA</th>");
            reporte2.WriteLine("<th>COLUMNA</th>");
            reporte2.WriteLine("<th>ERROR</th>");
            reporte2.WriteLine("</tr>");
            //cuerpo de la tabla
            reporte2.WriteLine("<tr>");

            Nodo actual;
            actual = nreporte.obtener();
            while (actual != null)
            {
                reporte2.WriteLine("<td>" + actual.simbolo.get_id() + "</td>");
                reporte2.WriteLine("<td>" + actual.simbolo.get_lexema() + "</td>");
                reporte2.WriteLine("<td>" + actual.simbolo.get_fila() + "</td>");
                reporte2.WriteLine("<td>" + actual.simbolo.get_columna() + "</td>");
                reporte2.WriteLine("<td>" + actual.simbolo.get_error() + "</td>");
                reporte2.WriteLine("</tr>");
                actual = actual.nsiguiente;
            }
            //fin de la tabla
            reporte2.WriteLine("</table>");

            reporte2.WriteLine("</body>");
            reporte2.WriteLine("</html>");
            reporte2.Close();





        }
        public void crea_reporte()
        {
            StreamWriter reporte = new StreamWriter("reporte.html");
            reporte.WriteLine("<!DOCTYPE html>");
            reporte.WriteLine("<html>");
            reporte.WriteLine("<head>");
            reporte.WriteLine("<title>Reporte_html</title>");
            //estilo
            reporte.WriteLine("<style>");
            reporte.WriteLine("table {");
            reporte.WriteLine("font-family: arial, sans-serif;");
            reporte.WriteLine("border: 1px solid #dddddd;");
            //reporte2.WriteLine("border-collapse: collapse;");
            reporte.WriteLine("width: 100%;");
            reporte.WriteLine("}");
            reporte.WriteLine("td, th {");
            reporte.WriteLine("border: 1px solid #dddddd;");
            reporte.WriteLine("text-align: left;");
            reporte.WriteLine("padding: 8px;");
            reporte.WriteLine("}");
            reporte.WriteLine("th{");
            reporte.WriteLine("background-color:#2196F3;");
            reporte.WriteLine("color: white;");
            reporte.WriteLine("}");
            reporte.WriteLine("</style>");

            reporte.WriteLine("</head>");



            reporte.WriteLine("<body>");


            reporte.WriteLine("<h2>TABLA DE SIMBOLOS</h2>");
            //encabezados de la tabla
            reporte.WriteLine("<table>");
            reporte.WriteLine("<tr>");
            reporte.WriteLine("<th>NO.</th>");
            reporte.WriteLine("<th>LEXEMA</th>");
            reporte.WriteLine("<th>TOKEN</th>");
            reporte.WriteLine("<th>FILA</th>");
            reporte.WriteLine("<th>COLUMNA</th>");
            reporte.WriteLine("<th>VALOR</th>");
            reporte.WriteLine("</tr>");
            //cuerpo de la tabla
            reporte.WriteLine("<tr>");

            Nodo actual;
            actual = nreporte.obtener();
            while (actual != null)
            {
                reporte.WriteLine("<td>" + actual.simbolo.get_id() + "</td>");
                reporte.WriteLine("<td>" + actual.simbolo.get_lexema() + "</td>");
                reporte.WriteLine("<td>" + actual.simbolo.get_token() + "</td>");
                reporte.WriteLine("<td>" + actual.simbolo.get_fila() + "</td>");
                reporte.WriteLine("<td>" + actual.simbolo.get_columna() + "</td>");
                reporte.WriteLine("<td>" + actual.simbolo.get_valor() + "</td>");
                reporte.WriteLine("</tr>");
                actual = actual.nsiguiente;


            }


            //fin de la tabla
            reporte.WriteLine("</table>");

            reporte.WriteLine("</body>");
            reporte.WriteLine("</html>");
            reporte.Close();


        }


    }
}
