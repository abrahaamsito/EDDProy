using System;

namespace EDDemo
{
    public class NodoPila
    {
        public int Valor { get; set; }  // El valor del nodo
        public NodoPila Sig { get; set; }   // Referencia al siguiente nodo
    }


    public class Pilas
    {
        private NodoPila tope;  // Puntero al nodo superior de la pila

        public Pilas()
        {
            tope = null;  // Inicializamos la pila vacía
        }

        // Método para agregar un valor a la pila (Push)
        public void Push(int valor)
        {
            NodoPila nuevo = new NodoPila();  // Cambiado de Nodo a NodoPila
            nuevo.Valor = valor;
            nuevo.Sig = tope;  // El siguiente nodo es el actual tope
            tope = nuevo;  // El nuevo nodo se convierte en el tope
        }

        // Método para eliminar el valor del tope de la pila (Pop)
        public int Pop()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La pila está vacía.");

            int valor = tope.Valor;  // Guardamos el valor a eliminar
            tope = tope.Sig;  // Movemos el tope al siguiente nodo
            return valor;
        }

        // Método para obtener el valor del tope de la pila sin eliminarlo (Peek)
        public int Peek()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La pila está vacía.");

            return tope.Valor;  // Retorna el valor del tope sin eliminarlo
        }

        // Método para verificar si la pila está vacía
        public bool EstaVacia()
        {
            return tope == null;  // La pila está vacía si el tope es null
        }

        // Propiedad para acceder al tope de la pila (si lo necesitas en la UI)
        public NodoPila Tope  // Cambiado de Nodo a NodoPila
        {
            get { return tope; }
        }
    }
}
