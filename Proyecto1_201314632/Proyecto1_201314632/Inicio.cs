using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_201314632
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        Atributos atr = new Atributos();
        private void button1_Click(object sender, EventArgs e)
        {
            //quitarlo

            if (cmbnombre.Text.Trim().Length > 0)
            { 

           
            Juego j = new Juego();
            decimal tiempo = 0;
            int palabra = 0;

            int longitud = 0;


            if (cmbnivel.Text == "Facil")
            {

                tiempo = Atributos.niveles[0, 2];
                palabra = Atributos.lvocabulario.buscar(cmbidioma.Text, Convert.ToInt16(Atributos.niveles[0, 1]));

                //MessageBox.Show(palabra.ToString());
                longitud = Convert.ToInt16(Atributos.niveles[0, 1]);

            }
            if (cmbnivel.Text == "Intermedio")
            {
                tiempo = Atributos.niveles[1, 2];
                //Atributos.lvocabulario.buscar(Convert.ToInt16(Atributos.niveles[1, 1]));
               palabra = Atributos.lvocabulario.buscar(cmbidioma.Text,Convert.ToInt16(Atributos.niveles[1, 1]));
               longitud = Convert.ToInt16(Atributos.niveles[1, 1]);
            }
            if (cmbnivel.Text == "Dificil")
            {
                tiempo = Atributos.niveles[2, 2];
                //Atributos.lvocabulario.buscar(Convert.ToInt16(Atributos.niveles[2, 1]));
                palabra = Atributos.lvocabulario.buscar(cmbidioma.Text, Convert.ToInt16(Atributos.niveles[2, 1]));
                longitud = Convert.ToInt16(Atributos.niveles[2, 1]);
            }
            if (palabra != 0)
            {
                MessageBox.Show("Coincidencias con los criterios de busqueda: " + palabra);
                //MessageBox.Show("Longitud "+ longitud);
                this.Hide();
                j.setparametros(cmbnombre.Text, cmbidioma.Text, cmbnivel.Text, tiempo,longitud);
                j.ShowDialog();
                this.Show();
                txtnombre.Text = "";
            }
            else
            {
                MessageBox.Show("NO HAY PALABRAS CON ESOS CRITERIOS DE BUSQUEDA");
            }
            }
            else
            {
                MessageBox.Show("Debe Ingresar almenos un nick");
                cmbnombre.Text = "";
            }
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            usuario_nodo llenau = Atributos.usuario.obtener();
            vocabulario_nodo llenaidoma = Atributos.lvocabulario.obtener();
            while (llenau != null)
            {
                cmbnombre.Items.Add(llenau.nombre);
                llenau = llenau.nsiguiente;
            }
            while (llenaidoma != null)
            {
                int a = cmbidioma.FindString(llenaidoma.vocabulario.get_idioma());
                if (a < 0)
                {
                    //MessageBox.Show(a.ToString());
                    cmbidioma.Items.Add(llenaidoma.vocabulario.get_idioma());
                }

                llenaidoma = llenaidoma.nsiguiente;
            }

            //cmbnombre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbnivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbidioma.DropDownStyle = ComboBoxStyle.DropDownList;


            for (int fila = 0; fila < 3;fila++)
            {
                if (Atributos.niveles[fila, 0] != 0)
                {
                    if (Atributos.niveles[fila, 0] == 6)
                    {
                        cmbnivel.Items.Add("Facil");
                    }
                    if (Atributos.niveles[fila, 0] == 10)
                    {
                        cmbnivel.Items.Add("Intermedio");
                    }
                    if (Atributos.niveles[fila, 0] == 11)
                    {
                        cmbnivel.Items.Add("Dificil");
                    }

                }
            }

        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Atributos.usuario.vacia_lista();
            //Atributos.musica.vacia_lista();
            //Atributos.vacia_niveles();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnsalir.BackgroundImage = Properties.Resources.botn_salir;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnsalir.BackgroundImage = Properties.Resources.Boton_salir_R_N;
        }
        public int xClick = 0, yClick = 0;
        private void Inicio_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)

            { xClick = e.X; yClick = e.Y; }

            else

            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
