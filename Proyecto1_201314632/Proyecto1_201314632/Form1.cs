using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto1_201314632
{
    public partial class frmprincipal : Form
    {
        char[] vcaracteres;
        public Lista tabla_simbolos = new Lista();
        public Lista tabla_errores = new Lista();
        simbolo nuevo;
        String reservada;
        reporte_html rp = new reporte_html();
        int estado = 0;
        int cont = 0;
        int fila, columna;

        //form sin bordes
        public int xClick = 0, yClick = 0;

        public frmprincipal()
        {
            InitializeComponent();
        }



        public void vaciar()
        {
            error_sintactico = false;

            tabla_errores.vacia_lista();
            cont = 0;
            tabla_simbolos.vacia_lista();
            fila = 1;
            columna = 1;
            reservada = "";
            Atributos.usuario.vacia_lista();
            Atributos.vacia_niveles();
            Atributos.musica.vacia_lista();
            Atributos.lvocabulario.vacia_lista();
            Atributos.lvjuego.vacia_lista();
            
        }
        private void btnanalizar_Click(object sender, EventArgs e)
        {
            
            vaciar();
            vcaracteres = @txtorigen.Text.ToCharArray();
            if (txtorigen.TextLength > 0)
            {
                while(cont<vcaracteres.Length){

                    valida_sintaxis(cont,vcaracteres[cont].ToString(),fila,columna);
                    if (vcaracteres[cont] == Convert.ToChar("\n"))
                    {
                        columna = 0;
                        fila++;
                    }
                    columna++;
                    cont++;

                }

                reportes();

            }
        }
        public void reportes()
        {
            //////rp.nodo(tabla_simbolos);
            //////rp.crea_reporte();

            //////rp.nodo(tabla_errores);
            //////rp.crea_reporte_error();

            if (tabla_errores.estavacio())
            {

                rp.nodo(tabla_simbolos);
                rp.crea_reporte();

                if (existe_fichero("reporte.html"))
                {
                    MessageBox.Show("Análisis Léxico Completado Correctamente.");
                    Process.Start("reporte.html");

                }
                else
                {
                    MessageBox.Show("No se ha creado una tabla de simbolos");
                }
                btnsintactico.Enabled = true;
            }
            else
            {
                rp.nodo(tabla_errores);
                rp.crea_reporte_error();
                if (existe_fichero("tabla_errores.html"))
                {
                    btnsintactico.Enabled = false;
                    btniniciar.Enabled = false;
                    MessageBox.Show("se detectaron errores léxico.");
                    Process.Start("tabla_errores.html");
                }
                else
                {
                    MessageBox.Show("No se ha creado una tabla de errores");
                }
            }
        }

        private void valida_sintaxis(int contador, String pcadena, int fila, int columna)
        {

            if (estado == 0)
            {
                if(pcadena=="/"){
                    estado = 1;
                    reservada += pcadena;
                    //REVISAR 19-03
                    if (cont + 1 == vcaracteres.Length)
                    {
                        guardar_errores(reservada, fila, columna, "Error: token incompleto.");
                        //estado = 0;
                        //cont -= 1;
                        //this.columna -= 1;

                    }
                    return;
                }
                if (pcadena == "*")
                {
                    estado = 2;
                    reservada += pcadena;
                    //REVISAR 19-03
                    if (cont + 1 == vcaracteres.Length)
                    {
                        guardar_errores(reservada, fila, columna, "Error: token incompleto.");
                        //estado = 0;
                        //cont -= 1;
                        //this.columna -= 1;

                    }
                    return;

                }
                if (Char.IsDigit(Convert.ToChar(pcadena)))
                {
                    estado = 3;
                    reservada += pcadena;
                    if (cont + 1 == vcaracteres.Length)
                    {
                        
                        generar_token(reservada, fila, columna);
                        return;

                    }
                    return;
                }
                if (Char.IsLetter(Convert.ToChar(pcadena)))
                {
                    estado = 4;
                    reservada += pcadena;
                    if (cont + 1 == vcaracteres.Length)
                    {

                        generar_token(reservada, fila, columna);
                        return;

                    }
                    return;
                }
                if (pcadena != " " &&pcadena != "\t" && pcadena != "\n" && pcadena != "=" && pcadena != "#" && pcadena != Convert.ToChar(34).ToString())
                {

                    //MessageBox.Show(txtorigen.Find(pcadena).ToString());
                    guardar_errores(pcadena, fila, columna, "Error: Token no reconocido.");
                }
            }

            if (estado == 1)
            {
                if (pcadena == "*")
                {
                    estado = 5;
                    reservada += pcadena;
                    //REVISAR 19-03
                    if (cont + 1 == vcaracteres.Length)
                    {
                        guardar_errores(reservada, fila, columna, "Error: token incompleto.");
                        //estado = 0;
                        //cont -= 1;
                        //this.columna -= 1;

                    }
                    return;
                }
                else
                {
                    estado = 0;
                    guardar_errores(reservada, fila, columna-1, "Error: se esperaba un *.");
                    cont -= 1;
                    this.columna -= 1;
                    return;
                }
            }
            if (estado == 2)
            {
                if (pcadena == "*")
                {
                    estado = 6;
                    reservada += pcadena;
                    //REVISAR 19-03
                    if (cont + 1 == vcaracteres.Length)
                    {
                        guardar_errores(reservada, fila, columna, "Error: token incompleto.");
                        //estado = 0;
                        //cont -= 1;
                        //this.columna -= 1;

                    }
                    return;
                }
                else
                {
                    estado = 0;
                    guardar_errores(reservada, fila, columna - 1, "Error: se esperaba un *.");
                    cont -= 1;
                    this.columna -= 1;
                    return;
                }
            }

            if (estado == 3)
            {
                if (Char.IsDigit(Convert.ToChar(pcadena)))
                {
                    estado = 3;
                    reservada += pcadena;
                    if (cont + 1 == vcaracteres.Length)
                    {

                        generar_token(reservada, fila, columna);
                        return;

                    }
                    return;


                }
                else if (pcadena == ".")
                {
                    estado = 7;
                    reservada += pcadena;
                    return;
                }
                else
                {

                    estado = 0;
                    columna -= 1;
                    generar_token(reservada, fila, columna);
                    cont = cont - 1;
                    this.columna -= 1;

                    return;
                }
            }

            if (estado == 4)
            {
                if (Char.IsLetter(Convert.ToChar(pcadena)) || Char.IsDigit(Convert.ToChar(pcadena)) || pcadena == "_" || pcadena == " ")
                {
                    estado = 8;
                    reservada += pcadena;
                    if (cont + 1 == vcaracteres.Length)
                    {

                        generar_token(reservada, fila, columna);
                        return;

                    }
                    return;

                }
                else if (pcadena == ":")
                {
                    estado = 9;
                    reservada += pcadena;
                    //REVISAR 19-03
                    if (cont + 1 == vcaracteres.Length)
                    {
                        guardar_errores(reservada, fila, columna, "Error: ruta incompleta.");
                        //estado = 0;
                        //cont -= 1;
                        //this.columna -= 1;

                    }
                    return;
                }
                else
                {
                    estado = 0;
                    if (pcadena == "\n")
                    {
                        columna -= 1;
                    }
                    generar_token(reservada, fila, columna - 1);
                    cont -= 1;
                    this.columna -= 1;
                    return;
                }
            }

            if (estado == 5)
            {
                if (pcadena == "*")
                {
                    estado = 10;
                    reservada += pcadena;

                }
                else
                {               
                    estado = 0;
                    guardar_errores(reservada, fila, columna-1, "Error: se esperaba un *.");
                    cont -= 1;
                    this.columna -= 1;
                    return;
                }
            }
            if (estado == 6)
            {
                if (pcadena == "/")
                {
                    estado = 11;
                    reservada += pcadena;

                }
                else
                {
                    estado = 0;
                    guardar_errores(reservada, fila, columna - 1, "Error: se esperaba un /.");
                    cont -= 1;
                    this.columna -= 1;
                    return;
                }
            }

            if (estado == 7)
            {

                if (Char.IsDigit(Convert.ToChar(pcadena)))
                {
                    estado = 12;
                }
                else
                {
                    guardar_errores(pcadena, fila, columna, "Error: se esperaba un digito.");
                    estado = 0;
                    return;
                }

            }
            if (estado == 8)
            {
                if (Char.IsLetter(Convert.ToChar(pcadena)) || Char.IsDigit(Convert.ToChar(pcadena)) || pcadena == "_" || pcadena == " ")
                {
                    estado = 8;
                    reservada += pcadena;
                    if (cont + 1 == vcaracteres.Length)
                    {

                        generar_token(reservada, fila, columna);

                    }
                    return;

                }
                else
                {
                    estado = 0;
                    generar_token(reservada, fila, columna - 1);
                    cont -= 1;
                    this.columna -= 1;
                    return;
                }
            }

            if (estado == 9)
            {
                if (pcadena == "\\")
                {
                    estado = 13;
                    reservada += pcadena;
                    //REVISAR 19-03
                    if (cont + 1 == vcaracteres.Length)
                    {
                        guardar_errores(reservada, fila, columna, "Error: ruta incompleta.");
                        //estado = 0;
                        //cont -= 1;
                        //this.columna -= 1;

                    }
                    return;
                }
                else
                {
                    guardar_errores(reservada, fila, columna-1, "Error: se esperaba un slash.");
                    estado = 0;
                    cont -= 1;
                    this.columna -= 1;
                    return;
                }
            }

            if (estado == 10)
            {
                    estado = 0;
                    generar_token(reservada, fila, columna);
                    return;   
            }
            if (estado == 11)
            {
                generar_token(reservada, fila, columna);
                estado = 0;
                return;
            }
            if (estado == 12)
            {
                if (Char.IsDigit(Convert.ToChar(pcadena)))
                {
                    estado = 12;
                    reservada += pcadena;
                    if (cont + 1 == vcaracteres.Length)
                    {
                        generar_token(reservada, fila, columna);

                    }
                    return;
                }
                else
                {
                    estado = 0;
                    generar_token(reservada, fila, columna - 1);
                    cont -= 1;
                    this.columna -= 1;
                    return;

                }
            }
            if (estado == 13)
            {
                if (Char.IsLetter(Convert.ToChar(pcadena)) || Char.IsDigit(Convert.ToChar(pcadena)) || pcadena == "_" || pcadena == " ")
                {
                    estado = 14;
                    reservada += pcadena;
                    //REVISAR 19-03
                    if (cont + 1 == vcaracteres.Length)
                    {
                        guardar_errores(reservada, fila, columna, "Error: ruta incompleta.");
                        //estado = 0;
                        //cont -= 1;
                        //this.columna -= 1;

                    }
                    return;
                }
                else
                {
                    guardar_errores(reservada, fila, columna-1, "Error: se esperaba una L,D,_.");
                    estado = 0;
                    cont -= 1;
                    this.columna -= 1;
                    return;
                }
            }

            if (estado == 14)
            {
                if (Char.IsLetter(Convert.ToChar(pcadena)) || Char.IsDigit(Convert.ToChar(pcadena)) || pcadena == "_" || pcadena == " ")
                {
                    estado = 14;
                    reservada += pcadena;

                    //REVISAR 19-03
                    if (cont + 1 == vcaracteres.Length)
                    {
                        guardar_errores(reservada, fila, columna, "Error: ruta incompleta.");
                        //estado = 0;
                        //cont -= 1;
                        //this.columna -= 1;

                    }
                    return;

                }
                else if (pcadena == ".")
                {
                    estado = 17;
                    reservada += pcadena;
                    return;

                }
                else if (pcadena == "\\")
                {
                    estado = 15;
                    reservada += pcadena;
                    return;

                }
                else
                {
                    guardar_errores(reservada, fila, columna - 1, "Error: se esperaba un L,D,_ o \\ o un punto.");
                    estado = 0;
                    cont -= 1;
                    this.columna -= 1;
                    return;
                }

            }

            if (estado == 15)
            {
                if (Char.IsLetter(Convert.ToChar(pcadena)) || Char.IsDigit(Convert.ToChar(pcadena)) || pcadena == "_" || pcadena == " ")
                {
                    estado = 16;
                    reservada += pcadena;
                    return;

                }
                else
                {
                    guardar_errores(reservada, fila, columna - 1, "Error: se esperaba una L,D,_.");
                    estado = 0;
                    cont -= 1;
                    this.columna -= 1;
                    return;
                }
            }

            if (estado == 16)
            {
                if (Char.IsLetter(Convert.ToChar(pcadena)) || Char.IsDigit(Convert.ToChar(pcadena)) || pcadena == "_" || pcadena == " ")
                {
                    estado = 16;
                    reservada += pcadena;
                    if (cont + 1 == vcaracteres.Length)
                    {

                        generar_token(reservada, fila, columna);
                        return;

                    }
                    return;

                }
                else if (pcadena == ".")
                {
                    estado = 17;
                    reservada += pcadena;
                    return;

                }
                else if (pcadena == "\\")
                {
                    estado = 15;
                    reservada += pcadena;
                    return;

                }
                else
                {
                    guardar_errores(reservada, fila, columna - 1, "Error: se esperaba un L,D,_ o \\ o un punto.");
                    estado = 0;
                    cont -= 1;
                    this.columna -= 1;
                    return;
                }

            }

            if (estado == 17)
            {
                if (Char.IsLetter(Convert.ToChar(pcadena)) || Char.IsDigit(Convert.ToChar(pcadena)) || pcadena == "_" || pcadena == " ")
                {
                    estado = 18;
                    reservada += pcadena;
                    if (cont + 1 == vcaracteres.Length)
                    {

                        generar_token(reservada, fila, columna);
                        return;

                    }
                    return;

                }
                else
                {
                    guardar_errores(reservada, fila, columna - 1, "Error: se esperaba un L,D,_.");
                    estado = 0;
                    cont -= 1;
                    this.columna -= 1;
                    return;
                }
            }

            if (estado == 18)
            {
                if (Char.IsLetter(Convert.ToChar(pcadena)) || Char.IsDigit(Convert.ToChar(pcadena)) || pcadena == "_" || pcadena == " ")
                {
                    estado = 18;
                    reservada += pcadena;
                    if (cont + 1 == vcaracteres.Length)
                    {

                        generar_token(reservada, fila, columna);
                        return;

                    }

                    return;
                }
                else
                {
                    estado = 0;
                    generar_token(reservada, fila, columna - 1);
                    cont -= 1;
                    this.columna -= 1;
                    return;
                    //this.columna -= 1;

                }
            }





            if (pcadena == "#" || pcadena == "=")
            {
                //MessageBox.Show("tag de cierre: " + pcadena);

                nuevo = new simbolo();
                nuevo.set_columna(columna);
                nuevo.set_fila(fila);
                nuevo.set_lexema(pcadena);
                //nuevo.set_token("tk_hola");
                tabla_simbolos.insertarFinal_lde(nuevo);
            }
            if (pcadena == Convert.ToChar(34).ToString())
            {
                nuevo = new simbolo();
                nuevo.set_columna(columna);
                nuevo.set_fila(fila);
                nuevo.set_lexema(pcadena);
                //nuevo.set_token("tk_hola");
                tabla_simbolos.insertarFinal_lde(nuevo);
                //return;
            }

            //if (pcadena == "/")
            //{

            //    reservada += pcadena;
            //}
            //if (pcadena == "*")
            //{
            //    reservada += pcadena;
            //}
            //if (reservada == "/**" || reservada == "**/")
            //{
            //    //MessageBox.Show("tag de apertura: " + reservada);

            //    nuevo = new simbolo();
            //    nuevo.set_columna(columna);
            //    nuevo.set_fila(fila);
            //    nuevo.set_lexema(reservada);
            //    //nuevo.set_token("tk_hola");
            //    tabla_simbolos.insertarFinal_lde(nuevo);
            //    reservada = "";
            //    return;
            //}



        }

        public void guardar_errores(String reservada,int fila, int columna, String error)
        {
            nuevo = new simbolo();
            nuevo.set_columna(columna);
            nuevo.set_fila(fila);
            nuevo.set_lexema(reservada);
            nuevo.set_error(error);
            tabla_errores.insertarFinal_lde(nuevo);
            this.reservada = "";
            estado = 0;
            return;
        }
        public void generar_token(String reservada, int fila, int columna)
        {
            nuevo = new simbolo();
            nuevo.set_columna(columna);
            nuevo.set_fila(fila);
            nuevo.set_lexema(reservada);
            tabla_simbolos.insertarFinal_lde(nuevo);
            this.reservada = "";
            estado = 0;
            return;
        }

        private Boolean existe_fichero(String ruta)
        {
            if (System.IO.File.Exists(ruta))
            {
                return true;
            }
            return false;
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdarchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(ofdarchivo.FileName);
                    txtorigen.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Revisar archivo cargado");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ofdarchivo.Filter = "Lenguajes Formales y de Programación|*.lfp";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdarchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(ofdarchivo.FileName);
                    txtorigen.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Revisar alchivo cargado");
            }
        }

        private void tablaSimbolosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (existe_fichero("reporte.html"))
            {
                Process.Start("reporte.html");
            }
            else
            {
                MessageBox.Show("No se ha creado una tabla de simbolos");
            }
        }

        private void tablaErroresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (existe_fichero("tabla_errores.html"))
            {
                Process.Start("tabla_errores.html");
            }
            else
            {
                MessageBox.Show("No se ha creado una tabla de errores");
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmacercade vacercad = new frmacercade();
            vacercad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnsintactico.Enabled = false;
            btniniciar.Enabled = false;
            Atributos.id = 10;
            Inicio j = new Inicio();
            this.Hide();
            j.ShowDialog();
            this.Show();

        }

        Nodo siguiente = new Nodo();
        String sintactico;
        int preanalisis;
        int contador = 1;
        Boolean niveles = false;
        Boolean tiempo = false;
        Boolean sonido = false;
        Boolean ahorcado = false;

        Boolean error_sintactico = false;

        private void btnsintactico_Click(object sender, EventArgs e)
        {

            S();
            if (error_sintactico)
            {
                MessageBox.Show("se detectaron errores sintacticos.");
                btniniciar.Enabled = false;

                rp.nodo(tabla_errores);
                rp.crea_reporte_error();
                if (existe_fichero("tabla_errores.html"))
                {
                    btnsintactico.Enabled = false;
                    btniniciar.Enabled = false;
                    Process.Start("tabla_errores.html");
                }
                else
                {
                    MessageBox.Show("No se ha creado una tabla de errores");
                }

            }
            else
            {
                MessageBox.Show("analisis completado");
                btniniciar.Enabled = true;
            }

        }
        public void S()
        {
            siguiente = tabla_simbolos.obtener();
            preanalisis = siguiente.simbolo.get_valor();
            E();

        }


        public void E()
        {
            
            INICIO();
            E2();

        }

        public void E2()
        {
            if (siguiente.nsiguiente == null)
            {
                return;
            }
            else{

                if (!error_sintactico)
                {
                    INICIO();
                    E2();
                }



            }



            //EPSILON

        }
        public void INICIO()
        {

            switch (preanalisis)
            {
                // /**
                case 1: //MessageBox.Show(siguiente.simbolo.get_lexema());
                    Parea(1);
                    //Configuracion
                    Parea(2);
                    L_CONT_CONF();
                        // Configuracion
                    Parea(2);
                            // **/
                    Parea(26);
                    break;

                default:

                    //MessageBox.Show("Error: "+siguiente.simbolo.get_lexema() +"se esperaba un token de apertura" + preanalisis);
                    guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: se esperaba un token de apertura /**");
                    error_sintactico = true;
                    break;
                // configuracion


            }

            
        }


        public void L_CONT_CONF()
        {
            CONT_CONF();
            L_CONT_CONF2();
        }

        public void L_CONT_CONF2()
        {
            //configuracion
            if (preanalisis == 3)
            {
                CONT_CONF();
                L_CONT_CONF2();

            }
            else
            {
                return;
            }
            //if (preanalisis == 1)
            //{
            //    //falta
            //    return;
            //}
            //else
            //{
            //    CONT_CONF();
            //    L_CONT_CONF2();
            //}
            //Epsilon
        }
        public void CONT_CONF()
        {
            switch (preanalisis)
            {
                // #
                case 3:
                    Parea(3);                  
                    SCONT_C();
                    //#
                    Parea(3);
                    break;
                default:
                    modo_panico(3);
                    guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: se esperaba un token #");
                    error_sintactico = true;
                    break;
            }
        }

        public void SCONT_C()
        {
            switch (preanalisis)
            {
                // Juego
                case 4:
                    Parea(4);
                    LCONT_JUEGO();
                    //Juego
                    Parea(4);

                    break;

                // Usuario
                case 19:
                    Parea(19);
                    LCONT_USUARIO();
                    //Usuario
                    Parea(19);
                    break;

                //Vocabulario
                case 20:
                    Parea(20);
                    LCONT_VOCABULARIO();
                    //vocabulario
                    Parea(20);
                    break;
                default:
                    guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: se esperaba un token de Juego, Usuario, Vocabulario");
                    error_sintactico = true;
                    break;
            }


        }

        public void LCONT_VOCABULARIO()
        {
            CONT_VOCABULARIO();
            LCONT_VOCABULARIO2();
        }
        public void LCONT_VOCABULARIO2()
        {
            //vocabulario
            if (preanalisis == 20)
            {
                return;
            }
            else
            {
                CONT_VOCABULARIO();
                LCONT_VOCABULARIO2();

            }

        }

        vocabulario vo;
        public void CONT_VOCABULARIO()
        {

            switch (preanalisis)
            {
                //#
                case 3:
                    vo = new vocabulario();
                Parea(3);
                //idioma
                Parea(21);
                //=
                Parea(7);
                //comillas
                Parea(8);
                //id
                vo.set_idioma(siguiente.simbolo.get_lexema());
                Parea(15);
                //comillas
                Parea(8);
                //#
                Parea(3);
                //#
                Parea(3);
                //palabra
                Parea(22);
                //=
                Parea(7);
                //comillas
                Parea(8);
                //id
                vo.set_palabra(siguiente.simbolo.get_lexema());
                Parea(15);
                //comillas
                Parea(8);
                //#
                Parea(3);
                //#
                Parea(3);
                //longitud
                Parea(23);
                //=
                Parea(7);
                //comillas
                Parea(8);
                //numero
                vo.set_longitud(Convert.ToInt16(siguiente.simbolo.get_lexema()));
                Parea(9);
                //comillas 
                Parea(8);
                //#
                Parea(3);
                //#
                Parea(3);
                //pista1
                Parea(24);
                //=
                Parea(7);
                //comillas
                Parea(8);
                //id
                vo.set_pista1(siguiente.simbolo.get_lexema());
                Parea(15);
                //comillas
                Parea(8);
                //#
                Parea(3);
                //#
                Parea(3);
                //pista2
                Parea(25);
                //=
                Parea(7);
                //comillas
                Parea(8);
                //id
                vo.set_pista2(siguiente.simbolo.get_lexema());
                Parea(15);
                //comillas
                Parea(8);
                //#
                Parea(3);
                Atributos.lvocabulario.insertarFinal_lde(vo);
                break;
                default:
                    modo_panico(3);
                    guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: se esperaba un token #");
                    error_sintactico = true;                    
                break;
            }
        }
        public void LCONT_JUEGO()
        {
            CONT_JUEGO();
            LCONT_JUEGO2();  
        }



        public void LCONT_JUEGO2()
        {
            //Juego
            if (preanalisis == 4)
            {
                return;
            }
            else
            {
                CONT_JUEGO();
                LCONT_JUEGO2();
            }
            //Epsilon

        }
        public void CONT_JUEGO()
        {
            switch (preanalisis)
            {
                // #
                case 3:
                    Parea(3);
                    SCONT_JUEGO();
                    //#
                        Parea(3);
                    break;
                default:
                    modo_panico(3);
                    guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: se esperaba un token #");
                    error_sintactico = true;
                    break;
            }

        }

        public void SCONT_JUEGO()
        {
            switch (preanalisis)
            {
                // niveles
                case 5:
                    Parea(5);
                    LCONT_NIVELES();
                    //niveles
                    Parea(5);
                    break;

                // tiempo
                case 12:
                    Parea(12);
                    LCONT_TIEMPO();
                    //tiempo
                    Parea(12);
                    break;

                // sonido
                case 13:
                    sonido = true;
                    Parea(13);
                    LCONT_SA();
                    //sonido
                        Parea(13);
                    break;

                // ahorcado
                case 18:
                    Parea(18);
                    LCONT_SA();
                    //ahorcado
                    Parea(18);
                    break;
                default:
                    guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: se esperaba un token de niveles, tiempo, sonido, ahorcado");
                    error_sintactico = true;
                    break;
            }
        }

        public void LCONT_NIVELES()
        {
            CONT_NIVELES();
            LCONT_NIVELES2();
        }

        public void LCONT_NIVELES2()
        {
            //Niveles
            if (preanalisis == 5)
            {
                return;
            }
            else
            {
                CONT_NIVELES();
                LCONT_NIVELES2();
            }
             
            //Epsilon
        }

        public void CONT_NIVELES()
        {
            switch (preanalisis)
            {
                // #
                case 3:
                    niveles = true;
                    Parea(3);
                    SCONT_NT();
                    // #
                        Parea(3);
                    break;
                default:
                    modo_panico(3);
                    guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: se esperaba un token #");
                    error_sintactico = true;
                    break;
            }
        }


        public void LCONT_TIEMPO()
        {
            CONT_TIEMPO();
            LCONT_TIEMPO2();

        }

        public void LCONT_TIEMPO2()
        {
            if (preanalisis == 12)
            {
                return;
            }
            else{
                CONT_TIEMPO();
                LCONT_TIEMPO2();
            }

        }

        public void CONT_TIEMPO()
        {
            switch (preanalisis)
            {
                    //#
                case 3: Parea(3);
                    tiempo = true;
                    SCONT_NT();
                    // #
                        Parea(3);
                    break;
                default:
                    modo_panico(3);
                    guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: se esperaba un token #");
                    error_sintactico = true;
                    break;
            }
        }
        public void SCONT_NT()
        {
            switch (preanalisis)
            {
                // Facil
                case 6:
                    Parea(6);
                    fid(6);   
                    break;

                // intermedio
                case 10:
                    Parea(10);
                    fid(10);   
                    break;

                // Dificil
                case 11:
                    Parea(11);
                    fid(11);    
                    break;
                default:
                    guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: se esperaba un token Facil, Intermedio, Dificil");
                    error_sintactico = true;
                    break;

            }
        }

        public void fid(int nivel)
        {
            // =
                Parea(7);
                // comilla
                    Parea(8);
                    //numero
                        if (niveles == true)
                        {
                            if (nivel == 6)
                            {
                                Atributos.niveles[0, 0] = 6;
                                Atributos.niveles[0, 1] = Convert.ToDecimal(siguiente.simbolo.get_lexema());
                                niveles = false;
                            }
                            if (nivel == 10)
                            {
                                Atributos.niveles[1, 0] = 10;
                                Atributos.niveles[1, 1] = Convert.ToDecimal(siguiente.simbolo.get_lexema());
                                niveles = false;
                            }
                            if (nivel == 11)
                            {
                                Atributos.niveles[2, 0] = 11;
                                Atributos.niveles[2, 1] = Convert.ToDecimal(siguiente.simbolo.get_lexema());
                                niveles = false;
                            }
                        }


                        if (tiempo == true)
                        {
                            if (nivel == 6)
                            {
                                Atributos.niveles[0, 2] = Convert.ToDecimal(siguiente.simbolo.get_lexema());
                                tiempo = false;
                            }
                            if (nivel == 10)
                            {
                                Atributos.niveles[1, 2] = Convert.ToDecimal(siguiente.simbolo.get_lexema());
                                tiempo = false;
                            }
                            if (nivel == 11)
                            {
                                Atributos.niveles[2, 2] = Convert.ToDecimal(siguiente.simbolo.get_lexema());
                                tiempo = false;
                            }

                        }


                        Parea(9);
                        // comilla
                            Parea(8);
        }


        public void LCONT_SA()
        {
            switch (preanalisis)
            {
                //#
                case 3: Parea(3);
                    SCONT_SA();
                    // #
                        Parea(3);
                    break;
                default:
                    modo_panico(3);
                    guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: se esperaba un token #");
                    error_sintactico = true;
                    break;
            }
        }

        musica_cancion media;
        public void SCONT_SA()
        {
            media = new musica_cancion();
            switch (preanalisis)
            {
                    //nombre
                case 14: Parea(14);
                    //=
                    Parea(7);
                    // comillas
                    Parea(8);
                    //id
                    media.setnombre(siguiente.simbolo.get_lexema());
                    Parea(15);
                    //comillas
                    Parea(8);
                    // #
                    Parea(3);
                    //#
                    Parea(3);
                    //ruta
                    Parea(16);
                    // =
                    Parea(7);
                    //comilla
                    Parea(8);
                    //id   CAMBIAR DESPUES POR RUTA

                        media.seturl(siguiente.simbolo.get_lexema());




                    Parea(15);
                    //comilla
                    if (sonido == true)
                    {
                        if (existe_fichero(siguiente.simbolo.get_lexema()))
                        {
                        //MessageBox.Show(media.geturl());
                        Atributos.musica.insertarFinal_lde(media);
                        sonido = false;
                    }
                    else
                    {
                        guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: la ruta no existe");
                        error_sintactico = true;

                    }

                    }

                    Parea(8);
                    break;
                //ruta
                case 16: Parea(16);
                    //=
                    Parea(7);
                    // comillas
                    Parea(8);
                    //id
                    media.seturl(siguiente.simbolo.get_lexema());
                    Parea(15);
                    //comillas
                    Parea(8);
                    // #
                    Parea(3);
                    //#
                    Parea(3);
                    //nombre
                    Parea(14);
                    // =
                    Parea(7);
                    //comilla
                    Parea(8);
                    //id

                    media.setnombre(siguiente.simbolo.get_lexema());
                    Parea(15);
                    //comilla
                    if (sonido == true)
                    {
                                                if (existe_fichero(siguiente.simbolo.get_lexema()))
                        {
                    //MessageBox.Show(media.geturl());
                    Atributos.musica.insertarFinal_lde(media);
                    sonido = false;
                        }
                                                else
                                                {
                                                    guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: la ruta no existe");
                                                    error_sintactico = true;

                                                }
                    }
                    Parea(8);
                     
                    break;
                default:
                    guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: se esperaba un token nombre,ruta");
                    error_sintactico = true;
                    break;
            }

        }


        public void LCONT_USUARIO() {

            CONT_USUARIO();
            LCONT_USUARIO2();

        }
        public void LCONT_USUARIO2() 
        {
            //usuario
            if (preanalisis == 19)
            {
                return;
            }
            else
            {
                CONT_USUARIO();
                LCONT_USUARIO2();
            }
            

        }

        public void CONT_USUARIO()
        {
            switch (preanalisis)
            {
                //#
                case 3:
                    Parea(3);
                    //nombre
                    Parea(14);
                    //=
                    Parea(7);
                    //comilla
                    Parea(8);
                    //id
                    Atributos.usuario.insertarFinal_lde(siguiente.simbolo.get_lexema());
                    Parea(15);
                    //comilla
                    Parea(8);
                    //#
                    Parea(3);

                    break;
                default:
                    modo_panico(3);
                    guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: se esperaba un token #");
                    error_sintactico = true;
                    break;
            }
        }

        public void Parea(int terminal)
        {

            //if(preanalisis==0){


            //}
            //else
            //{
                if (preanalisis == terminal)
                {
                    //MessageBox.Show("token"+siguiente.simbolo.get_lexema());

                    //////preanalisis = gettoken();
                    if (siguiente.nsiguiente != null)
                    {
                        preanalisis = gettoken();
                        //MessageBox.Show(siguiente.simbolo.get_lexema());

                    }

                }else
                {
                    guardar_errores(siguiente.simbolo.get_lexema(), siguiente.simbolo.get_fila(), siguiente.simbolo.get_columna(), "Error: no viene el token esperado");

                    //MessageBox.Show(preanalisis +"ERROR"+siguiente.simbolo.get_lexema() + siguiente.simbolo.get_fila() + "terminal " + terminal);
                    error_sintactico = true;
                }
            //}

        }

        public void modo_panico(int terminal)
        {
            if (terminal==preanalisis)
            {
                return;
            }
            else
            {
                siguiente = siguiente.nsiguiente;
                preanalisis = siguiente.simbolo.get_valor();
                modo_panico(terminal);
            }

        }
        
        public int gettoken()
        {


             siguiente = siguiente.nsiguiente;

            return siguiente.simbolo.get_valor();
            ////////if(siguiente.nsiguiente!=null)
            ////////{ 
            ////////    siguiente = siguiente.nsiguiente;
            ////////    return siguiente.simbolo.get_valor();
            ////////    //MessageBox.Show(siguiente.simbolo.get_lexema());
            ////////}

            ////////return siguiente.simbolo.get_valor();
        }



        private void btnsalir_MouseLeave(object sender, EventArgs e)
        {
            btnsalir.BackgroundImage = Properties.Resources.Boton_salir_R_N;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalir_MouseEnter(object sender, EventArgs e)
        {
            btnsalir.BackgroundImage = Properties.Resources.botn_salir;
        }

        private void frmprincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)

            { xClick = e.X; yClick = e.Y; }

            else

            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }





    }
}
