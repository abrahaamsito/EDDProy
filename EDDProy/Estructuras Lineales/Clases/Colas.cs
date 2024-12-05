using System;
using System.Collections.Generic;

namespace EDDemo.Estructuras_de_Datos
{
    public class Cola<T> // Generics para soportar cualquier tipo de datos
    {
        private List<T> _elementos;

        // Constructor
        public Cola()
        {
            _elementos = new List<T>();
        }

        // Método para agregar un elemento a la cola (Encolar)
        public void Encolar(T elemento)
        {
            _elementos.Add(elemento);
        }

        // Método para quitar un elemento de la cola (Desencolar)
        public T Desencolar()
        {
            if (_elementos.Count == 0)
            {
                throw new InvalidOperationException("La cola está vacía.");
            }
            T primero = _elementos[0];
            _elementos.RemoveAt(0); // Elimina el primer elemento
            return primero;
        }

        // Método para obtener el primer elemento sin eliminarlo
        public T ObtenerFrente()
        {
            if (_elementos.Count == 0)
            {
                throw new InvalidOperationException("La cola está vacía.");
            }
            return _elementos[0];
        }

        // Método para verificar si la cola está vacía
        public bool EstaVacia()
        {
            return _elementos.Count == 0;
        }

        // Método para obtener el número de elementos en la cola
        public int ContarElementos()
        {
            return _elementos.Count;
        }

        // Método para limpiar la cola
        public void Limpiar()
        {
            _elementos.Clear();
        }

        // Método para obtener todos los elementos de la cola como un arreglo
        public T[] ObtenerElementos()
        {
            return _elementos.ToArray();
        }
    }
}


