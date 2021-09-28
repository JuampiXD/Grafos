using System;
using System.Drawing;
using System.Windows.Forms;

namespace Grafos
{
    public partial class Grafos : Form
    {
        Grafo G = new Grafo();
        Graphics g;
        protected int x = 1;
        int A = 0, V = 0;
        public Grafos()
        {
            InitializeComponent();
            picFondo.Size = new Size(1570, 700);
            picFondo.Location = new Point(0, 0);
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            V = G.CantidadVertices() + 1;
            lbxV.Items.Clear();
            g = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black, 5);
            Font drawFont = new Font("Arial", 20);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float X = e.X;
            float Y = e.Y;
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            g.DrawString(x.ToString(), drawFont, drawBrush, X, Y - 30);
            g.DrawRectangle(lapiz, new Rectangle(e.X, e.Y, 5, 5));
            G.InsertarVertice(x, new Point(e.X, e.Y));
            lbxV.Items.Add(V.ToString());
            x++;


        }
        private void BtnInsertarAristas_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtX.Text);
                int b = Convert.ToInt32(txtY.Text);
                int peso = Convert.ToInt32(txtPeso.Text);
                int x = G.HayArista(a, b);
                if (x == -1)
                {
                    if ((G.HayVertice(a) != -1) && (G.HayVertice(b) != -1))
                    {
                        lbxA.Items.Clear();
                        g = panel1.CreateGraphics();
                        Pen lapiz = new Pen(Color.Blue, 9);
                        A++;
                        if (comboTipo.Text == "DIRIGIDO")
                        {
                            G.InsertarArista(a, b, peso);
                            lapiz.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            if (a == b)
                            {
                                lapiz = new Pen(Color.Cyan, 5);
                                lapiz.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                                g.DrawArc(lapiz, new Rectangle((G.Puntos(a).X) - 15, (G.Puntos(a).Y) - 5, 25, 25), 0, 300);
                            }
                            else
                                g.DrawLine(lapiz, G.Puntos(a).X, G.Puntos(a).Y, G.Puntos(b).X, G.Puntos(b).Y);
                        }
                        else
                        {
                            if (a != b)
                            {
                                G.InsertarArista(a, b, peso);
                                G.InsertarArista(b, a, peso);
                                g.DrawLine(lapiz, G.Puntos(a).X, G.Puntos(a).Y, G.Puntos(b).X, G.Puntos(b).Y);
                            }
                            else
                            {
                                G.InsertarArista(a, b, peso);
                                lapiz = new Pen(Color.Cyan, 5);
                                lapiz.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                                g.DrawArc(lapiz, new Rectangle((G.Puntos(a).X) - 15, (G.Puntos(a).Y) - 5, 25, 25), 0, 300);
                            }
                        }
                        Font drawFont = new Font("Arial", 10);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);
                        float X = (G.Puntos(a).X + G.Puntos(b).X) / 2;
                        float Y = (G.Puntos(a).Y + G.Puntos(b).Y) / 2;
                        StringFormat drawFormat = new StringFormat();
                        drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
                        g.DrawString("Peso: " + peso.ToString(), drawFont, drawBrush, X, Y - 20);
                        lbxA.Items.Add(A.ToString());


                    }
                    else
                    {
                        MessageBox.Show("No xiste uno ó los vertices ingresados");
                    }

                }
                else
                    MessageBox.Show("Esa Arista ya existe");

            }
            catch
            {
                MessageBox.Show("Error al Ingresar Datos");
            }
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            lbxVitrina.Items.Clear();
            G.Vertice(lbxVitrina);
            G.Aristas(lbxVitrina);
            G.Matriz(this);
        }
        private void BtnEliminarArista_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtX.Text);
                int b = Convert.ToInt32(txtY.Text);
                if (G.HayArista(a, b) != -1)
                {
                    lbxA.Items.Clear();
                    if (comboTipo.Text == "DIRIGIDO")
                        G.EliminarArista(a, b);
                    else
                    {
                        G.EliminarArista(a, b);
                        G.EliminarArista(b, a);
                    }
                    A--;
                    g.Clear(Color.Moccasin);
                    lbxA.Items.Add(A.ToString());
                    G.ActualizarGrafos(panel1, comboTipo);
                }
                else
                {
                    MessageBox.Show("No existe Arista");
                }
            }
            catch
            {
                MessageBox.Show("Error de Dato ingresado");
            }
        }
        private void BtnEliminarVertice_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtEliminar.Text);
                if (G.HayVertice(a) != -1)
                {
                    G.EliminarVertice(a, comboTipo);
                    G.CantidadAristas();
                    if (comboTipo.Text == "DIRIGIDO")
                        A = G.m;
                    else
                        A = G.m / 2;
                    V = G.CantidadVertices();
                    lbxV.Items.Clear();
                    lbxV.Items.Add(V);
                    lbxA.Items.Clear();
                    lbxA.Items.Add(A);
                    g.Clear(Color.Moccasin);
                    G.ActualizarGrafos(panel1, comboTipo);
                }
                else
                {
                    MessageBox.Show("No existe Vertice");
                }
            }
            catch
            {
                MessageBox.Show("Error de Dato");
            }
        }
        private void BtnAdyacentes_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtEliminar.Text);
                if (G.HayVertice(a) != -1)
                {
                    string adyacentes = G.Adyacentes(a);
                    if (adyacentes.Equals(""))
                        adyacentes = "null";
                    lbxVitrina.Items.Clear();
                    lbxVitrina.Items.Add("Adyacentes al vertice: " + a.ToString() + " son;");
                    lbxVitrina.Items.Add(adyacentes);
                }
                else
                {
                    MessageBox.Show("No existe Vertice");
                }
            }
            catch
            {
                MessageBox.Show("Error al ingresar datos");
            }
        }
        private void BtnAntecesores_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtEliminar.Text);
                if (G.HayVertice(a) != -1)
                {
                    string Antecesores = G.Antecesores(a);
                    if (Antecesores.Equals(""))
                        Antecesores = "null";
                    lbxVitrina.Items.Clear();
                    lbxVitrina.Items.Add("Antecesores al vertice: " + a.ToString() + " son;");
                    lbxVitrina.Items.Add(Antecesores);
                }
                else
                {
                    MessageBox.Show("No existe Vertice");
                }
            }
            catch
            {
                MessageBox.Show("Error al ingresar datos");
            }
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            x = 1;
            A = 0;
            V = 0;
            lbxA.Items.Clear();
            lbxV.Items.Clear();
            G.Anula();
            lbxVitrina.Items.Clear();
            G.LimpiarMatriz();
            try
            {
                g.Clear(Color.Moccasin);
            }
            catch
            {
                MessageBox.Show("Ya esta limpio");
            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = 1;
            A = 0;
            V = 0;
            lbxA.Items.Clear();
            lbxV.Items.Clear();
            G.Anula();
            lbxVitrina.Items.Clear();
            G.LimpiarMatriz();
            try
            {
                g.Clear(Color.Moccasin);
            }
            catch
            {
                MessageBox.Show("Ya esta limpio");
            }
        }
        private void btnBFS_Click(object sender, EventArgs e)
        {
            try
            {
                lbxVitrina.Items.Clear();
                lbxVitrina.Items.Add(G.BFS());
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void btnDFS_Click(object sender, EventArgs e)
        {
            bool[] Visitados = new bool[G.CantidadVertices()];
            for (int i = 0; i < Visitados.Length; i++)
                Visitados[i] = false;
            string DFSS = "";
            DFSS = DFSS + "DFS : " + G.DevuelveDatoVertice(1);
            G.DFS(G.DevuelveDatoVertice(1), Visitados, ref DFSS);
            lbxVitrina.Items.Clear();
            lbxVitrina.Items.Add(DFSS);
        }
        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            try
            {
                int inicio = Convert.ToInt32(txtInicio.Text);
                int Fin = Convert.ToInt32(txtFin.Text);
                string camino = G.CalcularDijkstra(inicio, Fin);
                lbxVitrina.Items.Clear();
                lbxVitrina.Items.Add(camino);
                lbxVitrina.Items.Add("Peso: " + G.DevuelvePesoDijkstra().ToString());
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
        private void BtnSali_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
