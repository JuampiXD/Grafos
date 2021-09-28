namespace Grafos
{
    partial class Grafos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsertarAristas = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lbxVitrina = new System.Windows.Forms.ListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarArista = new System.Windows.Forms.Button();
            this.btnEliminarVertice = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdyacentes = new System.Windows.Forms.Button();
            this.btnAntecesores = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSali = new System.Windows.Forms.Button();
            this.lbxV = new System.Windows.Forms.ListBox();
            this.lbxA = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBFS = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Location = new System.Drawing.Point(936, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 478);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // btnInsertarAristas
            // 
            this.btnInsertarAristas.BackColor = System.Drawing.Color.Bisque;
            this.btnInsertarAristas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarAristas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInsertarAristas.Location = new System.Drawing.Point(54, 212);
            this.btnInsertarAristas.Name = "btnInsertarAristas";
            this.btnInsertarAristas.Size = new System.Drawing.Size(190, 55);
            this.btnInsertarAristas.TabIndex = 0;
            this.btnInsertarAristas.Text = "Crear Aristas";
            this.btnInsertarAristas.UseVisualStyleBackColor = false;
            this.btnInsertarAristas.Click += new System.EventHandler(this.BtnInsertarAristas_Click);
            // 
            // txtX
            // 
            this.txtX.BackColor = System.Drawing.Color.Silver;
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(153, 100);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(57, 29);
            this.txtX.TabIndex = 0;
            // 
            // txtY
            // 
            this.txtY.BackColor = System.Drawing.Color.Silver;
            this.txtY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY.Location = new System.Drawing.Point(153, 141);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(57, 29);
            this.txtY.TabIndex = 1;
            // 
            // lbxVitrina
            // 
            this.lbxVitrina.BackColor = System.Drawing.Color.Silver;
            this.lbxVitrina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxVitrina.FormattingEnabled = true;
            this.lbxVitrina.HorizontalScrollbar = true;
            this.lbxVitrina.ItemHeight = 31;
            this.lbxVitrina.Location = new System.Drawing.Point(418, 96);
            this.lbxVitrina.Name = "lbxVitrina";
            this.lbxVitrina.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbxVitrina.Size = new System.Drawing.Size(497, 97);
            this.lbxVitrina.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Bisque;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(1284, 586);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(188, 45);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vertice a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vertice b:";
            // 
            // btnEliminarArista
            // 
            this.btnEliminarArista.BackColor = System.Drawing.Color.Bisque;
            this.btnEliminarArista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArista.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarArista.Location = new System.Drawing.Point(54, 273);
            this.btnEliminarArista.Name = "btnEliminarArista";
            this.btnEliminarArista.Size = new System.Drawing.Size(190, 45);
            this.btnEliminarArista.TabIndex = 8;
            this.btnEliminarArista.Text = "Eliminar Arista";
            this.btnEliminarArista.UseVisualStyleBackColor = false;
            this.btnEliminarArista.Click += new System.EventHandler(this.BtnEliminarArista_Click);
            // 
            // btnEliminarVertice
            // 
            this.btnEliminarVertice.BackColor = System.Drawing.Color.Bisque;
            this.btnEliminarVertice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVertice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarVertice.Location = new System.Drawing.Point(54, 400);
            this.btnEliminarVertice.Name = "btnEliminarVertice";
            this.btnEliminarVertice.Size = new System.Drawing.Size(217, 40);
            this.btnEliminarVertice.TabIndex = 9;
            this.btnEliminarVertice.Text = "Eliminar Vertice";
            this.btnEliminarVertice.UseVisualStyleBackColor = false;
            this.btnEliminarVertice.Click += new System.EventHandler(this.BtnEliminarVertice_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.BackColor = System.Drawing.Color.Silver;
            this.txtEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminar.Location = new System.Drawing.Point(90, 365);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(78, 29);
            this.txtEliminar.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vertice a modificar o a probar";
            // 
            // btnAdyacentes
            // 
            this.btnAdyacentes.BackColor = System.Drawing.Color.Bisque;
            this.btnAdyacentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdyacentes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdyacentes.Location = new System.Drawing.Point(54, 445);
            this.btnAdyacentes.Name = "btnAdyacentes";
            this.btnAdyacentes.Size = new System.Drawing.Size(155, 40);
            this.btnAdyacentes.TabIndex = 12;
            this.btnAdyacentes.Text = "Adyacentes";
            this.btnAdyacentes.UseVisualStyleBackColor = false;
            this.btnAdyacentes.Click += new System.EventHandler(this.BtnAdyacentes_Click);
            // 
            // btnAntecesores
            // 
            this.btnAntecesores.BackColor = System.Drawing.Color.Bisque;
            this.btnAntecesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntecesores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAntecesores.Location = new System.Drawing.Point(54, 491);
            this.btnAntecesores.Name = "btnAntecesores";
            this.btnAntecesores.Size = new System.Drawing.Size(189, 40);
            this.btnAntecesores.TabIndex = 13;
            this.btnAntecesores.Text = "Antecesores";
            this.btnAntecesores.UseVisualStyleBackColor = false;
            this.btnAntecesores.Click += new System.EventHandler(this.BtnAntecesores_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(435, 62);
            this.label4.TabIndex = 14;
            this.label4.Text = "GRAFOS GRUPO H";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Bisque;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(1083, 586);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(162, 45);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnSali
            // 
            this.btnSali.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSali.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSali.Location = new System.Drawing.Point(1286, 12);
            this.btnSali.Name = "btnSali";
            this.btnSali.Size = new System.Drawing.Size(142, 45);
            this.btnSali.TabIndex = 16;
            this.btnSali.Text = "SALIR";
            this.btnSali.UseVisualStyleBackColor = false;
            this.btnSali.Click += new System.EventHandler(this.BtnSali_Click);
            // 
            // lbxV
            // 
            this.lbxV.BackColor = System.Drawing.Color.Silver;
            this.lbxV.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxV.FormattingEnabled = true;
            this.lbxV.ItemHeight = 33;
            this.lbxV.Location = new System.Drawing.Point(626, 628);
            this.lbxV.Name = "lbxV";
            this.lbxV.Size = new System.Drawing.Size(48, 37);
            this.lbxV.TabIndex = 17;
            // 
            // lbxA
            // 
            this.lbxA.BackColor = System.Drawing.Color.Silver;
            this.lbxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxA.FormattingEnabled = true;
            this.lbxA.ItemHeight = 33;
            this.lbxA.Location = new System.Drawing.Point(741, 628);
            this.lbxA.Name = "lbxA";
            this.lbxA.Size = new System.Drawing.Size(48, 37);
            this.lbxA.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(686, 634);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "A =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(565, 634);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "V =";
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.Silver;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(153, 177);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(57, 29);
            this.txtPeso.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "Peso A:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(930, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(295, 31);
            this.label8.TabIndex = 23;
            this.label8.Text = "DIBUJE LOS GRAFOS";
            // 
            // comboTipo
            // 
            this.comboTipo.BackColor = System.Drawing.Color.Silver;
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "DIRIGIDO",
            "NO DIRIGIDO"});
            this.comboTipo.Location = new System.Drawing.Point(683, 37);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(210, 39);
            this.comboTipo.TabIndex = 24;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // picFondo
            // 
            this.picFondo.Image = ((System.Drawing.Image)(resources.GetObject("picFondo.Image")));
            this.picFondo.Location = new System.Drawing.Point(277, 100);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(90, 66);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondo.TabIndex = 25;
            this.picFondo.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(490, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 31);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tipo de Grafo:";
            // 
            // btnBFS
            // 
            this.btnBFS.BackColor = System.Drawing.Color.Bisque;
            this.btnBFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBFS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBFS.Location = new System.Drawing.Point(17, 648);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(68, 31);
            this.btnBFS.TabIndex = 27;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = false;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 547);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(312, 31);
            this.label10.TabIndex = 28;
            this.label10.Text = "Metodos de Seguimiento";
            // 
            // btnDFS
            // 
            this.btnDFS.BackColor = System.Drawing.Color.Bisque;
            this.btnDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDFS.Location = new System.Drawing.Point(17, 611);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(68, 31);
            this.btnDFS.TabIndex = 30;
            this.btnDFS.Text = "DFS";
            this.btnDFS.UseVisualStyleBackColor = false;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.BackColor = System.Drawing.Color.Bisque;
            this.btnDijkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDijkstra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDijkstra.Location = new System.Drawing.Point(181, 657);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(108, 31);
            this.btnDijkstra.TabIndex = 31;
            this.btnDijkstra.Text = "DIJKSTRA";
            this.btnDijkstra.UseVisualStyleBackColor = false;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // txtInicio
            // 
            this.txtInicio.BackColor = System.Drawing.Color.Silver;
            this.txtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicio.Location = new System.Drawing.Point(165, 597);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(78, 29);
            this.txtInicio.TabIndex = 32;
            // 
            // txtFin
            // 
            this.txtFin.BackColor = System.Drawing.Color.Silver;
            this.txtFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFin.Location = new System.Drawing.Point(249, 597);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(78, 29);
            this.txtFin.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(176, 628);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 25);
            this.label11.TabIndex = 34;
            this.label11.Text = "Inicio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(272, 628);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 25);
            this.label12.TabIndex = 35;
            this.label12.Text = "Fin";
            // 
            // Grafos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1570, 700);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.btnDijkstra);
            this.Controls.Add(this.btnDFS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbxA);
            this.Controls.Add(this.lbxV);
            this.Controls.Add(this.btnSali);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAntecesores);
            this.Controls.Add(this.btnAdyacentes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnEliminarVertice);
            this.Controls.Add(this.btnEliminarArista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lbxVitrina);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnInsertarAristas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Grafos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafos";
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsertarAristas;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.ListBox lbxVitrina;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarArista;
        private System.Windows.Forms.Button btnEliminarVertice;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdyacentes;
        private System.Windows.Forms.Button btnAntecesores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSali;
        private System.Windows.Forms.ListBox lbxV;
        private System.Windows.Forms.ListBox lbxA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

