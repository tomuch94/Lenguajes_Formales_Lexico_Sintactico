using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_201314632
{
    public partial class Juego : Form
    {
        int tiempo;




        //para textbox dinamicos
        ctxt a;
        int x = 10;
        int y = 30;
        int id = 0;
        Label[] prueba;
        int hola = 0;
        String str2;
        String str;
        String letras = "";
        int ganaste = 0;
        int cperdiste = 0;
        //fin

        public Juego()
        {
            InitializeComponent();
        }

        public void setparametros(String nombre, String idioma, String nivel,decimal tiempo, int longitud)
        {

            lblpista1.Text = Atributos.lvjuego.primero.vocabulario.get_pista1();
            lblpista2.Text = Atributos.lvjuego.primero.vocabulario.get_pista2();

            txtnombre.Text = nombre;
            txtidioma.Text = idioma;
            txtnivel.Text = nivel;
            txttiempo.Text = tiempo.ToString();
            if (tiempo == 0)
            {
                this.tiempo = 70;
            }
            else
            {
                this.tiempo = Convert.ToInt16(tiempo);
            }
            timer1.Start();

            crea_txt(longitud);


        }

        private void setvalue(String valor, String letra)
        {
            int cont = 0;
            while (cont < prueba.Length)
            {
                if (prueba[cont].Text != null)
                {
                    if (prueba[cont].Name == valor)
                    {
                        prueba[cont].Text = letra;
                    }
                }

                cont++;

            }
        }
        public void vacia_vecto_txt()
        {
            lblpista1.Text = "";
            lblpista2.Text = "";


            lblinfo.Text = "";


            txtbuscar.Text = "";
            int c = 0;
            while (c < hola)
            {
                prueba[c].Dispose();
                c++;
            }
            id = 0;
            x = 10;
            y = 30;
            lblletras.Text = "";
            letras = "";



        }
        public void crea_txt(int longitud)
        {
            hola = longitud;

            prueba = new Label[hola];
            int ab = 0;
            while (ab < hola)
            {
                if (id < hola)
                {
                    a = new ctxt("txtv" + id);
                    a.Font = new Font("Arial", 28);
                    a.AutoSize = false;
                    a.SetBounds(x, y, 50, 55);
                    a.TextAlign= ContentAlignment.MiddleCenter;
                    a.ForeColor = Color.White;
                    a.Image = Proyecto1_201314632.Properties.Resources.base3;

                    x += 50;


                    prueba[id] = a;

                    this.panel1.Controls.Add(prueba[id]);
                    id++;

                }
                ab++;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            str2 = Atributos.lvjuego.obtener().vocabulario.get_palabra().ToLower();
            str = Atributos.lvjuego.obtener().vocabulario.get_palabra().ToLower();


            int c=0;
            int index =0;
            if (!letras.Contains(txtbuscar.Text.ToLower()))
            {
                //label1.Text = letras;
                while (c < str2.Length)
                {
                    int p = str2.Substring(0, c).Length;
                    index = str.IndexOf(txtbuscar.Text.ToLower());
                    //MessageBox.Show(index.ToString() + " " + p.ToString());
                    if (index >= 0)
                    {

                        setvalue("txtv" + Convert.ToInt16(index + p), txtbuscar.Text.ToLower());
                        str = str.Remove(index, 1);
                        ganaste++;

                        lblinfo.Text = "Letra Correcta";


                    }

                    c++;
                }


                if (ganaste == Atributos.lvjuego.obtener().vocabulario.get_palabra().Length)
                {
                    //MessageBox.Show("ganaste");
                    ganaste = 0;
                    this.letras = "";
                    lblletras.Text = "";
                    
                    if (Atributos.lvjuego.primero.nsiguiente != null)
                    {
                        MessageBox.Show("Siguiente Palabra");
                        vacia_vecto_txt();
                        Atributos.lvjuego.primero = Atributos.lvjuego.primero.nsiguiente;
                        //vacia_vecto_txt();
                        crea_txt(Atributos.lvjuego.primero.vocabulario.get_longitud());


                        lblpista1.Text = Atributos.lvjuego.primero.vocabulario.get_pista1();
                        lblpista2.Text = Atributos.lvjuego.primero.vocabulario.get_pista2();
                    }
                    else
                    {

                        timer1.Stop();
                        MessageBox.Show("GANASTE!!!");
                        wmpmusica.Ctlcontrols.stop();
                        vacia_vecto_txt();
                        this.Dispose();
                     
                    }

                }

               
                    letras = letras.ToLower() + txtbuscar.Text.ToLower() + ", ";

                if (!str2.Contains(txtbuscar.Text.ToLower()))
                {
                    lblinfo.Text = "Letra Incorrecta";
                    cperdiste++;
                    switch (cperdiste)
                    {
                        case 1:
                            pbcabeza.Visible = true;
                            break;
                        case 2:
                            pbtronco.Visible = true;
                            break;
                        case 3:
                            pbbrazos.Visible = true;
                            break;
                        case 4:

                            pbpiernas.Visible = true;
                            timer1.Stop();
                            Atributos.lvjuego.vacia_lista();
                            MessageBox.Show("HAS PERDIDO!!!");

                            timer1.Stop();
                            wmpmusica.Ctlcontrols.stop();
                            this.Close();
                            break;
                    }

                    //letras = letras.ToLower() + txtbuscar.Text.ToLower() + ", ";

                }
                //else
                //{

                //    MessageBox.Show("letra ya ingresada: ");
                //}
            }
            else
            {
                lblinfo.Text = "Letra Repetida!!!";
            }

            lblletras.Text = letras;
            txtbuscar.Text = "";
            txtbuscar.Focus();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempo >= 0)
            {
                txttiempo.Text = ""+tiempo;
                tiempo--;

            }
            else
            {

                timer1.Stop();
                wmpmusica.Ctlcontrols.stop();
                MessageBox.Show("HAS PEDIDO!!!");
                Atributos.lvjuego.vacia_lista();
                this.Close();
            }
        }


        private void Juego_Load(object sender, EventArgs e)
        {

            
            //musica = Atributos.musica;
            musica_nodo actual;
            actual = Atributos.musica.obtener();
            while (actual != null)
            {
                //MessageBox.Show("Id: " +actual.simbolo.get_id() + "\nLexema: " +actual.simbolo.get_lexema() + "\nToken: " + actual.simbolo.get_token());
                wmpmusica.currentPlaylist.appendItem(wmpmusica.newMedia(actual.cancion.geturl()));
                actual = actual.nsiguiente;
            }


            //wmpmusica.currentPlaylist.appendItem(wmpmusica.newMedia(@"C:\EL CLUBO\el clubo - hoy te pido perdon master_2.mp3"));

            //Reproducir la lista de REProduccion (Desde el inicio, primer archivo)
            wmpmusica.Ctlcontrols.play();
            txtsonido.Text = Atributos.musica.buscar(wmpmusica.currentMedia.sourceURL);
        }

        musica_lista musica = new musica_lista();
        private void button2_Click(object sender, EventArgs e)
        {

            //wmpmusica.URL= "C:\\EL CLUBO\\el clubo - hoy te pido perdon master_2.mp3";
            //wmpmusica.URL="C:\\EL CLUBO\\El Clubo - Como Estaras.mp3";
            //wmpmusica.Ctlcontrols.play();


            //string[] ArchivosMP3 = Directory.GetFiles(@"D:\Music\DIVISION MINUSCULA", "*.mp3");

            //foreach (string Archivo in ArchivosMP3)
            //{

            //    //listBox1.Items.Add(Archivo);
            //    wmpmusica.currentPlaylist.appendItem(wmpmusica.newMedia(Archivo));

            //}

            ////Reproducir la lista de REProduccion (Desde el inicio, primer archivo)
            //wmpmusica.Ctlcontrols.play();
            //txtsonido.Text= wmpmusica.currentMedia.name;
            musica_cancion prueba = new musica_cancion();
            prueba.setnombre("hola");
            prueba.seturl(@"C:\EL CLUBO\el clubo - hoy te pido perdon master_2.mp3");
            musica.insertarFinal_lde(prueba);

            musica_nodo actual;
            actual = musica.primero;
            while (actual != null)
                {
                        //MessageBox.Show("Id: " +actual.simbolo.get_id() + "\nLexema: " +actual.simbolo.get_lexema() + "\nToken: " + actual.simbolo.get_token());
                        wmpmusica.currentPlaylist.appendItem(wmpmusica.newMedia(actual.cancion.geturl()));
                        actual = actual.nsiguiente;
                }


            //wmpmusica.currentPlaylist.appendItem(wmpmusica.newMedia(@"C:\EL CLUBO\el clubo - hoy te pido perdon master_2.mp3"));
          
            //Reproducir la lista de REProduccion (Desde el inicio, primer archivo)
            wmpmusica.Ctlcontrols.play();
            txtsonido.Text = musica.buscar(wmpmusica.currentMedia.sourceURL);


        }

        private void wmpmusica_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            //txtsonido.Text = wmpmusica.currentMedia.name;
            txtsonido.Text = Atributos.musica.buscar(wmpmusica.currentMedia.sourceURL);
        }

        private void Juego_FormClosing(object sender, FormClosingEventArgs e)
        {
            wmpmusica.Dispose();
            vacia_vecto_txt();
            this.Dispose();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            btnbuscar.Focus();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnsalir.Image = Properties.Resources.botn_salir;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnsalir.Image = Properties.Resources.Boton_salir_R_N;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            wmpmusica.Dispose();
            vacia_vecto_txt();
            this.Dispose();
        }

        public int xClick = 0, yClick = 0;
        private void Juego_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)

            { xClick = e.X; yClick = e.Y; }

            else

            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }

        }




    }
}
