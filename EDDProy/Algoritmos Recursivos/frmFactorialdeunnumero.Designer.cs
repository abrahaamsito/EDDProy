namespace EDDemo.Algoritmos_Recursivos
{
    partial class frmFactorialdeunnumero
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCalcularFactorial = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(12, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(260, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // btnCalcularFactorial
            // 
            this.btnCalcularFactorial.Location = new System.Drawing.Point(12, 55);
            this.btnCalcularFactorial.Name = "btnCalcularFactorial";
            this.btnCalcularFactorial.Size = new System.Drawing.Size(260, 23);
            this.btnCalcularFactorial.TabIndex = 1;
            this.btnCalcularFactorial.Text = "Calcular Factorial";
            this.btnCalcularFactorial.UseVisualStyleBackColor = true;
            this.btnCalcularFactorial.Click += new System.EventHandler(this.btnCalcularFactorial_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(12, 91);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(260, 23);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número a calcular:";
            // 
            // frmFactorialdeunnumero
            // 
            this.ClientSize = new System.Drawing.Size(314, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcularFactorial);
            this.Controls.Add(this.txtNumero);
            this.Name = "frmFactorialdeunnumero";
            this.Text = "Cálculo de Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCalcularFactorial;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
    }
}
