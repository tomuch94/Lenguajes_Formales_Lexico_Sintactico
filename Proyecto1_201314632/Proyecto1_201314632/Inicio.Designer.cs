namespace Proyecto1_201314632
{
    partial class Inicio
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.btnjugar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cmbnombre = new System.Windows.Forms.ComboBox();
            this.cmbnivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbidioma = new System.Windows.Forms.ComboBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(28, 41);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(166, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Ingrese / o Escoja un Nickname: ";
            // 
            // btnjugar
            // 
            this.btnjugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnjugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnjugar.Location = new System.Drawing.Point(275, 232);
            this.btnjugar.Name = "btnjugar";
            this.btnjugar.Size = new System.Drawing.Size(92, 23);
            this.btnjugar.TabIndex = 4;
            this.btnjugar.Text = "Jugar";
            this.btnjugar.UseVisualStyleBackColor = true;
            this.btnjugar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(194, 38);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(173, 20);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.Visible = false;
            // 
            // cmbnombre
            // 
            this.cmbnombre.FormattingEnabled = true;
            this.cmbnombre.Location = new System.Drawing.Point(194, 38);
            this.cmbnombre.Name = "cmbnombre";
            this.cmbnombre.Size = new System.Drawing.Size(173, 21);
            this.cmbnombre.TabIndex = 1;
            // 
            // cmbnivel
            // 
            this.cmbnivel.FormattingEnabled = true;
            this.cmbnivel.Location = new System.Drawing.Point(194, 135);
            this.cmbnivel.Name = "cmbnivel";
            this.cmbnivel.Size = new System.Drawing.Size(173, 21);
            this.cmbnivel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione un Nivel: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione un Idioma: ";
            // 
            // cmbidioma
            // 
            this.cmbidioma.FormattingEnabled = true;
            this.cmbidioma.Location = new System.Drawing.Point(194, 193);
            this.cmbidioma.Name = "cmbidioma";
            this.cmbidioma.Size = new System.Drawing.Size(173, 21);
            this.cmbidioma.TabIndex = 3;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = global::Proyecto1_201314632.Properties.Resources.Boton_salir_R_N;
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Location = new System.Drawing.Point(364, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(26, 17);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button1_Click_1);
            this.btnsalir.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnsalir.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto1_201314632.Properties.Resources.form_expo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 284);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbidioma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbnivel);
            this.Controls.Add(this.cmbnombre);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnjugar);
            this.Controls.Add(this.lblnombre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Inicio_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Button btnjugar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cmbnombre;
        private System.Windows.Forms.ComboBox cmbnivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbidioma;
        private System.Windows.Forms.Button btnsalir;
    }
}