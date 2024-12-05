using System;
using System.Linq;
using System.Windows.Forms;
using EDDemo.Metodos_de_busqueda_y_ordenamiento.Clasess;

namespace EDDemo.Metodos_de_busqueda_y_ordenamiento
{
    public partial class frmBusqueda : Form
    {
        public frmBusqueda()
        {
            InitializeComponent();
        }

        // Evento Load del formulario
        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            // Inicializar el ComboBox con las opciones de búsqueda
            cmbTipoBusqueda.Items.Add("Secuencial");
            cmbTipoBusqueda.Items.Add("Binaria");
            cmbTipoBusqueda.Items.Add("Hashing");
            cmbTipoBusqueda.SelectedIndex = 0;  // Seleccionar por defecto "Secuencial"
        }

        // Evento Click del botón para realizar la 

        private void cmbTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener el texto ingresado en los TextBoxes
                string inputArreglo = txtArreglo.Text.Trim();
                string inputObjetivo = txtObjetivo.Text.Trim();

                // Verificar si los campos no están vacíos
                if (string.IsNullOrWhiteSpace(inputArreglo) || string.IsNullOrWhiteSpace(inputObjetivo))
                {
                    MessageBox.Show("Por favor ingrese un arreglo de números y un objetivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convertir el texto ingresado en un arreglo de enteros
                int[] arreglo = inputArreglo.Split(',').Select(int.Parse).ToArray();
                int objetivo = int.Parse(inputObjetivo);

                // Instanciar la clase Busqueda
                Busqueda busqueda = new Busqueda();
                int resultado = -1;

                // Realizar la búsqueda según el tipo seleccionado en el ComboBox
                if (cmbTipoBusqueda.SelectedItem.ToString() == "Secuencial")
                {
                    resultado = busqueda.BuscarSecuencial(arreglo, objetivo);
                }
                else if (cmbTipoBusqueda.SelectedItem.ToString() == "Binaria")
                {
                    resultado = busqueda.BuscarBinaria(arreglo, objetivo);
                }
                else if (cmbTipoBusqueda.SelectedItem.ToString() == "Hashing")
                {
                    bool encontrado = busqueda.BuscarHashing(arreglo, objetivo);
                    txtResultado.Text = encontrado ? "Objetivo encontrado." : "Objetivo no encontrado.";
                    return;
                }

                // Mostrar el resultado de la búsqueda (índice o mensaje)
                if (resultado == -1)
                {
                    txtResultado.Text = "Objetivo no encontrado.";
                }
                else
                {
                    txtResultado.Text = $"Objetivo encontrado en el índice {resultado}.";
                }
            }
            catch (FormatException)
            {
                // Si ocurre un error de formato (por ejemplo, si no se ingresan solo números)
                MessageBox.Show("Por favor ingrese solo números válidos separados por comas.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Si ocurre cualquier otro error
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

