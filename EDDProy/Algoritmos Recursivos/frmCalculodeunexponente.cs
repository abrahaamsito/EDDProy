using System;
using System.Windows.Forms;
using EDDemo.Algoritmos_Recursivos.Clases;

namespace EDDemo.Algoritmos_Recursivos
{
    public partial class frmCalculodeunexponente : Form
    {
        public frmCalculodeunexponente()
        {
            InitializeComponent();
        }

        private void btnCalcularExponente_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener la base y el exponente desde los TextBox
                int baseNumero = int.Parse(txtBase.Text);
                int exponente = int.Parse(txtExponente.Text);

                // Crear una instancia de la clase Recursivos para usar el método de calcular exponente
                Recursivos recursivos = new Recursivos();
                int resultado = recursivos.CalcularExponente(baseNumero, exponente);

                // Mostrar el resultado en el Label
                lblResultado.Text = $"Resultado: {baseNumero}^{exponente} = {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores válidos para la base y el exponente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

