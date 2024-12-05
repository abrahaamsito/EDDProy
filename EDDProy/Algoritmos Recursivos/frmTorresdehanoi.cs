using System;
using System.Windows.Forms;
using EDDemo.Algoritmos_Recursivos.Clases; // Asegúrate de que el namespace sea correcto

namespace EDDemo.Algoritmos_Recursivos
{
    public partial class frmTorresDeHanoi : Form
    {
        public frmTorresDeHanoi()
        {
            InitializeComponent();
        }

        // Evento Click para el botón de calcular la solución de las Torres de Hanoi

        // Método para mostrar el movimiento en el TextBox
        private void MostrarMovimiento(string origen, string destino, int disco)
        {
            // Agregar el movimiento al TextBox
            txtMovimientos.AppendText($"Mover disco {disco} desde {origen} hacia {destino}{Environment.NewLine}");
        }

        private void btnResolver_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener la cantidad de discos ingresada por el usuario
                int numDiscos = int.Parse(txtDiscos.Text);

                // Verificar que el número de discos sea positivo
                if (numDiscos <= 0)
                {
                    MessageBox.Show("Por favor ingrese un número mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Instanciar la clase Recursivos
                Recursivos recursivos = new Recursivos();

                // Limpiar el TextBox antes de mostrar los nuevos movimientos
                txtMovimientos.Clear();

                // Resolver las Torres de Hanoi y mostrar los movimientos
                recursivos.TorresDeHanoi(numDiscos, "A", "C", "B", MostrarMovimiento);
            }
            catch (FormatException)
            {
                // Manejo de error si el usuario no ingresa un número válido
                MessageBox.Show("Por favor ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}




