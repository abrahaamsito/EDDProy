using System;
using System.Windows.Forms;
using EDDemo;  // Asegúrate de que el namespace sea correcto, donde está la clase Pilas

namespace EDDemo
{
    public partial class frmPilas : Form
    {
        private Pilas pila;  // Instancia de la clase Pilas

        public frmPilas()
        {
            InitializeComponent();
            pila = new Pilas();  // Inicializamos la pila
        }

        // Evento Click para el botón Push
        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el valor desde el TextBox
                int valor = int.Parse(txtValor.Text);

                // Realizar la operación Push
                pila.Push(valor);

                // Mostrar el estado actual de la pila
                MostrarPila();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento Click para el botón Pop
        private void btnPop_Click(object sender, EventArgs e)
        {
            try
            {
                // Realizar la operación Pop y mostrar el valor eliminado
                int valor = pila.Pop();

                // Mostrar el valor eliminado
                MessageBox.Show($"Elemento eliminado: {valor}", "Pop", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mostrar el estado actual de la pila
                MostrarPila();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("La pila está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento Click para el botón Peek
        private void btnPeek_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el valor del tope de la pila sin eliminarlo
                int valor = pila.Peek();

                // Mostrar el valor del tope
                MessageBox.Show($"Elemento en el tope: {valor}", "Peek", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("La pila está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para mostrar el estado actual de la pila en el ListBox
        private void MostrarPila()
        {
            // Limpiar el ListBox
            lstPila.Items.Clear();

            // Verificar si la pila está vacía
            if (pila.EstaVacia())
            {
                lstPila.Items.Add("La pila está vacía.");
            }
            else
            {
                // Mostrar los elementos de la pila
                NodoPila actual = pila.Tope; // Necesitamos acceso a la propiedad 'Tope' o modificar la clase Pilas para exponerla.
                while (actual != null)
                {
                    lstPila.Items.Add(actual.Valor); // Añadimos el valor del nodo actual
                    actual = actual.Sig;  // Moverse al siguiente nodo
                }
            }
        }

        private void frmPilas_Load(object sender, EventArgs e)
        {

        }
    }
}

