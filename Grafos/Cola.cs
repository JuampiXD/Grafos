using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafos
{
    class Cola
    {
        private Nodocola inicio; //puntero al nodo frente de la cola

        //crea una cola vacia
        public Cola()
        {
            inicio = null;
        }
        //Devuelve TRUE si la cola está vacía
        public bool vacia()
        {
            return (inicio == null);
        }
        //Devuelve el elemento que está al frente de la cola
        public object frente()
        {
            if (vacia())
            {
                MessageBox.Show("Error, cola vacia");
                return null;
            }
            else
                return inicio.dato;
        }
        public void encolar(object elem)
        {
            Nodocola nuevo = new Nodocola();
            nuevo.dato = elem;
            if (vacia())
                inicio = nuevo;
            else
            {
                Nodocola q = inicio;
                while (q.siguiente != null)
                    q = q.siguiente;
                q.siguiente = nuevo;
            }
        }
        public object desencolar()
        {
            if (vacia())
            {
                MessageBox.Show("Error,cola vacia");
                 return null;
            }
            else
            {
                object aux = inicio.dato;
                inicio = inicio.siguiente;
                return aux;
            }
        }
    }
}
