using System.Windows.Forms;

namespace EDDemo
{
    partial class frmPilas
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtValor;
        private Button btnPush;
        private Button btnPop;
        private Button btnPeek;
        private ListBox lstPila;

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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 12);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 0;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(12, 38);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(100, 23);
            this.btnPush.TabIndex = 1;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(12, 67);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(100, 23);
            this.btnPop.TabIndex = 2;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(12, 96);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(100, 23);
            this.btnPeek.TabIndex = 3;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(118, 12);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(120, 95);
            this.lstPila.TabIndex = 4;
            // 
            // frmPilas
            // 
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.lstPila);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtValor);
            this.Name = "frmPilas";
            this.Text = "Gestión de Pilas";
            this.Load += new System.EventHandler(this.frmPilas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
