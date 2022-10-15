namespace Proyecto1_201314632
{
    partial class frmprincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprincipal));
            this.btnanalizar = new System.Windows.Forms.Button();
            this.txtorigen = new System.Windows.Forms.RichTextBox();
            this.btncargar = new System.Windows.Forms.Button();
            this.ofdarchivo = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaSimbolosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaErroresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btniniciar = new System.Windows.Forms.Button();
            this.btnsintactico = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnanalizar
            // 
            this.btnanalizar.BackColor = System.Drawing.Color.LightGray;
            this.btnanalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnanalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanalizar.Location = new System.Drawing.Point(467, 174);
            this.btnanalizar.Name = "btnanalizar";
            this.btnanalizar.Size = new System.Drawing.Size(142, 32);
            this.btnanalizar.TabIndex = 0;
            this.btnanalizar.Text = "Analizar Lexicamente";
            this.btnanalizar.UseVisualStyleBackColor = false;
            this.btnanalizar.Click += new System.EventHandler(this.btnanalizar_Click);
            // 
            // txtorigen
            // 
            this.txtorigen.Location = new System.Drawing.Point(20, 81);
            this.txtorigen.Name = "txtorigen";
            this.txtorigen.Size = new System.Drawing.Size(424, 449);
            this.txtorigen.TabIndex = 1;
            this.txtorigen.Text = "";
            // 
            // btncargar
            // 
            this.btncargar.BackColor = System.Drawing.Color.LightGray;
            this.btncargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargar.Location = new System.Drawing.Point(467, 135);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(142, 32);
            this.btncargar.TabIndex = 13;
            this.btncargar.Text = "Cargar";
            this.btncargar.UseVisualStyleBackColor = false;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // ofdarchivo
            // 
            this.ofdarchivo.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(14, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(186, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaSimbolosToolStripMenuItem,
            this.tablaErroresToolStripMenuItem});
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // tablaSimbolosToolStripMenuItem
            // 
            this.tablaSimbolosToolStripMenuItem.Name = "tablaSimbolosToolStripMenuItem";
            this.tablaSimbolosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.tablaSimbolosToolStripMenuItem.Text = "Tabla_Simbolos";
            this.tablaSimbolosToolStripMenuItem.Click += new System.EventHandler(this.tablaSimbolosToolStripMenuItem_Click);
            // 
            // tablaErroresToolStripMenuItem
            // 
            this.tablaErroresToolStripMenuItem.Name = "tablaErroresToolStripMenuItem";
            this.tablaErroresToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.tablaErroresToolStripMenuItem.Text = "Tabla_Errores";
            this.tablaErroresToolStripMenuItem.Click += new System.EventHandler(this.tablaErroresToolStripMenuItem_Click);
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.LightGray;
            this.btniniciar.Enabled = false;
            this.btniniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.Location = new System.Drawing.Point(467, 257);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(142, 32);
            this.btniniciar.TabIndex = 15;
            this.btniniciar.Text = "Iniciar Juego";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsintactico
            // 
            this.btnsintactico.BackColor = System.Drawing.Color.LightGray;
            this.btnsintactico.Enabled = false;
            this.btnsintactico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnsintactico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsintactico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsintactico.Location = new System.Drawing.Point(467, 216);
            this.btnsintactico.Name = "btnsintactico";
            this.btnsintactico.Size = new System.Drawing.Size(142, 32);
            this.btnsintactico.TabIndex = 16;
            this.btnsintactico.Text = "Análisis Sintactico";
            this.btnsintactico.UseVisualStyleBackColor = false;
            this.btnsintactico.Click += new System.EventHandler(this.btnsintactico_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.BackgroundImage = global::Proyecto1_201314632.Properties.Resources.Boton_salir_R_N;
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Location = new System.Drawing.Point(588, 10);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(36, 29);
            this.btnsalir.TabIndex = 17;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            this.btnsalir.MouseEnter += new System.EventHandler(this.btnsalir_MouseEnter);
            this.btnsalir.MouseLeave += new System.EventHandler(this.btnsalir_MouseLeave);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1_201314632.Properties.Resources.form_expo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 552);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnsintactico);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.txtorigen);
            this.Controls.Add(this.btnanalizar);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmprincipal_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnanalizar;
        private System.Windows.Forms.RichTextBox txtorigen;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.OpenFileDialog ofdarchivo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaSimbolosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaErroresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Button btnsintactico;
        private System.Windows.Forms.Button btnsalir;
    }
}

