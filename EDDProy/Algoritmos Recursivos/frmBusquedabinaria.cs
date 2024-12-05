using System;
using System.Linq;
using System.Windows.Forms;
using EDDemo.Algoritmos_Recursivos.Clases;

namespace EDDemo.Algoritmos_Recursivos
{
    public partial class frmBusquedaBinaria : Form
    {
        public frmBusquedaBinaria()
        {
            InitializeComponent();
        }


        private void txtArreglo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarBinario_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener el arreglo desde el TextBox de entrada y convertirlo en un array de enteros
                int[] arreglo = txtArreglo.Text.Split(',').Select(int.Parse).ToArray();
                int clave = int.Parse(txtClave.Text); // Obtener la clave desde el TextBox de búsqueda

                // Asegurarse de que el arreglo esté ordenado antes de realizar la búsqueda binaria
                Array.Sort(arreglo);

                // Crear una instancia de la clase Recursivos para usar el método de búsqueda binaria
                Recursivos recursivos = new Recursivos();
                int resultado = recursivos.BusquedaBinaria(arreglo, 0, arreglo.Length - 1, clave);

                // Mostrar el resultado
                if (resultado != -1)
                {
                    lblResultado.Text = $"Elemento encontrado en el índice {resultado}";
                }
                else
                {
                    lblResultado.Text = "Elemento no encontrado";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese un arreglo de números válidos separados por comas y una clave válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

