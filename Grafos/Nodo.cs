using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafos
{
    class Nodo
    {
        public object Dato { get; set; }
        public Point Punto { get; set; }
        public int Peso { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo Aristas { get; set; }
        public Nodo Anterior { get; set; }
        public Nodo()
        {
            Punto = new Point(0, 0);
            Dato = null;
            Aristas = null;
            Siguiente = null;
            Anterior = null;
        }
    }
}
