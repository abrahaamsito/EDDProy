namespace EDDemo
{
    partial class frmColas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.btnVerFrente = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(12, 12);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(200, 20);
            this.txtElemento.TabIndex = 0;
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(218, 10);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(75, 23);
            this.btnEncolar.TabIndex = 1;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click_1);
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Location = new System.Drawing.Point(218, 39);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(75, 23);
            this.btnDesencolar.TabIndex = 2;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click_1);
            // 
            // btnVerFrente
            // 
            this.btnVerFrente.Location = new System.Drawing.Point(218, 68);
            this.btnVerFrente.Name = "btnVerFrente";
            this.btnVerFrente.Size = new System.Drawing.Size(75, 23);
            this.btnVerFrente.TabIndex = 3;
            this.btnVerFrente.Text = "Ver Frente";
            this.btnVerFrente.UseVisualStyleBackColor = true;
            this.btnVerFrente.Click += new System.EventHandler(this.btnVerFrente_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(218, 97);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar Cola";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(12, 39);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(200, 173);
            this.lstCola.TabIndex = 5;
            this.lstCola.SelectedIndexChanged += new System.EventHandler(this.lstCola_SelectedIndexChanged);
            // 
            // frmColas
            // 
            this.ClientSize = new System.Drawing.Size(304, 221);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVerFrente);
            this.Controls.Add(this.btnDesencolar);
            this.Controls.Add(this.btnEncolar);
            this.Controls.Add(this.txtElemento);
            this.Name = "frmColas";
            this.Text = "Colas - Estructura de Datos";
            this.Load += new System.EventHandler(this.frmColas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.Button btnVerFrente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lstCola;
    }
}
