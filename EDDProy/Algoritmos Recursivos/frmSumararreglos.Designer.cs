namespace EDDemo.Algoritmos_Recursivos
{
    partial class frmSumarArreglos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtArreglo;
        private System.Windows.Forms.Button btnCalcularSuma;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;

        // Limpiar los recursos
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Inicializar los componentes del formulario
        private void InitializeComponent()
        {
            this.txtArreglo = new System.Windows.Forms.TextBox();
            this.btnCalcularSuma = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArreglo
            // 
            this.txtArreglo.Location = new System.Drawing.Point(237, 27);
            this.txtArreglo.Name = "txtArreglo";
            this.txtArreglo.Size = new System.Drawing.Size(150, 20);
            this.txtArreglo.TabIndex = 0;
            // 
            // btnCalcularSuma
            // 
            this.btnCalcularSuma.Location = new System.Drawing.Point(262, 53);
            this.btnCalcularSuma.Name = "btnCalcularSuma";
            this.btnCalcularSuma.Size = new System.Drawing.Size(100, 23);
            this.btnCalcularSuma.TabIndex = 1;
            this.btnCalcularSuma.Text = "Calcular Suma";
            this.btnCalcularSuma.UseVisualStyleBackColor = true;
            this.btnCalcularSuma.Click += new System.EventHandler(this.btnCalcularSuma_Click_1);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(130, 100);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(119, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "La suma del arreglo es: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese los números (separados por coma):";
            // 
            // frmSumarArreglos
            // 
            this.ClientSize = new System.Drawing.Size(471, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcularSuma);
            this.Controls.Add(this.txtArreglo);
            this.Name = "frmSumarArreglos";
            this.Text = "Suma de Arreglo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
