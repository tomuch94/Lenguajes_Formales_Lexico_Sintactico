namespace Proyecto1_201314632
{
    partial class Juego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtnivel = new System.Windows.Forms.TextBox();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidioma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsonido = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblletras = new System.Windows.Forms.Label();
            this.lblletras2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wmpmusica = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbtronco = new System.Windows.Forms.PictureBox();
            this.pbpiernas = new System.Windows.Forms.PictureBox();
            this.pbbrazos = new System.Windows.Forms.PictureBox();
            this.pbcabeza = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblpista1 = new System.Windows.Forms.Label();
            this.lblpista2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpmusica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtronco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpiernas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbrazos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcabeza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(98, 341);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(68, 27);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nickname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nivel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tiempo:";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(57, 109);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(159, 23);
            this.txtnombre.TabIndex = 9;
            // 
            // txtnivel
            // 
            this.txtnivel.BackColor = System.Drawing.Color.White;
            this.txtnivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnivel.Location = new System.Drawing.Point(57, 167);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.ReadOnly = true;
            this.txtnivel.Size = new System.Drawing.Size(159, 23);
            this.txtnivel.TabIndex = 10;
            // 
            // txttiempo
            // 
            this.txttiempo.BackColor = System.Drawing.Color.White;
            this.txttiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttiempo.Location = new System.Drawing.Point(73, 227);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.ReadOnly = true;
            this.txttiempo.Size = new System.Drawing.Size(50, 23);
            this.txttiempo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(259, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Idioma:";
            // 
            // txtidioma
            // 
            this.txtidioma.BackColor = System.Drawing.Color.White;
            this.txtidioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidioma.Location = new System.Drawing.Point(262, 109);
            this.txtidioma.Name = "txtidioma";
            this.txtidioma.ReadOnly = true;
            this.txtidioma.Size = new System.Drawing.Size(100, 23);
            this.txtidioma.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(70, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingrese Letra:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(167, 298);
            this.txtbuscar.MaxLength = 1;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(68, 23);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sonido reproduciendo";
            // 
            // txtsonido
            // 
            this.txtsonido.BackColor = System.Drawing.Color.White;
            this.txtsonido.Location = new System.Drawing.Point(38, 483);
            this.txtsonido.Name = "txtsonido";
            this.txtsonido.ReadOnly = true;
            this.txtsonido.Size = new System.Drawing.Size(178, 20);
            this.txtsonido.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblletras);
            this.panel1.Controls.Add(this.lblletras2);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(281, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 94);
            this.panel1.TabIndex = 34;
            // 
            // lblletras
            // 
            this.lblletras.AutoSize = true;
            this.lblletras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblletras.Location = new System.Drawing.Point(174, 5);
            this.lblletras.Name = "lblletras";
            this.lblletras.Size = new System.Drawing.Size(0, 25);
            this.lblletras.TabIndex = 1;
            // 
            // lblletras2
            // 
            this.lblletras2.AutoSize = true;
            this.lblletras2.BackColor = System.Drawing.Color.Transparent;
            this.lblletras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblletras2.ForeColor = System.Drawing.Color.White;
            this.lblletras2.Location = new System.Drawing.Point(3, 5);
            this.lblletras2.Name = "lblletras2";
            this.lblletras2.Size = new System.Drawing.Size(174, 25);
            this.lblletras2.TabIndex = 0;
            this.lblletras2.Text = "Letras Ingresadas:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wmpmusica
            // 
            this.wmpmusica.Enabled = true;
            this.wmpmusica.Location = new System.Drawing.Point(38, 409);
            this.wmpmusica.Name = "wmpmusica";
            this.wmpmusica.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpmusica.OcxState")));
            this.wmpmusica.Size = new System.Drawing.Size(218, 44);
            this.wmpmusica.TabIndex = 35;
            this.wmpmusica.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.wmpmusica_CurrentItemChange);
            // 
            // pbtronco
            // 
            this.pbtronco.BackColor = System.Drawing.Color.Transparent;
            this.pbtronco.Image = ((System.Drawing.Image)(resources.GetObject("pbtronco.Image")));
            this.pbtronco.Location = new System.Drawing.Point(683, 195);
            this.pbtronco.Name = "pbtronco";
            this.pbtronco.Size = new System.Drawing.Size(12, 96);
            this.pbtronco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtronco.TabIndex = 2;
            this.pbtronco.TabStop = false;
            this.pbtronco.Visible = false;
            // 
            // pbpiernas
            // 
            this.pbpiernas.BackColor = System.Drawing.Color.Transparent;
            this.pbpiernas.Image = ((System.Drawing.Image)(resources.GetObject("pbpiernas.Image")));
            this.pbpiernas.Location = new System.Drawing.Point(635, 288);
            this.pbpiernas.Name = "pbpiernas";
            this.pbpiernas.Size = new System.Drawing.Size(108, 53);
            this.pbpiernas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpiernas.TabIndex = 4;
            this.pbpiernas.TabStop = false;
            this.pbpiernas.Visible = false;
            // 
            // pbbrazos
            // 
            this.pbbrazos.BackColor = System.Drawing.Color.Transparent;
            this.pbbrazos.Image = ((System.Drawing.Image)(resources.GetObject("pbbrazos.Image")));
            this.pbbrazos.Location = new System.Drawing.Point(635, 198);
            this.pbbrazos.Name = "pbbrazos";
            this.pbbrazos.Size = new System.Drawing.Size(108, 58);
            this.pbbrazos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbrazos.TabIndex = 3;
            this.pbbrazos.TabStop = false;
            this.pbbrazos.Visible = false;
            // 
            // pbcabeza
            // 
            this.pbcabeza.BackColor = System.Drawing.Color.Transparent;
            this.pbcabeza.Image = ((System.Drawing.Image)(resources.GetObject("pbcabeza.Image")));
            this.pbcabeza.Location = new System.Drawing.Point(655, 123);
            this.pbcabeza.Name = "pbcabeza";
            this.pbcabeza.Size = new System.Drawing.Size(65, 64);
            this.pbcabeza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcabeza.TabIndex = 1;
            this.pbcabeza.TabStop = false;
            this.pbcabeza.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(434, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.ForeColor = System.Drawing.Color.White;
            this.lblinfo.Location = new System.Drawing.Point(252, 301);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(0, 17);
            this.lblinfo.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Pista1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Pista2";
            // 
            // lblpista1
            // 
            this.lblpista1.AutoSize = true;
            this.lblpista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpista1.ForeColor = System.Drawing.Color.White;
            this.lblpista1.Location = new System.Drawing.Point(9, 49);
            this.lblpista1.Name = "lblpista1";
            this.lblpista1.Size = new System.Drawing.Size(60, 17);
            this.lblpista1.TabIndex = 39;
            this.lblpista1.Text = "lblpista1";
            // 
            // lblpista2
            // 
            this.lblpista2.AutoSize = true;
            this.lblpista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpista2.ForeColor = System.Drawing.Color.White;
            this.lblpista2.Location = new System.Drawing.Point(9, 124);
            this.lblpista2.Name = "lblpista2";
            this.lblpista2.Size = new System.Drawing.Size(60, 17);
            this.lblpista2.TabIndex = 40;
            this.lblpista2.Text = "lblpista1";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblpista2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblpista1);
            this.panel2.Location = new System.Drawing.Point(794, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 182);
            this.panel2.TabIndex = 41;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = global::Proyecto1_201314632.Properties.Resources.Boton_salir_R_N;
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Location = new System.Drawing.Point(899, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(69, 38);
            this.btnsalir.TabIndex = 42;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            this.btnsalir.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnsalir.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1_201314632.Properties.Resources.form_expo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 534);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.wmpmusica);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsonido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtidioma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttiempo);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.pbtronco);
            this.Controls.Add(this.pbpiernas);
            this.Controls.Add(this.pbbrazos);
            this.Controls.Add(this.pbcabeza);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Juego_FormClosing);
            this.Load += new System.EventHandler(this.Juego_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Juego_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpmusica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtronco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpiernas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbrazos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcabeza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbcabeza;
        private System.Windows.Forms.PictureBox pbtronco;
        private System.Windows.Forms.PictureBox pbbrazos;
        private System.Windows.Forms.PictureBox pbpiernas;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtnivel;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidioma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsonido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer wmpmusica;
        private System.Windows.Forms.Label lblletras2;
        private System.Windows.Forms.Label lblletras;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblpista1;
        private System.Windows.Forms.Label lblpista2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsalir;
    }
}