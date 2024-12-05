using System;
using System.Windows.Forms;
using EDDemo.Algoritmos_Recursivos.Clases;

namespace EDDemo.Algoritmos_Recursivos
{
    public partial class frmFactorialdeunnumero : Form
    {
        public frmFactorialdeunnumero()
        {
            InitializeComponent();
        }

        private void btnCalcularFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el número desde el TextBox
                int numero = int.Parse(txtNumero.Text);

                // Crear una instancia de la clase Recursivos para usar el método de calcular factorial
                Recursivos recursivos = new Recursivos();
                int resultado = recursivos.CalcularFactorial(numero);

                // Mostrar el resultado en el Label
                lblResultado.Text = $"El factorial de {numero} es {resultado}.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
