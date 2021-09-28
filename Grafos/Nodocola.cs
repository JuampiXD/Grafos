using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Nodocola
    {
        public object dato { get; set; }
        public Nodocola siguiente { get; set; }
        public Nodocola()
        {
            dato = null;
            siguiente = null;
        }
    }
}
