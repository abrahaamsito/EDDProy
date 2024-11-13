using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";

            miArbol.strArbol = "";

            Random rnd = new Random();


            for (int nNodos = 1; nNodos <= TxtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = "";
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text),
                                ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString = b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);


            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRecorridoPreOrden_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmArboles_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            // Validamos que el árbol no esté vacío
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            // Convertimos el valor ingresado en la caja de texto a un entero
            int valorABuscar;
            if (int.TryParse(txtDato.Text, out valorABuscar))
            {
                // Llamamos al método de búsqueda
                if (miArbol.Busqueda(valorABuscar, miRaiz))
                {
                    lblBuscado.Text = $"El valor {valorABuscar} fue encontrado en el árbol.";
                }
                else
                {
                    lblBuscado.Text = $"El valor {valorABuscar} no se encuentra en el árbol.";
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }

        

        private void lblBuscado_Click(object sender, EventArgs e)
        {

        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            // Obtenemos el nodo Raiz del árbol
            miRaiz = miArbol.RegresaRaiz();

            // Verificamos si el árbol está vacío
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            // Llamamos al método para obtener la altura
            int altura = miArbol.ObtenerAltura();

            // Mostramos la altura en el Label
            lblAltura.Text = "Altura del árbol: " + altura.ToString();
        
    }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void btnNodos_Click(object sender, EventArgs e)
        {
                // Obtenemos el nodo raíz del árbol
                miRaiz = miArbol.RegresaRaiz();

                // Verificamos si el árbol está vacío
                if (miRaiz == null)
                {
                    MessageBox.Show("El árbol está vacío.");
                    return;
                }

                // Llamamos al método para obtener la cantidad de nodos
                int cantidadNodos = miArbol.ObtenerCantidadDeNodos();

                // Mostramos la cantidad de nodos en un Label
                lblNodos.Text = "Cantidad de nodos en el árbol: " + cantidadNodos.ToString();
            }

        private void btnHojas_Click(object sender, EventArgs e)
        {
            // Obtenemos el nodo raíz del árbol
            miRaiz = miArbol.RegresaRaiz();

            // Verificamos si el árbol está vacío
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            // Llamamos al método para obtener la cantidad de hojas
            int cantidadHojas = miArbol.ObtenerCantidadDeHojas();

            // Mostramos la cantidad de hojas en un Label
            lblHojas.Text = "Cantidad de hojas en el árbol: " + cantidadHojas.ToString();
        }

        private void btnRecorrerPorNiveles_Click(object sender, EventArgs e)
        {
            // Obtenemos el nodo raíz del árbol
            miRaiz = miArbol.RegresaRaiz();

            // Verificamos si el árbol está vacío
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            // Llamamos al método para realizar el recorrido por niveles
            miArbol.strRecorrido = "";  // Limpiamos el recorrido anterior
            miArbol.RecorridoPorNiveles(miRaiz);

            // Mostramos el recorrido en el Label o TextBox
            lblRecorridoPorNiveles.Text = "Recorrido por Niveles: " + miArbol.strRecorrido;
        }

        private void btnRecorrerPorNiveles_Click_1(object sender, EventArgs e)
        {
            this.btnRecorrerPorNiveles = new System.Windows.Forms.Button();
            this.btnRecorrerPorNiveles.Location = new System.Drawing.Point(100, 250); // Ajusta la posición
            this.btnRecorrerPorNiveles.Name = "btnRecorrerPorNiveles";
            this.btnRecorrerPorNiveles.Size = new System.Drawing.Size(150, 30);
            this.btnRecorrerPorNiveles.TabIndex = 12; // Ajusta el índice según corresponda
            this.btnRecorrerPorNiveles.Text = "Recorrer por Niveles";
            this.btnRecorrerPorNiveles.UseVisualStyleBackColor = true;
            this.btnRecorrerPorNiveles.Click += new System.EventHandler(this.btnRecorrerPorNiveles_Click);
            this.Controls.Add(this.btnRecorrerPorNiveles);
        }

        private void lblRecorridoPorNiveles_Click(object sender, EventArgs e)
        {
            this.lblRecorridoPorNiveles = new System.Windows.Forms.Label();
            this.lblRecorridoPorNiveles.AutoSize = true;
            this.lblRecorridoPorNiveles.Location = new System.Drawing.Point(300, 250); // Ajusta la posición
            this.lblRecorridoPorNiveles.Name = "lblRecorridoPorNiveles";
            this.lblRecorridoPorNiveles.Size = new System.Drawing.Size(200, 23);
            this.lblRecorridoPorNiveles.TabIndex = 13; // Ajusta el índice según corresponda
            this.lblRecorridoPorNiveles.Text = "Recorrido por Niveles:";
            this.Controls.Add(this.lblRecorridoPorNiveles);
        }

        private void btnVerificarArbolCompleto_Click(object sender, EventArgs e)
        {
            // Verificar si el árbol es completo
            bool esCompleto = miArbol.EsArbolCompleto();

            if (esCompleto)
            {
                MessageBox.Show("El árbol es completo.");
            }
            else
            {
                MessageBox.Show("El árbol NO es completo.");
            }
        }

        private void btnVerificarArbolLleno_Click(object sender, EventArgs e)
        {
            // Verificar si el árbol es binario lleno
            bool esLleno = miArbol.EsArbolLleno();

            if (esLleno)
            {
                MessageBox.Show("El árbol es binario lleno.");
            }
            else
            {
                MessageBox.Show("El árbol NO es binario lleno.");
            }
        }

        private void btnEliminarNodo_Click(object sender, EventArgs e)
        {
            // Verificar si el campo de entrada tiene un valor
            if (string.IsNullOrWhiteSpace(txtDatoEliminar.Text))
            {
                MessageBox.Show("Por favor, ingrese el valor del nodo a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el dato del nodo que se desea eliminar
            int datoAEliminar;
            if (int.TryParse(txtDatoEliminar.Text, out datoAEliminar))
            {
                // Verificar si el árbol está vacío
                if (miArbol.EstaVacio())
                {
                    MessageBox.Show("El árbol está vacío, no se puede eliminar ningún nodo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamamos al método de eliminación pasando el dato que se quiere eliminar
                miArbol.EliminarNodo(datoAEliminar);

                // Actualizar la visualización del árbol para reflejar los cambios
                miArbol.MuestraArbolAcostado(0, miArbol.RegresaRaiz());

                // Mostrar el árbol actualizado en el TextBox o en el Label
                txtArbol.Text = miArbol.strArbol;

                // Confirmar la eliminación con un mensaje
                MessageBox.Show($"Nodo con el valor {datoAEliminar} eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para eliminar el nodo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarNodoSucesor_Click_1(object sender, EventArgs e)
        {
            // Verificar si el campo de entrada tiene un valor
            if (string.IsNullOrWhiteSpace(txtDatoEliminar.Text))
            {
                MessageBox.Show("Por favor, ingrese el valor del nodo sucesor a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el dato del nodo que se desea eliminar
            int datoAEliminar;
            if (int.TryParse(txtDatoEliminar.Text, out datoAEliminar))
            {
                // Verificar si el árbol está vacío
                if (miArbol.EstaVacio())
                {
                    MessageBox.Show("El árbol está vacío, no se puede eliminar ningún nodo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamamos al método de eliminación pasando el dato que se quiere eliminar
                // Aquí eliminamos el nodo sucesor
                miArbol.EliminarNodo(datoAEliminar);

                // Actualizar la visualización del árbol para reflejar los cambios
                miArbol.MuestraArbolAcostado(0, miArbol.RegresaRaiz());

                // Mostrar el árbol actualizado en el TextBox o en el Label
                txtArbol.Text = miArbol.strArbol;

                // Confirmar la eliminación con un mensaje
                MessageBox.Show($"Nodo sucesor con el valor {datoAEliminar} eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para eliminar el nodo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
    
    
