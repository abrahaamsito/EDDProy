using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_busqueda_y_ordenamiento.Clasess
{
    internal class Busqueda
    {
        // Método para realizar la búsqueda binaria
        public int BuscarBinaria(int[] arreglo, int objetivo)
        {
            // Asegurarse de que el arreglo esté ordenado antes de realizar la búsqueda binaria
            Array.Sort(arreglo);

            int izquierda = 0;
            int derecha = arreglo.Length - 1;

            // Mientras la parte derecha sea mayor o igual que la izquierda
            while (izquierda <= derecha)
            {
                // Calcular el índice medio del arreglo
                int medio = izquierda + (derecha - izquierda) / 2;

                // Comparamos el valor en el medio con el objetivo
                if (arreglo[medio] == objetivo)
                {
                    return medio; // Se encontró el valor, se retorna el índice
                }
                else if (arreglo[medio] < objetivo)
                {
                    // Si el valor objetivo es mayor, buscar en la mitad derecha
                    izquierda = medio + 1;
                }
                else
                {
                    // Si el valor objetivo es menor, buscar en la mitad izquierda
                    derecha = medio - 1;
                }
            }

            // Si no se encuentra el objetivo, retornar -1
            return -1;
        }

        // Método para realizar la búsqueda con Hashing
        public bool BuscarHashing(int[] arreglo, int objetivo)
        {
            // Crear un diccionario para almacenar los elementos del arreglo como claves
            Dictionary<int, bool> tablaHash = new Dictionary<int, bool>();

            // Insertar todos los elementos del arreglo en el diccionario
            foreach (var elemento in arreglo)
            {
                // Solo insertamos si no existe la clave, para evitar duplicados
                if (!tablaHash.ContainsKey(elemento))
                {
                    tablaHash[elemento] = true;
                }
            }

            // Comprobar si el objetivo está en el diccionario
            return tablaHash.ContainsKey(objetivo);
        }

        // Método para realizar la búsqueda secuencial
        public int BuscarSecuencial(int[] arreglo, int objetivo)
        {
            // Recorrer el arreglo de principio a fin
            for (int i = 0; i < arreglo.Length; i++)
            {
                // Si encontramos el objetivo, devolver el índice
                if (arreglo[i] == objetivo)
                {
                    return i;  // Se encontró el valor, retornamos el índice
                }
            }

            // Si no se encuentra el objetivo, retornar -1
            return -1; // No se encontró el valor
        }
    }
}



