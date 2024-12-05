namespace EDDemo.Metodos_de_busqueda_y_ordenamiento
{
    partial class frmQuicksort
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
            this.txtArreglo = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblArreglo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArreglo
            // 
            this.txtArreglo.Location = new System.Drawing.Point(190, 65);
            this.txtArreglo.Name = "txtArreglo";
            this.txtArreglo.Size = new System.Drawing.Size(152, 20);
            this.txtArreglo.TabIndex = 0;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(408, 65);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(140, 20);
            this.txtResultado.TabIndex = 1;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(214, 101);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click_1);
            // 
            // lblArreglo
            // 
            this.lblArreglo.AutoSize = true;
            this.lblArreglo.Location = new System.Drawing.Point(71, 68);
            this.lblArreglo.Name = "lblArreglo";
            this.lblArreglo.Size = new System.Drawing.Size(95, 13);
            this.lblArreglo.TabIndex = 3;
            this.lblArreglo.Text = "Ingrese un arreglo:";
            this.lblArreglo.Click += new System.EventHandler(this.lblArreglo_Click);
            // 
            // frmQuicksort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 210);
            this.Controls.Add(this.lblArreglo);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtArreglo);
            this.Name = "frmQuicksort";
            this.Text = "frmQuicksort";
            this.Load += new System.EventHandler(this.frmQuicksort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArreglo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblArreglo;
    }
}