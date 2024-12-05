namespace EDDemo.Algoritmos_Recursivos
{
    partial class frmFibonacci
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCalcularFibonacci;
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCalcularFibonacci = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(130, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // btnCalcularFibonacci
            // 
            this.btnCalcularFibonacci.Location = new System.Drawing.Point(130, 60);
            this.btnCalcularFibonacci.Name = "btnCalcularFibonacci";
            this.btnCalcularFibonacci.Size = new System.Drawing.Size(100, 23);
            this.btnCalcularFibonacci.TabIndex = 1;
            this.btnCalcularFibonacci.Text = "Calcular Fibonacci";
            this.btnCalcularFibonacci.UseVisualStyleBackColor = true;
            this.btnCalcularFibonacci.Click += new System.EventHandler(this.btnCalcularFibonacci_Click_1);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(130, 100);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(61, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese un valor:";
            // 
            // frmFibonacci
            // 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcularFibonacci);
            this.Controls.Add(this.txtNumero);
            this.Name = "frmFibonacci";
            this.Text = "Cálculo de Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
