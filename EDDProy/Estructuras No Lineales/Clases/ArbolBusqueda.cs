using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                // CAMBIO 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }

        public bool Busqueda(int Dato, NodoBinario nodo)
        {
            if (nodo == null)
                return false;

            if (Dato < nodo.Dato)
                return Busqueda(Dato, nodo.Izq);
            else if (Dato > nodo.Dato)
                return Busqueda(Dato, nodo.Der);
            else
                return true;
        }

        private int ObtenerAlturaRecursiva(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0; // Un árbol vacío tiene altura 0
            }

            // Calcular la altura de los subárboles izquierdo y derecho
            int alturaIzquierda = ObtenerAlturaRecursiva(nodo.Izq);
            int alturaDerecha = ObtenerAlturaRecursiva(nodo.Der);

            // Retornar la altura máxima de los subárboles + 1
            return Math.Max(alturaIzquierda, alturaDerecha) + 1;
        }

        public int ObtenerAltura()
        {
            return ObtenerAlturaRecursiva(Raiz);
        }

        private int ContarNodos(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0;
            }

            int nodosIzquierda = ContarNodos(nodo.Izq);
            int nodosDerecha = ContarNodos(nodo.Der);

            return nodosIzquierda + nodosDerecha + 1;
        }

        // Método público para contar los nodos
        public int ContarTotalNodos()
        {
            return ContarNodos(Raiz);
        }

        public int ObtenerCantidadDeNodos()
        {
            return ContarNodos(Raiz);
        }

        private int ContarHojasRecursivo(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0;
            }

            // Si el nodo no tiene hijos (es una hoja), contamos 1
            if (nodo.Izq == null && nodo.Der == null)
            {
                return 1;
            }

            // De lo contrario, contamos las hojas en el subárbol izquierdo y derecho
            int hojasIzquierda = ContarHojasRecursivo(nodo.Izq);
            int hojasDerecha = ContarHojasRecursivo(nodo.Der);

            return hojasIzquierda + hojasDerecha;
        }

        // Método público para contar las hojas
        public int ObtenerCantidadDeHojas()
        {
            return ContarHojasRecursivo(Raiz);
        }

        public void RecorridoPorNiveles(NodoBinario nodo)
        {
            if (nodo == null)
            {
                strRecorrido = "El árbol está vacío.";
                return;
            }

            // Creamos una cola para almacenar los nodos por nivel
            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(nodo);

            // Mientras haya nodos en la cola
            while (cola.Count > 0)
            {
                // Sacamos el primer nodo de la cola
                NodoBinario nodoActual = cola.Dequeue();

                // Procesamos el nodo (agregamos su valor al recorrido)
                strRecorrido += nodoActual.Dato + ", ";

                // Si tiene hijo izquierdo, lo agregamos a la cola
                if (nodoActual.Izq != null)
                {
                    cola.Enqueue(nodoActual.Izq);
                }

                // Si tiene hijo derecho, lo agregamos a la cola
                if (nodoActual.Der != null)
                {
                    cola.Enqueue(nodoActual.Der);
                }
            }

            // Quitamos la última coma y espacio extra
            if (strRecorrido.Length > 0)
            {
                strRecorrido = strRecorrido.TrimEnd(new char[] { ',', ' ' });
            }
        }

        public bool EsArbolBinarioCompleto(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return true; // Un árbol vacío es completo por definición
            }

            // Usamos una cola para recorrer el árbol por niveles
            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(nodo);

            bool flag = false; // Indicará si hemos encontrado un nodo sin hijos

            while (cola.Count > 0)
            {
                NodoBinario nodoActual = cola.Dequeue();

                // Si ya hemos encontrado un nodo sin hijos, significa que
                // los siguientes nodos deben ser hojas (sin hijos)
                if (nodoActual.Izq == null && nodoActual.Der == null)
                {
                    flag = true;
                }
                else
                {
                    // Si un nodo tiene hijos después de un nodo sin hijos,
                    // entonces no es un árbol binario completo
                    if (flag)
                    {
                        return false;
                    }

                    // Si tiene hijo izquierdo, lo agregamos a la cola
                    if (nodoActual.Izq != null)
                    {
                        cola.Enqueue(nodoActual.Izq);
                    }

                    // Si tiene hijo derecho, lo agregamos a la cola
                    if (nodoActual.Der != null)
                    {
                        cola.Enqueue(nodoActual.Der);
                    }
                }
            }

            // Si hemos recorrido todo el árbol sin violar la condición, es completo
            return true;
        }

        public bool EsArbolCompleto()
        {
            return EsArbolBinarioCompleto(Raiz);
        }

        public bool EsArbolBinarioLleno(NodoBinario nodo)
        {
            // Si el nodo es null, no es necesario hacer nada
            if (nodo == null)
            {
                return true;
            }

            // Si el nodo es una hoja (sin hijos), es un nodo lleno por definición
            if (nodo.Izq == null && nodo.Der == null)
            {
                return true;
            }

            // Si el nodo tiene exactamente dos hijos, seguimos verificando
            if (nodo.Izq != null && nodo.Der != null)
            {
                return EsArbolBinarioLleno(nodo.Izq) && EsArbolBinarioLleno(nodo.Der);
            }

            // Si el nodo tiene exactamente un hijo, no es un árbol binario lleno
            return false;
        }

        // Método público para verificar si el árbol completo es lleno
        public bool EsArbolLleno()
        {
            return EsArbolBinarioLleno(Raiz);
        }

        public void EliminarNodo(int dato)
        {
            Raiz = EliminarNodoRecursivo(Raiz, dato);
        }

        // Método recursivo para eliminar un nodo
        private NodoBinario EliminarNodoRecursivo(NodoBinario nodo, int dato)
        {
            if (nodo == null)
            {
                return null; // Si el nodo es null, no hay nada que eliminar
            }

            // Si el dato a eliminar es menor que el dato del nodo actual, buscamos en el subárbol izquierdo
            if (dato < nodo.Dato)
            {
                nodo.Izq = EliminarNodoRecursivo(nodo.Izq, dato);
            }
            // Si el dato a eliminar es mayor que el dato del nodo actual, buscamos en el subárbol derecho
            else if (dato > nodo.Dato)
            {
                nodo.Der = EliminarNodoRecursivo(nodo.Der, dato);
            }
            // Si encontramos el nodo que queremos eliminar
            else
            {
                // Caso 1: El nodo no tiene hijos (es una hoja)
                if (nodo.Izq == null && nodo.Der == null)
                {
                    return null; // Simplemente eliminamos el nodo
                }
                // Caso 2: El nodo tiene un solo hijo
                else if (nodo.Izq == null)
                {
                    return nodo.Der; // Reemplazamos el nodo con su hijo derecho
                }
                else if (nodo.Der == null)
                {
                    return nodo.Izq; // Reemplazamos el nodo con su hijo izquierdo
                }
                // Caso 3: El nodo tiene dos hijos
                else
                {
                    // Encontramos el predecesor (el nodo más grande en el subárbol izquierdo)
                    NodoBinario predecesor = ObtenerMaximo(nodo.Izq);

                    // Reemplazamos el valor del nodo actual con el valor del predecesor
                    nodo.Dato = predecesor.Dato;

                    // Eliminamos el predecesor del subárbol izquierdo
                    nodo.Izq = EliminarNodoRecursivo(nodo.Izq, predecesor.Dato);
                }
            }

            return nodo; // Devolvemos el nodo modificado
        }

        // Método auxiliar para obtener el nodo con el valor máximo en el subárbol izquierdo
        private NodoBinario ObtenerMaximo(NodoBinario nodo)
        {
            while (nodo.Der != null)
            {
                nodo = nodo.Der;
            }
            return nodo; // Devolvemos el nodo más grande
        }

        public void EliminarNodoConSucesor(int dato)
        {
            Raiz = EliminarNodoConSucesorRecursivo(Raiz, dato);
        }

        private NodoBinario EliminarNodoConSucesorRecursivo(NodoBinario nodo, int dato)
        {
            if (nodo == null)
            {
                return null; // Si el nodo es null, no hay nada que eliminar
            }

            // Si el dato a eliminar es menor que el dato del nodo actual, buscamos en el subárbol izquierdo
            if (dato < nodo.Dato)
            {
                nodo.Izq = EliminarNodoConSucesorRecursivo(nodo.Izq, dato);
            }
            // Si el dato a eliminar es mayor que el dato del nodo actual, buscamos en el subárbol derecho
            else if (dato > nodo.Dato)
            {
                nodo.Der = EliminarNodoConSucesorRecursivo(nodo.Der, dato);
            }
            // Si encontramos el nodo que queremos eliminar
            else
            {
                // Caso 1: El nodo no tiene hijos (es una hoja)
                if (nodo.Izq == null && nodo.Der == null)
                {
                    return null; // Simplemente eliminamos el nodo
                }
                // Caso 2: El nodo tiene un solo hijo
                else if (nodo.Izq == null)
                {
                    return nodo.Der; // Reemplazamos el nodo con su hijo derecho
                }
                else if (nodo.Der == null)
                {
                    return nodo.Izq; // Reemplazamos el nodo con su hijo izquierdo
                }
                // Caso 3: El nodo tiene dos hijos
                else
                {
                    // Encontramos el sucesor (el nodo más pequeño en el subárbol derecho)
                    NodoBinario sucesor = ObtenerMinimo(nodo.Der);

                    // Reemplazamos el valor del nodo actual con el valor del sucesor
                    nodo.Dato = sucesor.Dato;

                    // Eliminamos el sucesor del subárbol derecho
                    nodo.Der = EliminarNodoConSucesorRecursivo(nodo.Der, sucesor.Dato);
                }
            }

            return nodo; // Devolvemos el nodo modificado
        }

        // Método auxiliar para obtener el nodo con el valor mínimo en el subárbol derecho
        private NodoBinario ObtenerMinimo(NodoBinario nodo)
        {
            while (nodo.Izq != null)
            {
                nodo = nodo.Izq;
            }
            return nodo; // Devolvemos el nodo más pequeño
        }
    }

}

