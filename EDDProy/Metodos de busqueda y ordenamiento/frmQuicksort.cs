using System;
using System.Linq;
using System.Windows.Forms;
using EDDemo.Metodos_de_busqueda_y_ordenamiento.Clasess;

namespace EDDemo.Metodos_de_busqueda_y_ordenamiento
{
    public partial class frmQuicksort : Form
    {
        public frmQuicksort()
        {
            InitializeComponent();
        }

        // Evento Load del formulario
        private void frmQuicksort_Load(object sender, EventArgs e)
        {
            // Opcional: Puedes colocar código aquí para inicializar el formulario si es necesario
        }

        // Método que se ejecuta cuando el usuario hace clic en el botón para ordenar

        private void lblArreglo_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener el texto ingresado en el TextBox
                string input = txtArreglo.Text.Trim();

                // Verificar si el campo no está vacío
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Por favor ingrese un arreglo de números separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convertir el texto ingresado en un arreglo de enteros
                string[] elementos = input.Split(',');
                int[] arreglo = elementos.Select(int.Parse).ToArray();

                // Instanciar la clase Ordenamiento
                Ordenamiento ordenamiento = new Ordenamiento();

                // Llamar al método OrdenarQuickSort
                ordenamiento.OrdenarQuickSort(arreglo, 0, arreglo.Length - 1);

                // Mostrar el arreglo ordenado en el TextBox de resultados
                txtResultado.Text = string.Join(", ", arreglo);
            }
            catch (Exception ex)
            {
                // Si ocurre algún error (por ejemplo, si el usuario no ingresa números válidos), mostrar un mensaje de error
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


