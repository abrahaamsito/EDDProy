namespace EDDemo.Algoritmos_Recursivos
{
    partial class frmBusquedaBinaria
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
            this.txtArreglo = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnBuscarBinario = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArreglo
            // 
            this.txtArreglo.Location = new System.Drawing.Point(12, 29);
            this.txtArreglo.Name = "txtArreglo";
            this.txtArreglo.Size = new System.Drawing.Size(260, 20);
            this.txtArreglo.TabIndex = 0;
            this.txtArreglo.Text = "";
            this.txtArreglo.TextChanged += new System.EventHandler(this.txtArreglo_TextChanged);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(12, 73);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(260, 20);
            this.txtClave.TabIndex = 1;
            this.txtClave.Text = "";
            // 
            // btnBuscarBinario
            // 
            this.btnBuscarBinario.Location = new System.Drawing.Point(12, 99);
            this.btnBuscarBinario.Name = "btnBuscarBinario";
            this.btnBuscarBinario.Size = new System.Drawing.Size(260, 23);
            this.btnBuscarBinario.TabIndex = 2;
            this.btnBuscarBinario.Text = "Buscar Binario";
            this.btnBuscarBinario.UseVisualStyleBackColor = true;
            this.btnBuscarBinario.Click += new System.EventHandler(this.btnBuscarBinario_Click_1);
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(12, 136);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(260, 23);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese Arreglo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese Clave:";
            // 
            // frmBusquedaBinaria
            // 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnBuscarBinario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtArreglo);
            this.Name = "frmBusquedaBinaria";
            this.Text = "Búsqueda Binaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtArreglo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnBuscarBinario;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
