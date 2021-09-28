using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Grafos
{
    class Grafo
    {
        int inicio = 0;
        int final = 0;
        int distancia = 0;
        int c = 0;
        int cantNodos = 0;
        string Camino = "";
        int actual = 0;
        int columna = 0;
        int[] v;
        public Nodo Inicio { get; set; }
        public Nodo Fin { get; set; }
        int n = 0;
        public int m;
        DataGridView Dgview = new DataGridView();
        public Grafo()
        {
            Anula();
        }
        public void Anula()
        {
            Inicio = null;
            Fin = null;
            n = 0;
        }
        public bool EsVacio()
        {
            if (Inicio == null) return true;
            else return false;
        }
        public void CantidadAristas()
        {
            Nodo q = Inicio;
            Nodo aq = q;
            m = 0;
            while (q != null)
            {
                aq = q.Aristas;
                while (aq != null)
                {
                    m++;
                    aq = aq.Aristas;
                }

                q = q.Siguiente;
            }
        }
        public int AristasDeunVertice(object a)
        {
            int pos = HayVertice(a);
            Nodo q = Inicio;
            int z = 1;
            while (z < pos)
            {
                q = q.Siguiente;
                z++;
            }
            int cantidadA = 0;
            while (q != null)
            {
                cantidadA++;

                q = q.Siguiente;
            }
            return cantidadA;
        }
        public int CantidadVertices()
        {
            return n;
        }
        public Point Puntos(object elemento)
        {
            int pos = 1;
            Nodo Act = Inicio;
            while (Act != null)
            {
                if (Act.Dato.Equals(elemento))
                    return Act.Punto;
                Act = Act.Siguiente;
                pos++;
            }
            return new Point(0, 0);
        }
        public int HayVertice(object elemento)
        {
            int pos = 1;
            Nodo Act = Inicio;
            while (Act != null)
            {
                if (Act.Dato.Equals(elemento))
                    return pos;
                Act = Act.Siguiente;
                pos++;
            }
            return -1;
        }
        public object DevuelveDatoVertice(int pos)
        {
            int z = 1;
            Nodo Act = Inicio;
            while (z < pos)
            {
                Act = Act.Siguiente;
                z++;
            }
            return Act.Dato;
        }
        private object DevuelveDatoArista(object a, int b)
        {
            int pos = HayVertice(a);
            if (pos != -1)
            {
                Nodo q = Inicio;
                int z = 1;
                while (z < pos)
                {
                    q = q.Siguiente;
                    z++;
                }
                if (q.Aristas == null)
                    return -1;
                else
                {
                    q = q.Aristas;
                    z = 1;
                    while (z < b)
                    {
                        q = q.Aristas;
                        z++;
                    }
                    return q.Dato;
                }

            }
            else
            {
                MessageBox.Show("Error de Vertice");
                return -1;
            }
        }
        public int HayArista(object a, object b)
        {
            int pos = HayVertice(a);
            if (pos != -1)
            {
                Nodo q = Inicio;
                int z = 1;
                while (z < pos)
                {
                    q = q.Siguiente;
                    z++;
                }
                if (q.Aristas == null)
                    return -1;
                else
                {
                    int x = 1;
                    q = q.Aristas;
                    while (q != null)
                    {
                        if (q.Dato.Equals(b))
                            return x;//recorre hasta encontrar el null y retornar la posicion donde se encuentra 
                        q = q.Aristas;
                        x++;
                    }
                    return -1;
                }

            }
            else
            {
                MessageBox.Show("Error de Vertice");
                return -1;
            }


        }
        public void Vertice(ListBox lbxVitrina)
        {
            Nodo q = Inicio;
            string a = "V = ";
            while (q != null)
            {
                a = a + q.Dato.ToString() + ", ";
                q = q.Siguiente;
            }
            lbxVitrina.Items.Add(a);
        }
        public void Aristas(ListBox lbxVitrina)
        {
            Nodo q = Inicio;
            Nodo aq = q;
            while (q != null)
            {
                string puntos = "";
                aq = q.Aristas;
                while (aq != null)
                {
                    puntos = puntos + "(" + q.Dato.ToString() + " ," + aq.Dato.ToString() + ") ;";
                    aq = aq.Aristas;
                }
                lbxVitrina.Items.Add(q.Dato.ToString() + "--> " + puntos);
                q = q.Siguiente;
            }
        }
        public int CantidadAristasVertices(object a)
        {
            int pos = HayVertice(a);
            if (pos != -1)
            {
                Nodo q = Inicio;
                Nodo aq = q;
                int c = 1;
                while (c < pos)
                {
                    q = q.Siguiente;
                    c++;
                }
                aq = q.Aristas;
                c = 0;
                while (aq != null)
                {
                    c++;
                    aq = aq.Aristas;
                }
                return c;
            }
            else
            {
                MessageBox.Show("No existe el vertice");
                return -1;
            }
        }
        public string Adyacentes(object a)
        {
            int pos = HayVertice(a);
            if (pos != -1)
            {
                Nodo q = Inicio;
                Nodo aq = q;
                string adyacente = "";
                int c = 1;
                while (c < pos)
                {
                    q = q.Siguiente;
                    c++;
                }
                aq = q.Aristas;
                while (aq != null)
                {
                    adyacente = adyacente + aq.Dato.ToString() + ", ";
                    aq = aq.Aristas;
                }
                return adyacente;
            }
            else
            {
                MessageBox.Show("No existe el vertice");
                return "null";
            }

        }
        public string Antecesores(object a)
        {
            int pos = HayVertice(a);
            if (pos != -1)
            {
                Nodo q = Inicio;
                Nodo aq = q;
                string Antecesor = "";
                while (q != null)
                {
                    aq = q.Aristas;
                    while (aq != null)
                    {
                        if (aq.Dato.Equals(a))
                        {
                            Antecesor = Antecesor + q.Dato.ToString() + ", ";
                        }
                        aq = aq.Aristas;
                    }
                    q = q.Siguiente;
                }
                return Antecesor;
            }
            else
            {
                MessageBox.Show("No existe el Vertice");
                return "Null";
            }
        }
        public void InsertarVertice(object elemento, Point punto)
        {
            InsertarV(elemento, n + 1, punto);
        }
        private void InsertarV(object elemento, int pos, Point punto)
        {
            if (pos >= 1 && pos <= n + 1)
            {
                Nodo nuevo = new Nodo();
                nuevo.Dato = elemento;
                nuevo.Punto = punto;
                if (n == 0)
                {
                    Inicio = nuevo;
                    Fin = nuevo;
                    n++;
                }
                else if (pos == 1)
                {
                    nuevo.Siguiente = Inicio;
                    Inicio.Anterior = nuevo;
                    Inicio = nuevo;
                    n++;
                }
                else if (pos == n + 1)
                {
                    nuevo.Anterior = Fin;
                    Fin.Siguiente = nuevo;
                    Fin = nuevo;
                    n++;
                }
            }
            else
                MessageBox.Show("Posición fuera de rango");
        }
        public void InsertarArista(object a, object b, int Peso)
        {
            if (EsVacio() == false)
            {
                Nodo nuevo = new Nodo();
                nuevo.Dato = b;
                nuevo.Punto = Puntos(b);
                nuevo.Peso = Peso;
                Nodo q = Inicio;
                int z = HayVertice(a);
                int aux = 1;
                while (aux < z)
                {
                    q = q.Siguiente;
                    aux++;
                }
                Nodo aq = q.Aristas;
                if (q.Aristas == null)
                {
                    q.Aristas = nuevo;
                }
                else
                {
                    while (q.Aristas != null)
                    {
                        q = q.Aristas;
                    }
                    q.Aristas = nuevo;
                }

            }
            else
            {
                MessageBox.Show("No existen Vertices");
            }
        }
        public void EliminarVertice(object a, ComboBox comboTipo)
        {
            int x = HayVertice(a); //Posicion del vertice
            if (x != -1)
            {
                EliminandoAntecesoresAristas(a, comboTipo);
                if (n == 1)
                {
                    Inicio = null;
                    Fin = null;
                }
                else if (x == 1)
                {
                    Inicio.Siguiente.Anterior = null;
                    Inicio = Inicio.Siguiente;
                }
                else if (x == n)
                {
                    Fin.Anterior.Siguiente = null;
                    Fin = Fin.Anterior;
                }
                else
                {
                    Nodo Act = Inicio;
                    int c = 1;
                    while (c < x)
                    {
                        Act = Act.Siguiente;
                        c++;
                    }
                    Act.Anterior.Siguiente = Act.Siguiente;
                    Act.Siguiente.Anterior = Act.Anterior;
                }
                n--;
            }
        }
        public void EliminandoAntecesoresAristas(object a, ComboBox comboTipo)
        {
            Nodo q = Inicio;
            Nodo aq = q;
            while (q != null)
            {
                aq = q.Aristas;
                while (aq != null)
                {
                    if (aq.Dato.Equals(a))
                    {
                        if (comboTipo.Text == "DIRIGIDO")
                            EliminarArista(q.Dato, aq.Dato);
                        else
                        {
                            EliminarArista(q.Dato, aq.Dato);
                            EliminarArista(aq.Dato, q.Dato);
                        }
                    }
                    aq = aq.Aristas;
                }
                q = q.Siguiente;
            }
        }
        public void EliminarArista(object a, object b)
        {
            int x = HayArista(a, b);
            if (x != -1)
            {
                int pos = HayVertice(a);
                Nodo q = Inicio;
                int z = 1;
                int cantidadA = CantidadAristasVertices(a);
                while (z < pos)
                {
                    q = q.Siguiente;
                    z++;
                }
                if (cantidadA == 1)
                {
                    q.Aristas = null;
                }
                else if (x == 1)
                {
                    Nodo aq = q.Aristas.Aristas;
                    q.Aristas = aq;

                }
                else if (x == cantidadA)
                {
                    int c = 1;
                    q = q.Aristas;
                    while (c < x - 1)
                    {
                        q = q.Aristas;
                        c++;
                    }
                    q.Aristas = null;
                }
                else
                {
                    int c = 1;
                    q = q.Aristas;
                    while (c < x - 1)
                    {
                        q = q.Aristas;
                        c++;
                    }
                    Nodo aq = q.Aristas.Aristas;
                    q = aq;
                }

            }
            else
            {
                MessageBox.Show("No existe la Arista");
            }
        }
        public void ActualizarGrafos(Panel panel1, ComboBox comboTipo)
        {
            Graphics g = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black, 5);
            Font drawFont = new Font("Arial", 20);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            Nodo q = Inicio;
            while (q != null)
            {
                float X = q.Punto.X;
                float Y = q.Punto.Y;
                g.DrawString(q.Dato.ToString(), drawFont, drawBrush, X, Y - 30);
                g.DrawRectangle(lapiz, new Rectangle(q.Punto.X, q.Punto.Y, 3, 3));
                q = q.Siguiente;
            }
            q = Inicio;
            Nodo aq = q;
            lapiz = new Pen(Color.Blue, 5);
            while (q != null)
            {
                aq = q.Aristas;
                while (aq != null)
                {
                    if (comboTipo.Text == "DIRIGIDO")
                    {
                        lapiz.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                        if (q.Dato == aq.Dato)
                        {
                            lapiz = new Pen(Color.Cyan, 5);
                            lapiz.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            g.DrawArc(lapiz, new Rectangle((q.Punto.X) - 15, (q.Punto.Y) - 5, 25, 25), 0, 300);
                        }
                        g.DrawLine(lapiz, q.Punto.X, q.Punto.Y, aq.Punto.X, aq.Punto.Y);
                    }
                    else
                    {
                        if (q.Dato.Equals(aq.Dato))
                        {
                            lapiz = new Pen(Color.Cyan, 5);
                            lapiz.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            g.DrawArc(lapiz, new Rectangle(q.Punto.X - 15, q.Punto.Y - 5, 25, 25), 0, 300);
                        }
                        else
                        {
                            g.DrawLine(lapiz, q.Punto.X, q.Punto.Y, aq.Punto.X, aq.Punto.Y);
                        }
                    }
                    drawFont = new Font("Arial", 10);
                    drawBrush = new SolidBrush(Color.Black);
                    float X = (q.Punto.X + aq.Punto.X) / 2;
                    float Y = (q.Punto.Y + aq.Punto.Y) / 2;
                    g.DrawString("Peso: " + aq.Peso.ToString(), drawFont, drawBrush, X, Y - 20);
                    aq = aq.Aristas;
                }
                q = q.Siguiente;
            }
        }
        public void LimpiarMatriz()
        {
            Dgview.Dispose();
        }
        public void Matriz(Form form1)
        {
            Dgview.Dispose();
            Dgview = new DataGridView();
            Dgview.Size = new Size(497, 300);
            Dgview.Location = new Point(418, 201);
            form1.Controls.Add(Dgview);
            DataGridViewTextBoxColumn O = new DataGridViewTextBoxColumn();
            O.HeaderText = "0";
            Dgview.Columns.Add(O);
            int cantidadv = CantidadVertices();
            Dgview.RowCount = cantidadv;
            Dgview.ColumnCount = cantidadv;
            for (int k = 1; k <= cantidadv; k++)
            {
                Dgview.Columns[k - 1].HeaderText = DevuelveDatoVertice(k).ToString();
                Dgview.Rows[k - 1].HeaderCell.Value = DevuelveDatoVertice(k).ToString();
            }
            for (int i = 1; i <= cantidadv; i++)
            {
                for (int j = 1; j <= cantidadv; j++)
                {
                    if (HayArista(DevuelveDatoVertice(i), DevuelveDatoVertice(j)) != -1)
                    {
                        Dgview.Rows[i - 1].Cells[j - 1].Value = DevuelvePeso(DevuelveDatoVertice(i), DevuelveDatoVertice(j));
                    }
                    else
                    {
                        Dgview.Rows[i - 1].Cells[j - 1].Value = "0";
                    }
                }
            }
            Dgview.BringToFront();
        }
        public int DevuelvePeso(object a, object b)
        {
            int pos = HayVertice(a);
            if (pos != -1)
            {
                Nodo q = Inicio;
                int z = 1;
                while (z < pos)
                {
                    q = q.Siguiente;
                    z++;
                }
                q = q.Aristas;
                while (q != null)
                {
                    if (q.Dato.Equals(b))
                        return q.Peso;
                    q = q.Aristas;
                }
                return -1;

            }
            else
            {
                MessageBox.Show("Error de Vertice");
                return -1;
            }
        }
        public string BFS()
        {
            string BFS = "";
            Cola ColaAux = new Cola();
            bool[] Visitados = new bool[CantidadVertices()];
            for (int i = 0; i < Visitados.Length; i++)
                Visitados[i] = false;
            BFS = BFS + "BFS : " + DevuelveDatoVertice(1);
            ColaAux.encolar(DevuelveDatoVertice(1));
            Visitados[0] = true;
            object actual, siguiente;
            while (!ColaAux.vacia())
            {
                actual = ColaAux.desencolar();
                int Tamaño = CantidadAristasVertices(actual);
                for (int i = 0; i < Tamaño; i++)
                {
                    siguiente = DevuelveDatoArista(actual, i + 1);
                    if (Visitados[Convert.ToInt32(siguiente) - 1] == false)
                    {
                        BFS = BFS + " --> " + siguiente;
                        Visitados[Convert.ToInt32(siguiente) - 1] = true;
                        ColaAux.encolar(siguiente);
                    }

                }
            }
            return BFS;
        }
        public void DFS(object X, bool[] Visitados, ref string DFSS)
        {
            Visitados[Convert.ToInt32(X) - 1] = true;
            int Tamaño = CantidadAristasVertices(X);
            for (int i = 0; i < Tamaño; i++)
            {
                object siguiente = DevuelveDatoArista(X, i + 1);
                if (!Visitados[Convert.ToInt32(siguiente) - 1])
                {
                    DFSS = DFSS + " --> " + siguiente;
                    DFS(siguiente, Visitados, ref DFSS);
                }
            }
        }
        public string CalcularDijkstra(int inicio, int final)
        {
            cantNodos = n;
            this.inicio = inicio;
            this.final = final;
            int[,] tabla = new int[cantNodos, 3];
            for (c = 0; c < cantNodos; c++)
            {
                tabla[c, 0] = 0;                //Nodo
                tabla[c, 1] = int.MaxValue;     //Peso
                tabla[c, 2] = 0;                //Padre o posterior
            }
            tabla[(inicio - 1), 1] = 0;
            actual = inicio;
            do
            {
                tabla[(actual - 1), 0] = 1;
                for (columna = 0; columna < cantNodos; columna++)
                {
                    if (HayArista(actual, columna + 1) != -1)
                    {
                        int x = DevuelvePeso(actual, (columna + 1));
                        int y = tabla[(actual - 1), 1];
                        distancia = x + y;
                        if (distancia < tabla[columna, 1])
                        {
                            tabla[columna, 1] = distancia;
                            tabla[columna, 2] = actual;
                        }
                    }
                }
                int IndiceMenor = -1;
                int distanciaMenor = int.MaxValue;
                for (int x = 0; x < cantNodos; x++)
                {
                    if (tabla[x, 1] < distanciaMenor && tabla[x, 0] == 0)
                    {
                        IndiceMenor = (x + 1);
                        distanciaMenor = tabla[x, 1];
                    }
                }
                actual = IndiceMenor;

            } while (actual != -1);
            Camino = "";
            List<int> ruta = new List<int>();
            int nodo = final;
            int a = 0;
            while (nodo != inicio)
            {
                a++;
                ruta.Add(nodo);
                nodo = tabla[(nodo - 1), 2];
            }
            ruta.Add(inicio);
            ruta.Reverse();
            v = new int[a+1];
            a = 0;
            foreach (int posicion in ruta)
            {
                v[a] = posicion;
                Camino = Camino + "--> {" + posicion + "}";
                a++;
            }
            
            return Camino;
        }
        public int DevuelvePesoDijkstra()
        {
            int peso = 0;
            for (int i = 0; i < v.Length - 1; i++)
            {
                peso = peso + DevuelvePeso(v[i], v[i + 1]);
            }
            return peso;
        }
    }
}
