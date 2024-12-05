using System;
using System.Windows.Forms;
using EDDemo.Algoritmos_Recursivos.Clases; // Asegúrate de que el namespace sea correcto

namespace EDDemo.Algoritmos_Recursivos
{
    public partial class frmSumarArreglos : Form
    {
        public frmSumarArreglos()
        {
            InitializeComponent();
        }

        // Evento Click para el botón de calcular la suma del arreglo

        private void btnCalcularSuma_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Convertir la cadena de texto ingresada en el TextBox a un arreglo de enteros
                string[] input = txtArreglo.Text.Split(',');
                int[] arreglo = Array.ConvertAll(input, int.Parse);

                // Instanciar la clase Recursivos
                Recursivos recursivos = new Recursivos();

                // Calcular la suma del arreglo
                int resultado = recursivos.SumarArreglo(arreglo, 0);

                // Mostrar el resultado en el label
                lblResultado.Text = $"La suma del arreglo es: {resultado}";
            }
            catch (FormatException)
            {
                // Manejo de errores si el usuario no ingresa un número válido
                MessageBox.Show("Por favor ingrese una lista de números válidos separados por coma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

