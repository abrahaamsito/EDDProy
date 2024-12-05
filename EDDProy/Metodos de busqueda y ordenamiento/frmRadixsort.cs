﻿using System;
using System.Linq;
using System.Windows.Forms;
using EDDemo.Metodos_de_busqueda_y_ordenamiento.Clasess;

namespace EDDemo.Metodos_de_busqueda_y_ordenamiento
{
    public partial class frmRadixsort : Form
    {
        public frmRadixsort()
        {
            InitializeComponent();
        }

        // Evento Load del formulario
        private void frmRadixsort_Load(object sender, EventArgs e)
        {
            // Opcional: Puedes colocar código aquí para inicializar el formulario si es necesario
        }

        // Método que se ejecuta cuando el usuario hace clic en el botón para ordenar
        private void btnOrdenar_Click(object sender, EventArgs e)
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

                // Llamar al método OrdenarRadixSort
                ordenamiento.OrdenarRadixSort(arreglo);

                // Mostrar el arreglo ordenado en el TextBox de resultados
                txtResultado.Text = string.Join(", ", arreglo);
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

        private void txtResultado_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
