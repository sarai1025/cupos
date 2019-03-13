namespace Interfaz
{
    partial class RecomendacionUsu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            principal.Sirtru.guardarInformacion();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colum4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataFiltros = new System.Windows.Forms.DataGridView();
            this.NombreUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechayho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPartida = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.cbLugarPartida = new System.Windows.Forms.CheckBox();
            this.cbLugarDestino = new System.Windows.Forms.CheckBox();
            this.cbPorFechaYHora = new System.Windows.Forms.CheckBox();
            this.btnAtrasR = new System.Windows.Forms.Button();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmapRecomendacion = new GMap.NET.WindowsForms.GMapControl();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFiltros)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(51, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(747, 546);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.gmapRecomendacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(739, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recomendaciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(586, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Mostrar Recomendaciones";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(617, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Confirmar servicio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(536, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Mostrar ruta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione el servicio para poder visualizar la ruta y confirmar dicho servicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione su servicio del que desea recibir recomendaciones:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.Column11,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column8,
            this.Column10});
            this.dataGridView2.Location = new System.Drawing.Point(6, 172);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(752, 93);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum4,
            this.Column2,
            this.Column1,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(6, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(752, 76);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // colum4
            // 
            this.colum4.HeaderText = "Id servicio";
            this.colum4.Name = "colum4";
            this.colum4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Partida";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Destino";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha y hora";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gMapControl1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.btFiltrar);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.dataFiltros);
            this.tabPage2.Controls.Add(this.txtPartida);
            this.tabPage2.Controls.Add(this.txtDestino);
            this.tabPage2.Controls.Add(this.cbLugarPartida);
            this.tabPage2.Controls.Add(this.cbLugarDestino);
            this.tabPage2.Controls.Add(this.cbPorFechaYHora);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(739, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filtros";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(31, 375);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 20;
            this.gMapControl1.MinZoom = 10;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(661, 205);
            this.gMapControl1.TabIndex = 31;
            this.gMapControl1.Zoom = 10D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirmar servicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Mostrar todos los servicios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(452, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(576, 100);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(116, 23);
            this.btFiltrar.TabIndex = 28;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(199, 29);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // dataFiltros
            // 
            this.dataFiltros.AllowUserToAddRows = false;
            this.dataFiltros.AllowUserToDeleteRows = false;
            this.dataFiltros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFiltros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreUsu,
            this.Dest,
            this.Parti,
            this.fechayho,
            this.TelefonoUsu});
            this.dataFiltros.Location = new System.Drawing.Point(31, 168);
            this.dataFiltros.Name = "dataFiltros";
            this.dataFiltros.ReadOnly = true;
            this.dataFiltros.Size = new System.Drawing.Size(661, 201);
            this.dataFiltros.TabIndex = 9;
            this.dataFiltros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NombreUsu
            // 
            this.NombreUsu.HeaderText = "Nombre ";
            this.NombreUsu.Name = "NombreUsu";
            this.NombreUsu.ReadOnly = true;
            // 
            // Dest
            // 
            this.Dest.HeaderText = "Destino";
            this.Dest.Name = "Dest";
            this.Dest.ReadOnly = true;
            // 
            // Parti
            // 
            this.Parti.HeaderText = "Partida";
            this.Parti.Name = "Parti";
            this.Parti.ReadOnly = true;
            // 
            // fechayho
            // 
            this.fechayho.HeaderText = "Fecha y Hora de salida";
            this.fechayho.Name = "fechayho";
            this.fechayho.ReadOnly = true;
            // 
            // TelefonoUsu
            // 
            this.TelefonoUsu.HeaderText = "Telefono";
            this.TelefonoUsu.Name = "TelefonoUsu";
            this.TelefonoUsu.ReadOnly = true;
            // 
            // txtPartida
            // 
            this.txtPartida.AcceptsTab = true;
            this.txtPartida.Enabled = false;
            this.txtPartida.Location = new System.Drawing.Point(199, 50);
            this.txtPartida.Name = "txtPartida";
            this.txtPartida.Size = new System.Drawing.Size(493, 20);
            this.txtPartida.TabIndex = 8;
            // 
            // txtDestino
            // 
            this.txtDestino.AcceptsTab = true;
            this.txtDestino.Enabled = false;
            this.txtDestino.Location = new System.Drawing.Point(199, 73);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(493, 20);
            this.txtDestino.TabIndex = 7;
            // 
            // cbLugarPartida
            // 
            this.cbLugarPartida.AutoSize = true;
            this.cbLugarPartida.Location = new System.Drawing.Point(31, 52);
            this.cbLugarPartida.Name = "cbLugarPartida";
            this.cbLugarPartida.Size = new System.Drawing.Size(145, 17);
            this.cbLugarPartida.TabIndex = 4;
            this.cbLugarPartida.Text = "Filtrar por lugar de partida";
            this.cbLugarPartida.UseVisualStyleBackColor = true;
            this.cbLugarPartida.CheckedChanged += new System.EventHandler(this.cbLugarPartida_CheckedChanged);
            // 
            // cbLugarDestino
            // 
            this.cbLugarDestino.AutoSize = true;
            this.cbLugarDestino.Location = new System.Drawing.Point(31, 75);
            this.cbLugarDestino.Name = "cbLugarDestino";
            this.cbLugarDestino.Size = new System.Drawing.Size(147, 17);
            this.cbLugarDestino.TabIndex = 2;
            this.cbLugarDestino.Text = "Filtrar por lugar de destino";
            this.cbLugarDestino.UseVisualStyleBackColor = true;
            this.cbLugarDestino.CheckedChanged += new System.EventHandler(this.cbLugarDestino_CheckedChanged);
            // 
            // cbPorFechaYHora
            // 
            this.cbPorFechaYHora.AutoSize = true;
            this.cbPorFechaYHora.Location = new System.Drawing.Point(31, 29);
            this.cbPorFechaYHora.Name = "cbPorFechaYHora";
            this.cbPorFechaYHora.Size = new System.Drawing.Size(131, 17);
            this.cbPorFechaYHora.TabIndex = 0;
            this.cbPorFechaYHora.Text = "Filtrar por hora y fecha";
            this.cbPorFechaYHora.UseVisualStyleBackColor = true;
            this.cbPorFechaYHora.CheckedChanged += new System.EventHandler(this.cbPorFechaYHora_CheckedChanged);
            // 
            // btnAtrasR
            // 
            this.btnAtrasR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtrasR.AutoSize = true;
            this.btnAtrasR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAtrasR.Location = new System.Drawing.Point(789, 571);
            this.btnAtrasR.Name = "btnAtrasR";
            this.btnAtrasR.Size = new System.Drawing.Size(41, 23);
            this.btnAtrasR.TabIndex = 1;
            this.btnAtrasR.Text = "Atrás";
            this.btnAtrasR.UseVisualStyleBackColor = true;
            this.btnAtrasR.Visible = false;
            this.btnAtrasR.Click += new System.EventHandler(this.btnAtrasR_Click);
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.Width = 206;
            // 
            // Partida
            // 
            this.Partida.HeaderText = "Partida";
            this.Partida.Name = "Partida";
            this.Partida.Width = 206;
            // 
            // gmapRecomendacion
            // 
            this.gmapRecomendacion.AutoSize = true;
            this.gmapRecomendacion.Bearing = 0F;
            this.gmapRecomendacion.CanDragMap = true;
            this.gmapRecomendacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmapRecomendacion.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapRecomendacion.GrayScaleMode = false;
            this.gmapRecomendacion.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmapRecomendacion.LevelsKeepInMemmory = 5;
            this.gmapRecomendacion.Location = new System.Drawing.Point(3, 3);
            this.gmapRecomendacion.MarkersEnabled = true;
            this.gmapRecomendacion.MaxZoom = 20;
            this.gmapRecomendacion.MinimumSize = new System.Drawing.Size(455, 331);
            this.gmapRecomendacion.MinZoom = 10;
            this.gmapRecomendacion.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmapRecomendacion.Name = "gmapRecomendacion";
            this.gmapRecomendacion.NegativeMode = false;
            this.gmapRecomendacion.PolygonsEnabled = true;
            this.gmapRecomendacion.RetryLoadTile = 0;
            this.gmapRecomendacion.RoutesEnabled = true;
            this.gmapRecomendacion.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmapRecomendacion.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapRecomendacion.ShowTileGridLines = false;
            this.gmapRecomendacion.Size = new System.Drawing.Size(733, 514);
            this.gmapRecomendacion.TabIndex = 0;
            this.gmapRecomendacion.Zoom = 12D;
            this.gmapRecomendacion.Load += new System.EventHandler(this.gmapRecomendacion_Load);
            // 
            // col1
            // 
            this.col1.HeaderText = "Id servicio";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Id dueño servicio";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Placa vehiculo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Color";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Información adicional vehiculo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Partida";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Destino";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Fecha y hora salida";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // RecomendacionUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(842, 606);
            this.Controls.Add(this.btnAtrasR);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecomendacionUsu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Recomendaciones";
            this.Load += new System.EventHandler(this.RecomendacionUsu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFiltros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbLugarPartida;
        private System.Windows.Forms.CheckBox cbLugarDestino;
        private System.Windows.Forms.CheckBox cbPorFechaYHora;
        private System.Windows.Forms.TextBox txtPartida;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnAtrasR;
        private System.Windows.Forms.DataGridView dataFiltros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partida;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parti;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechayho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoUsu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button5;
        private GMap.NET.WindowsForms.GMapControl gmapRecomendacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}