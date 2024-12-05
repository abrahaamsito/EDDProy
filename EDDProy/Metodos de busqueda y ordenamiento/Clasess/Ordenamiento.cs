using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_busqueda_y_ordenamiento.Clasess
{
    internal class Ordenamiento
    {
        // Método de Ordenamiento Rápido (QuickSort)
        public void OrdenarQuickSort(int[] arreglo, int inicio, int fin)
        {
            if (inicio < fin)
            {
                // Encuentra el índice del pivote, tal que los elementos menores estén a la izquierda
                // y los elementos mayores estén a la derecha del pivote.
                int pivote = Particionar(arreglo, inicio, fin);

                // Ordena recursivamente los subarreglos a la izquierda y a la derecha del pivote.
                OrdenarQuickSort(arreglo, inicio, pivote - 1); // Llamada recursiva para la izquierda
                OrdenarQuickSort(arreglo, pivote + 1, fin); // Llamada recursiva para la derecha
            }
        }

        // Método que realiza la partición del arreglo en torno a un pivote
        private int Particionar(int[] arreglo, int inicio, int fin)
        {
            // Elegimos el último elemento como pivote
            int pivote = arreglo[fin];
            int i = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                // Si el elemento actual es menor o igual que el pivote, lo movemos a la izquierda
                if (arreglo[j] <= pivote)
                {
                    i++;
                    // Intercambiar los elementos en las posiciones i y j
                    int temp = arreglo[i];
                    arreglo[i] = arreglo[j];
                    arreglo[j] = temp;
                }
            }

            // Colocamos el pivote en su posición final, entre los elementos menores y mayores
            int temp2 = arreglo[i + 1];
            arreglo[i + 1] = arreglo[fin];
            arreglo[fin] = temp2;

            return i + 1; // Retorna el índice del pivote
        }
        public void OrdenarShellSort(int[] arreglo)
        {
            int n = arreglo.Length;

            // Comenzamos con un "gap" (distancia entre elementos a comparar)
            // Normalmente el gap comienza como la mitad del tamaño del arreglo y se reduce.
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Realizamos una ordenación por inserción usando el "gap" actual
                for (int i = gap; i < n; i++)
                {
                    int temp = arreglo[i];
                    int j = i;

                    // Realizamos la comparación e intercambio de elementos
                    // desplazando los elementos a la derecha si son mayores que temp
                    while (j >= gap && arreglo[j - gap] > temp)
                    {
                        arreglo[j] = arreglo[j - gap];
                        j -= gap;
                    }

                    // Colocamos el elemento en su lugar correcto
                    arreglo[j] = temp;
                }
            }
        }
        public void OrdenarRadixSort(int[] arreglo)
        {
            // Encontrar el valor máximo en el arreglo para determinar la cantidad de dígitos
            int max = arreglo.Max();

            // Realizamos el conteo por cada lugar decimal (unidades, decenas, centenas, etc.)
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                // Llamamos a la función para ordenar según el dígito en la posición 'exp'
                ContarSort(arreglo, exp);
            }
        }

        // Función auxiliar para realizar el conteo de elementos según el dígito en el lugar 'exp'
        private void ContarSort(int[] arreglo, int exp)
        {
            int n = arreglo.Length;
            int[] salida = new int[n];  // Arreglo para almacenar los números ordenados
            int[] conteo = new int[10];  // Arreglo para contar las ocurrencias de cada dígito (0-9)

            // Contar la ocurrencia de cada dígito en el lugar 'exp'
            for (int i = 0; i < n; i++)
            {
                int digito = (arreglo[i] / exp) % 10;
                conteo[digito]++;
            }

            // Convertir el arreglo de conteo a índices de posición
            for (int i = 1; i < 10; i++)
            {
                conteo[i] += conteo[i - 1];
            }

            // Construir el arreglo de salida utilizando el arreglo de conteo
            for (int i = n - 1; i >= 0; i--)
            {
                int digito = (arreglo[i] / exp) % 10;
                salida[conteo[digito] - 1] = arreglo[i];
                conteo[digito]--;
            }

            // Copiar el arreglo de salida al arreglo original
            for (int i = 0; i < n; i++)
            {
                arreglo[i] = salida[i];
            }
        }
        public void OrdenarBurbuja(int[] arreglo)
        {
            int n = arreglo.Length;
            bool intercambio;

            // Bucle para pasar a través de todos los elementos
            for (int i = 0; i < n - 1; i++)
            {
                intercambio = false;

                // Comparar cada par de elementos adyacentes
                for (int j = 0; j < n - 1 - i; j++)
                {
                    // Si el elemento actual es mayor que el siguiente, los intercambiamos
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;

                        // Marcar que se realizó un intercambio
                        intercambio = true;
                    }
                }

                // Si no hubo intercambios, el arreglo ya está ordenado
                if (!intercambio)
                    break;
            }
        }
    }
}
    

