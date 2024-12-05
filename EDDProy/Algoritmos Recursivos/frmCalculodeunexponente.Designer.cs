namespace EDDemo.Algoritmos_Recursivos
{
    partial class frmCalculodeunexponente
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtExponente = new System.Windows.Forms.TextBox();
            this.btnCalcularExponente = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(12, 29);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(260, 20);
            this.txtBase.TabIndex = 0;
            this.txtBase.Text = "";
            // 
            // txtExponente
            // 
            this.txtExponente.Location = new System.Drawing.Point(12, 73);
            this.txtExponente.Name = "txtExponente";
            this.txtExponente.Size = new System.Drawing.Size(260, 20);
            this.txtExponente.TabIndex = 1;
            this.txtExponente.Text = "";
            // 
            // btnCalcularExponente
            // 
            this.btnCalcularExponente.Location = new System.Drawing.Point(12, 99);
            this.btnCalcularExponente.Name = "btnCalcularExponente";
            this.btnCalcularExponente.Size = new System.Drawing.Size(260, 23);
            this.btnCalcularExponente.TabIndex = 2;
            this.btnCalcularExponente.Text = "Calcular Exponente";
            this.btnCalcularExponente.UseVisualStyleBackColor = true;
            this.btnCalcularExponente.Click += new System.EventHandler(this.btnCalcularExponente_Click_1);
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
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Exponente:";
            // 
            // frmCalculodeunexponente
            // 
            this.ClientSize = new System.Drawing.Size(301, 186);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcularExponente);
            this.Controls.Add(this.txtExponente);
            this.Controls.Add(this.txtBase);
            this.Name = "frmCalculodeunexponente";
            this.Text = "Cálculo de Exponente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtExponente;
        private System.Windows.Forms.Button btnCalcularExponente;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
