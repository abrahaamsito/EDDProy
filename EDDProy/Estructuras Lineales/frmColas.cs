using System;
using System.Windows.Forms;
using EDDemo.Estructuras_de_Datos; // Asegúrate de que el namespace sea correcto

namespace EDDemo
{
    public partial class frmColas : Form
    {
        private Cola<string> cola; // Creamos una cola de tipo string

        public frmColas()
        {
            InitializeComponent();
            cola = new Cola<string>(); // Inicializamos la cola
        }

        // Método que actualiza la lista de elementos en la interfaz
        private void ActualizarLista()
        {
            lstCola.Items.Clear(); // Limpiamos la lista en la interfaz
            foreach (var item in cola.ObtenerElementos()) // Obtenemos los elementos de la cola
            {
                lstCola.Items.Add(item); // Añadimos los elementos a la lista
            }
        }


        private void frmColas_Load(object sender, EventArgs e)
        {

        }

        private void btnVerFrente_Click_1(object sender, EventArgs e)
        {
            try
            {
                string item = cola.ObtenerFrente(); // Obtenemos el frente de la cola
                MessageBox.Show($"Elemento en el frente: {item}", "Frente de la Cola", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("La cola está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            cola.Limpiar(); // Limpiamos la cola
            ActualizarLista(); // Actualizamos la interfaz
        }

        private void btnDesencolar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string item = cola.Desencolar(); // Desencolamos un elemento
                MessageBox.Show($"Elemento desencolado: {item}", "Desencolar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarLista(); // Actualizamos la interfaz
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("La cola está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncolar_Click_1(object sender, EventArgs e)
        {
            string item = txtElemento.Text; // Obtenemos el texto del TextBox
            if (!string.IsNullOrEmpty(item)) // Verificamos si el texto no está vacío
            {
                cola.Encolar(item); // Encolamos el elemento
                ActualizarLista(); // Actualizamos la interfaz
                txtElemento.Clear(); // Limpiamos el TextBox
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor para encolar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstCola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

