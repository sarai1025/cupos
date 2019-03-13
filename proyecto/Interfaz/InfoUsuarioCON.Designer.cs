namespace Interfaz
{
    partial class InfoUsuarioCON
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbFoto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCarro = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gMapRutas = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataRutas = new System.Windows.Forms.DataGridView();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(35, 47);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(35, 116);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(52, 13);
            this.lbTelefono.TabIndex = 1;
            this.lbTelefono.Text = "Telefono:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(35, 78);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "ID:";
            // 
            // lbFoto
            // 
            this.lbFoto.AutoSize = true;
            this.lbFoto.Location = new System.Drawing.Point(363, 19);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(31, 13);
            this.lbFoto.TabIndex = 3;
            this.lbFoto.Text = "Foto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(366, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 84);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbCarro
            // 
            this.lbCarro.AutoSize = true;
            this.lbCarro.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarro.Location = new System.Drawing.Point(12, 151);
            this.lbCarro.Name = "lbCarro";
            this.lbCarro.Size = new System.Drawing.Size(41, 18);
            this.lbCarro.TabIndex = 5;
            this.lbCarro.Text = "Carro";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(12, 19);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(56, 18);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(40, 176);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(37, 13);
            this.lbPlaca.TabIndex = 7;
            this.lbPlaca.Text = "Placa:";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(40, 206);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(34, 13);
            this.lbColor.TabIndex = 8;
            this.lbColor.Text = "Color:";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(40, 230);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(45, 13);
            this.lbModelo.TabIndex = 9;
            this.lbModelo.Text = "Modelo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(86, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(86, 109);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(260, 20);
            this.txtTel.TabIndex = 11;
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(86, 227);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(260, 20);
            this.txtModelo.TabIndex = 12;
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(86, 201);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(260, 20);
            this.txtColor.TabIndex = 13;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Location = new System.Drawing.Point(86, 173);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(260, 20);
            this.txtPlaca.TabIndex = 14;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(86, 71);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(260, 20);
            this.txtID.TabIndex = 15;
            // 
            // gMapRutas
            // 
            this.gMapRutas.Bearing = 0F;
            this.gMapRutas.CanDragMap = true;
            this.gMapRutas.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapRutas.GrayScaleMode = false;
            this.gMapRutas.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapRutas.LevelsKeepInMemmory = 5;
            this.gMapRutas.Location = new System.Drawing.Point(6, 195);
            this.gMapRutas.MarkersEnabled = true;
            this.gMapRutas.MaxZoom = 20;
            this.gMapRutas.MinZoom = 10;
            this.gMapRutas.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapRutas.Name = "gMapRutas";
            this.gMapRutas.NegativeMode = false;
            this.gMapRutas.PolygonsEnabled = true;
            this.gMapRutas.RetryLoadTile = 0;
            this.gMapRutas.RoutesEnabled = true;
            this.gMapRutas.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapRutas.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapRutas.ShowTileGridLines = false;
            this.gMapRutas.Size = new System.Drawing.Size(461, 148);
            this.gMapRutas.TabIndex = 18;
            this.gMapRutas.Zoom = 12D;
            this.gMapRutas.Load += new System.EventHandler(this.gMapRutas_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataRutas);
            this.groupBox1.Controls.Add(this.gMapRutas);
            this.groupBox1.Location = new System.Drawing.Point(12, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 393);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rutas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataRutas
            // 
            this.dataRutas.AllowUserToAddRows = false;
            this.dataRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Destino,
            this.Partida,
            this.HoraSalida});
            this.dataRutas.Location = new System.Drawing.Point(6, 19);
            this.dataRutas.Name = "dataRutas";
            this.dataRutas.ReadOnly = true;
            this.dataRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRutas.Size = new System.Drawing.Size(461, 170);
            this.dataRutas.TabIndex = 20;
            this.dataRutas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            // 
            // Partida
            // 
            this.Partida.HeaderText = "Partida";
            this.Partida.Name = "Partida";
            this.Partida.ReadOnly = true;
            // 
            // HoraSalida
            // 
            this.HoraSalida.HeaderText = "Tiempo de Salida";
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Editar información";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InfoUsuarioCON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 687);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbCarro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbFoto);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoUsuarioCON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InfoUsuario";
            this.Load += new System.EventHandler(this.InfoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCarro;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtID;
        private GMap.NET.WindowsForms.GMapControl gMapRutas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataRutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.Button button2;
    }
}