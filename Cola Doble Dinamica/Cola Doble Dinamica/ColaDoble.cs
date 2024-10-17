using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cola_Doble_Dinamica
{
    public class ColaDoble
    {
        private Nodo front;
        private Nodo rear;


        public ColaDoble()
        {

            front = null;
            rear = null;
        }

       
        public bool EstaVacia()
        {
            return front == null;
        }

        // Insertar al front
        public void InsertarFrente(int valor)
        {
            Nodo newNode = new Nodo (valor);
            if (EstaVacia())
            {
                front = rear = newNode;
            }
            else
            {
                newNode.Next = front;
                front.Prev = newNode;
                front = newNode;
            }

        }
        public int Count()
        {
            int contador = 0;
            Nodo Current =front  ;


                 while(Current != null)      
            {
            Current = Current.Next;
                contador++;
            
            }
            return contador;
        }
        // Insertar al rear
        public void InsertarFinal(int valor)
        {
            Nodo   newNode = new Nodo (valor);
            if (EstaVacia())
            {
                front = rear = newNode;
            }
            else
            {
                newNode.Prev = rear;
                rear.Next = newNode;
                rear = newNode;
            }
        }

        // Eliminar del front
        public int EliminarFrente()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            int valor = front.Valor;
            if (front == rear)
            {
                front = rear = null;
            }
            else
            {
                front = front.Next;
                front.Prev = null;
            }
            return valor;
        }

        // Eliminar del rear
        public int EliminarFinal()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            int valor = rear.Valor;
            if (front == rear)
            {
                front = rear = null;
            }
            else
            {
                rear = rear.Prev;
                rear.Next = null;
            }
            return valor;
        }

        // Acceder al front
        public int VerFrente()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            return front.Valor;
        }

        // Acceder al rear
        public int VerFinal()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            return rear.Valor;
        }



        public List<int> ObtenerElementos()
        {
            List<int> elementos = new List<int>();
            Nodo actual = front;

            while (actual != null)
            {
                elementos.Add(actual.Valor);
                actual = actual.Next;
            }

            return elementos;
        }


        
    }
}
