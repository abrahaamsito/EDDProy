namespace EDDemo.Algoritmos_Recursivos
{
    partial class frmTorresDeHanoi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDiscos;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.TextBox txtMovimientos;
        private System.Windows.Forms.Label lblDiscos;
        private System.Windows.Forms.Label lblMovimientos;

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
            this.txtDiscos = new System.Windows.Forms.TextBox();
            this.btnResolver = new System.Windows.Forms.Button();
            this.txtMovimientos = new System.Windows.Forms.TextBox();
            this.lblDiscos = new System.Windows.Forms.Label();
            this.lblMovimientos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDiscos
            // 
            this.txtDiscos.Location = new System.Drawing.Point(150, 30);
            this.txtDiscos.Name = "txtDiscos";
            this.txtDiscos.Size = new System.Drawing.Size(100, 20);
            this.txtDiscos.TabIndex = 0;
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(150, 60);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(100, 23);
            this.btnResolver.TabIndex = 1;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click_1);
            // 
            // txtMovimientos
            // 
            this.txtMovimientos.Location = new System.Drawing.Point(150, 100);
            this.txtMovimientos.Multiline = true;
            this.txtMovimientos.Name = "txtMovimientos";
            this.txtMovimientos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMovimientos.Size = new System.Drawing.Size(200, 200);
            this.txtMovimientos.TabIndex = 2;
            // 
            // lblDiscos
            // 
            this.lblDiscos.AutoSize = true;
            this.lblDiscos.Location = new System.Drawing.Point(50, 30);
            this.lblDiscos.Name = "lblDiscos";
            this.lblDiscos.Size = new System.Drawing.Size(95, 13);
            this.lblDiscos.TabIndex = 3;
            this.lblDiscos.Text = "Número de discos:";
            // 
            // lblMovimientos
            // 
            this.lblMovimientos.AutoSize = true;
            this.lblMovimientos.Location = new System.Drawing.Point(50, 100);
            this.lblMovimientos.Name = "lblMovimientos";
            this.lblMovimientos.Size = new System.Drawing.Size(69, 13);
            this.lblMovimientos.TabIndex = 4;
            this.lblMovimientos.Text = "Movimientos:";
            // 
            // frmTorresDeHanoi
            // 
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.lblMovimientos);
            this.Controls.Add(this.lblDiscos);
            this.Controls.Add(this.txtMovimientos);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.txtDiscos);
            this.Name = "frmTorresDeHanoi";
            this.Text = "Torres de Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
