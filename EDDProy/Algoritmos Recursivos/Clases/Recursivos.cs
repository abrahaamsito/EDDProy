using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_Recursivos.Clases
{
    internal class Recursivos
    {
        // Método recursivo para calcular el factorial de un número
        public int CalcularFactorial(int numero)
        {
            if (numero == 0)
                return 1; // Caso base: el factorial de 0 es 1
            else
                return numero * CalcularFactorial(numero - 1); // Llamada recursiva
        }

        // Método recursivo para calcular la serie Fibonacci
        public int CalcularFibonacci(int n)
        {
            if (n <= 1)
                return n; // Caso base: Fibonacci(0) = 0 y Fibonacci(1) = 1
            else
                return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2); // Llamada recursiva
        }

        // Método recursivo para calcular el exponente de un número (base^exponente)
        public int CalcularExponente(int baseNumero, int exponente)
        {
            if (exponente == 0)
                return 1; // Caso base: cualquier número elevado a 0 es 1
            else
                return baseNumero * CalcularExponente(baseNumero, exponente - 1); // Llamada recursiva
        }

        // Método recursivo para sumar los elementos de un arreglo
        public int SumarArreglo(int[] arreglo, int indice)
        {
            if (indice == arreglo.Length)
                return 0; // Caso base: si hemos llegado al final del arreglo, la suma es 0
            return arreglo[indice] + SumarArreglo(arreglo, indice + 1); // Llamada recursiva
        }

        // Método recursivo para realizar una búsqueda binaria
        public int BusquedaBinaria(int[] arreglo, int inicio, int fin, int clave)
        {
            if (inicio > fin)
                return -1; // Caso base: si el rango es inválido, no se encuentra el valor
            int medio = (inicio + fin) / 2;

            if (arreglo[medio] == clave)
                return medio;

            if (arreglo[medio] > clave)
                return BusquedaBinaria(arreglo, inicio, medio - 1, clave);

            return BusquedaBinaria(arreglo, medio + 1, fin, clave);
        }

        // Método recursivo para resolver las Torres de Hanoi
        public void TorresDeHanoi(int n, string origen, string destino, string auxiliar, Action<string, string, int> mostrarMovimiento)
        {
            if (n == 1)
            {
                // Mover el disco 1
                mostrarMovimiento(origen, destino, 1);
                return;
            }

            // Mover los n-1 discos desde el origen al auxiliar
            TorresDeHanoi(n - 1, origen, auxiliar, destino, mostrarMovimiento);

            // Mover el disco n desde el origen al destino
            mostrarMovimiento(origen, destino, n);

            // Mover los n-1 discos desde el auxiliar al destino
            TorresDeHanoi(n - 1, auxiliar, destino, origen, mostrarMovimiento);
        }
    }
}


