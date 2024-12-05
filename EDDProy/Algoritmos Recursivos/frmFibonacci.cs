using System;
using System.Windows.Forms;
using EDDemo.Algoritmos_Recursivos.Clases; // Asegúrate de que el namespace sea correcto

namespace EDDemo.Algoritmos_Recursivos
{
    public partial class frmFibonacci : Form
    {
        public frmFibonacci()
        {
            InitializeComponent();
        }

        // Evento Click para el botón de calcular Fibonacci

        private void btnCalcularFibonacci_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener el número ingresado por el usuario
                int n = int.Parse(txtNumero.Text);

                // Instanciar la clase Recursivos
                Recursivos recursivos = new Recursivos();

                // Calcular el número de Fibonacci
                int resultado = recursivos.CalcularFibonacci(n);

                // Mostrar el resultado en el label
                lblResultado.Text = $"Fibonacci({n}) = {resultado}";
            }
            catch (FormatException)
            {
                // Manejo de errores si el usuario no ingresa un número válido
                MessageBox.Show("Por favor ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

