namespace Interfaz
{
    partial class infoUsuarioSIN
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbFoto = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gMapPuntos = new GMap.NET.WindowsForms.GMapControl();
            this.dataPuntos = new System.Windows.Forms.DataGridView();
            this.Partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPuntos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // lbFoto
            // 
            this.lbFoto.AutoSize = true;
            this.lbFoto.Location = new System.Drawing.Point(341, 33);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(31, 13);
            this.lbFoto.TabIndex = 2;
            this.lbFoto.Text = "Foto:";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(29, 121);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(52, 13);
            this.lbTel.TabIndex = 3;
            this.lbTel.Text = "Telefono:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(29, 84);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "ID:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(29, 52);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(82, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(256, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(82, 118);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(256, 20);
            this.txtTel.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(82, 81);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(256, 20);
            this.txtID.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(344, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 85);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // gMapPuntos
            // 
            this.gMapPuntos.Bearing = 0F;
            this.gMapPuntos.CanDragMap = true;
            this.gMapPuntos.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapPuntos.GrayScaleMode = false;
            this.gMapPuntos.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapPuntos.LevelsKeepInMemmory = 5;
            this.gMapPuntos.Location = new System.Drawing.Point(9, 217);
            this.gMapPuntos.MarkersEnabled = true;
            this.gMapPuntos.MaxZoom = 20;
            this.gMapPuntos.MinZoom = 10;
            this.gMapPuntos.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapPuntos.Name = "gMapPuntos";
            this.gMapPuntos.NegativeMode = false;
            this.gMapPuntos.PolygonsEnabled = true;
            this.gMapPuntos.RetryLoadTile = 0;
            this.gMapPuntos.RoutesEnabled = true;
            this.gMapPuntos.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapPuntos.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapPuntos.ShowTileGridLines = false;
            this.gMapPuntos.Size = new System.Drawing.Size(455, 150);
            this.gMapPuntos.TabIndex = 11;
            this.gMapPuntos.Zoom = 12D;
            this.gMapPuntos.Load += new System.EventHandler(this.gMapPuntos_Load);
            // 
            // dataPuntos
            // 
            this.dataPuntos.AllowUserToAddRows = false;
            this.dataPuntos.AllowUserToOrderColumns = true;
            this.dataPuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Partida,
            this.Destino,
            this.HoraSalida});
            this.dataPuntos.Location = new System.Drawing.Point(9, 45);
            this.dataPuntos.MultiSelect = false;
            this.dataPuntos.Name = "dataPuntos";
            this.dataPuntos.ReadOnly = true;
            this.dataPuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPuntos.Size = new System.Drawing.Size(455, 166);
            this.dataPuntos.StandardTab = true;
            this.dataPuntos.TabIndex = 13;
            this.dataPuntos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPuntos_CellContentClick);
            this.dataPuntos.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataPuntos_RowStateChanged);
            // 
            // Partida
            // 
            this.Partida.HeaderText = "Destino";
            this.Partida.Name = "Partida";
            this.Partida.ReadOnly = true;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Partida";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            // 
            // HoraSalida
            // 
            this.HoraSalida.HeaderText = "Fecha y hora de Salida";
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataPuntos);
            this.groupBox1.Controls.Add(this.gMapPuntos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 411);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puntos (Destino, Partida)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Editar información";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // infoUsuarioSIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 643);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.lbFoto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "infoUsuarioSIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "infoUsuarioSIN";
            this.Load += new System.EventHandler(this.infoUsuarioSIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPuntos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFoto;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GMap.NET.WindowsForms.GMapControl gMapPuntos;
        private System.Windows.Forms.DataGridView dataPuntos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.Button button1;
    }
}