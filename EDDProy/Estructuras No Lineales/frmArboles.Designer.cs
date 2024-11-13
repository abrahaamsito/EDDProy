
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.TxtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblBuscado = new System.Windows.Forms.Label();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnNodos = new System.Windows.Forms.Button();
            this.btnHojas = new System.Windows.Forms.Button();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblNodos = new System.Windows.Forms.Label();
            this.lblHojas = new System.Windows.Forms.Label();
            this.btnRecorrerPorNiveles = new System.Windows.Forms.Button();
            this.lblRecorridoPorNiveles = new System.Windows.Forms.Label();
            this.btnVerificarArbolCompleto = new System.Windows.Forms.Button();
            this.btnVerificarArbolLleno = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminarNodoSucesor = new System.Windows.Forms.Button();
            this.txtDatoEliminar = new System.Windows.Forms.TextBox();
            this.lblPredecesor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(42, 16);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(52, 26);
            this.txtDato.TabIndex = 0;
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Location = new System.Drawing.Point(6, 269);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtArbol.Size = new System.Drawing.Size(894, 205);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(498, 15);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 24);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(118, 45);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(62, 38);
            this.btnCrearArbol.TabIndex = 3;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(118, 89);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(75, 23);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Location = new System.Drawing.Point(498, 45);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(75, 23);
            this.btnGrafica.TabIndex = 5;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(118, 16);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(258, 83);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(55, 13);
            this.lblPreOrden.TabIndex = 7;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(258, 108);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(48, 13);
            this.lblInOrden.TabIndex = 8;
            this.lblInOrden.Text = "InOrden:";
            this.lblInOrden.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(258, 133);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(60, 13);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(338, 83);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoPreOrden.TabIndex = 10;
            this.lblRecorridoPreOrden.Text = "PostOrden";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(338, 108);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoInOrden.TabIndex = 11;
            this.lblRecorridoInOrden.Text = "PostOrden";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(338, 133);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoPostOrden.TabIndex = 12;
            this.lblRecorridoPostOrden.Text = "PostOrden";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(498, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(2, 21);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(33, 13);
            this.lblDatos.TabIndex = 14;
            this.lblDatos.Text = "Dato:";
            // 
            // TxtNodos
            // 
            this.TxtNodos.Location = new System.Drawing.Point(42, 56);
            this.TxtNodos.Name = "TxtNodos";
            this.TxtNodos.Size = new System.Drawing.Size(55, 20);
            this.TxtNodos.TabIndex = 15;
            // 
            // lblBuscado
            // 
            this.lblBuscado.AutoSize = true;
            this.lblBuscado.Location = new System.Drawing.Point(828, 9);
            this.lblBuscado.Name = "lblBuscado";
            this.lblBuscado.Size = new System.Drawing.Size(35, 13);
            this.lblBuscado.TabIndex = 16;
            this.lblBuscado.Text = "label1";
            this.lblBuscado.Click += new System.EventHandler(this.lblBuscado_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(604, 45);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(75, 23);
            this.btnAltura.TabIndex = 18;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnNodos
            // 
            this.btnNodos.Location = new System.Drawing.Point(604, 74);
            this.btnNodos.Name = "btnNodos";
            this.btnNodos.Size = new System.Drawing.Size(75, 23);
            this.btnNodos.TabIndex = 19;
            this.btnNodos.Text = "Nodos";
            this.btnNodos.UseVisualStyleBackColor = true;
            this.btnNodos.Click += new System.EventHandler(this.btnNodos_Click);
            // 
            // btnHojas
            // 
            this.btnHojas.Location = new System.Drawing.Point(604, 17);
            this.btnHojas.Name = "btnHojas";
            this.btnHojas.Size = new System.Drawing.Size(75, 23);
            this.btnHojas.TabIndex = 20;
            this.btnHojas.Text = "Hojas";
            this.btnHojas.UseVisualStyleBackColor = true;
            this.btnHojas.Click += new System.EventHandler(this.btnHojas_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(495, 173);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 21;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // lblNodos
            // 
            this.lblNodos.AutoSize = true;
            this.lblNodos.Location = new System.Drawing.Point(495, 197);
            this.lblNodos.Name = "lblNodos";
            this.lblNodos.Size = new System.Drawing.Size(41, 13);
            this.lblNodos.TabIndex = 22;
            this.lblNodos.Text = "Nodos:";
            // 
            // lblHojas
            // 
            this.lblHojas.AutoSize = true;
            this.lblHojas.Location = new System.Drawing.Point(497, 221);
            this.lblHojas.Name = "lblHojas";
            this.lblHojas.Size = new System.Drawing.Size(37, 13);
            this.lblHojas.TabIndex = 23;
            this.lblHojas.Text = "Hojas:";
            // 
            // btnRecorrerPorNiveles
            // 
            this.btnRecorrerPorNiveles.Location = new System.Drawing.Point(498, 108);
            this.btnRecorrerPorNiveles.Name = "btnRecorrerPorNiveles";
            this.btnRecorrerPorNiveles.Size = new System.Drawing.Size(75, 23);
            this.btnRecorrerPorNiveles.TabIndex = 24;
            this.btnRecorrerPorNiveles.Text = "Niveles";
            this.btnRecorrerPorNiveles.UseVisualStyleBackColor = true;
            this.btnRecorrerPorNiveles.Click += new System.EventHandler(this.btnRecorrerPorNiveles_Click_1);
            // 
            // lblRecorridoPorNiveles
            // 
            this.lblRecorridoPorNiveles.AutoSize = true;
            this.lblRecorridoPorNiveles.Location = new System.Drawing.Point(497, 243);
            this.lblRecorridoPorNiveles.Name = "lblRecorridoPorNiveles";
            this.lblRecorridoPorNiveles.Size = new System.Drawing.Size(45, 13);
            this.lblRecorridoPorNiveles.TabIndex = 25;
            this.lblRecorridoPorNiveles.Text = "Niveles:";
            this.lblRecorridoPorNiveles.Click += new System.EventHandler(this.lblRecorridoPorNiveles_Click);
            // 
            // btnVerificarArbolCompleto
            // 
            this.btnVerificarArbolCompleto.Location = new System.Drawing.Point(604, 108);
            this.btnVerificarArbolCompleto.Name = "btnVerificarArbolCompleto";
            this.btnVerificarArbolCompleto.Size = new System.Drawing.Size(75, 39);
            this.btnVerificarArbolCompleto.TabIndex = 26;
            this.btnVerificarArbolCompleto.Text = "Arbol Completo";
            this.btnVerificarArbolCompleto.UseVisualStyleBackColor = true;
            this.btnVerificarArbolCompleto.Click += new System.EventHandler(this.btnVerificarArbolCompleto_Click);
            // 
            // btnVerificarArbolLleno
            // 
            this.btnVerificarArbolLleno.Location = new System.Drawing.Point(706, 17);
            this.btnVerificarArbolLleno.Name = "btnVerificarArbolLleno";
            this.btnVerificarArbolLleno.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarArbolLleno.TabIndex = 27;
            this.btnVerificarArbolLleno.Text = "Arbol Lleno";
            this.btnVerificarArbolLleno.UseVisualStyleBackColor = true;
            this.btnVerificarArbolLleno.Click += new System.EventHandler(this.btnVerificarArbolLleno_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(706, 46);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Predecesor";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminarNodo_Click);
            // 
            // btnEliminarNodoSucesor
            // 
            this.btnEliminarNodoSucesor.Location = new System.Drawing.Point(706, 78);
            this.btnEliminarNodoSucesor.Name = "btnEliminarNodoSucesor";
            this.btnEliminarNodoSucesor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarNodoSucesor.TabIndex = 29;
            this.btnEliminarNodoSucesor.Text = "Sucesor";
            this.btnEliminarNodoSucesor.UseVisualStyleBackColor = true;
            this.btnEliminarNodoSucesor.Click += new System.EventHandler(this.btnEliminarNodoSucesor_Click_1);
            // 
            // txtDatoEliminar
            // 
            this.txtDatoEliminar.Location = new System.Drawing.Point(755, 133);
            this.txtDatoEliminar.Name = "txtDatoEliminar";
            this.txtDatoEliminar.Size = new System.Drawing.Size(53, 20);
            this.txtDatoEliminar.TabIndex = 30;
            // 
            // lblPredecesor
            // 
            this.lblPredecesor.AutoSize = true;
            this.lblPredecesor.Location = new System.Drawing.Point(703, 134);
            this.lblPredecesor.Name = "lblPredecesor";
            this.lblPredecesor.Size = new System.Drawing.Size(46, 13);
            this.lblPredecesor.TabIndex = 31;
            this.lblPredecesor.Text = "Eliminar:";
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 478);
            this.Controls.Add(this.lblPredecesor);
            this.Controls.Add(this.txtDatoEliminar);
            this.Controls.Add(this.btnEliminarNodoSucesor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVerificarArbolLleno);
            this.Controls.Add(this.btnVerificarArbolCompleto);
            this.Controls.Add(this.lblRecorridoPorNiveles);
            this.Controls.Add(this.btnRecorrerPorNiveles);
            this.Controls.Add(this.lblHojas);
            this.Controls.Add(this.lblNodos);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.btnHojas);
            this.Controls.Add(this.btnNodos);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.lblBuscado);
            this.Controls.Add(this.TxtNodos);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Load += new System.EventHandler(this.frmArboles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.NumericUpDown TxtNodos;
        private System.Windows.Forms.Label lblBuscado;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnNodos;
        private System.Windows.Forms.Button btnHojas;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblNodos;
        private System.Windows.Forms.Label lblHojas;
        private System.Windows.Forms.Button btnRecorrerPorNiveles;
        private System.Windows.Forms.Label lblRecorridoPorNiveles;
        private System.Windows.Forms.Button btnVerificarArbolCompleto;
        private System.Windows.Forms.Button btnVerificarArbolLleno;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarNodoSucesor;
        private System.Windows.Forms.TextBox txtDatoEliminar;
        private System.Windows.Forms.Label lblPredecesor;
    }
}