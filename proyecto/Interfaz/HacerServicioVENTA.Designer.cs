namespace Interfaz
{
    partial class HacerServicioVENTA
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
           // base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gmapServicios = new GMap.NET.WindowsForms.GMapControl();
            this.lbHora = new System.Windows.Forms.Label();
            this.btVender = new System.Windows.Forms.Button();
            this.lbCupos = new System.Windows.Forms.Label();
            this.cupoos = new System.Windows.Forms.NumericUpDown();
            this.btnAtrasS = new System.Windows.Forms.Button();
            this.rbtnIcesi = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelseleccionar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPartida = new System.Windows.Forms.TextBox();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.btnRuta = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.lbFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnconfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupoos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.logo_voy_con_cupo_ancho;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // gmapServicios
            // 
            this.gmapServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmapServicios.Bearing = 0F;
            this.gmapServicios.CanDragMap = true;
            this.gmapServicios.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapServicios.GrayScaleMode = false;
            this.gmapServicios.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmapServicios.LevelsKeepInMemmory = 5;
            this.gmapServicios.Location = new System.Drawing.Point(12, 138);
            this.gmapServicios.MarkersEnabled = true;
            this.gmapServicios.MaxZoom = 20;
            this.gmapServicios.MinZoom = 4;
            this.gmapServicios.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmapServicios.Name = "gmapServicios";
            this.gmapServicios.NegativeMode = false;
            this.gmapServicios.PolygonsEnabled = true;
            this.gmapServicios.RetryLoadTile = 0;
            this.gmapServicios.RoutesEnabled = true;
            this.gmapServicios.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmapServicios.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapServicios.ShowTileGridLines = false;
            this.gmapServicios.Size = new System.Drawing.Size(467, 259);
            this.gmapServicios.TabIndex = 4;
            this.gmapServicios.Zoom = 15D;
            this.gmapServicios.Load += new System.EventHandler(this.gmapServicios_Load);
            this.gmapServicios.Click += new System.EventHandler(this.gmapServicios_Click);
            // 
            // lbHora
            // 
            this.lbHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(263, 29);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(80, 13);
            this.lbHora.TabIndex = 5;
            this.lbHora.Text = "Hora de Salida:";
            this.lbHora.Visible = false;
            // 
            // btVender
            // 
            this.btVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btVender.Location = new System.Drawing.Point(603, 623);
            this.btVender.Name = "btVender";
            this.btVender.Size = new System.Drawing.Size(120, 32);
            this.btVender.TabIndex = 11;
            this.btVender.Text = "Solicitar Venta";
            this.btVender.UseVisualStyleBackColor = true;
            this.btVender.Click += new System.EventHandler(this.btVender_Click);
            // 
            // lbCupos
            // 
            this.lbCupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCupos.AutoSize = true;
            this.lbCupos.Location = new System.Drawing.Point(610, 471);
            this.lbCupos.Name = "lbCupos";
            this.lbCupos.Size = new System.Drawing.Size(99, 13);
            this.lbCupos.TabIndex = 12;
            this.lbCupos.Text = "Cantidad de cupos:";
            // 
            // cupoos
            // 
            this.cupoos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cupoos.Location = new System.Drawing.Point(603, 490);
            this.cupoos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cupoos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cupoos.Name = "cupoos";
            this.cupoos.Size = new System.Drawing.Size(120, 20);
            this.cupoos.TabIndex = 13;
            this.cupoos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAtrasS
            // 
            this.btnAtrasS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtrasS.Location = new System.Drawing.Point(719, 674);
            this.btnAtrasS.Name = "btnAtrasS";
            this.btnAtrasS.Size = new System.Drawing.Size(75, 23);
            this.btnAtrasS.TabIndex = 14;
            this.btnAtrasS.Text = "Atrás";
            this.btnAtrasS.UseVisualStyleBackColor = true;
            this.btnAtrasS.Visible = false;
            // 
            // rbtnIcesi
            // 
            this.rbtnIcesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtnIcesi.AutoSize = true;
            this.rbtnIcesi.Location = new System.Drawing.Point(377, 112);
            this.rbtnIcesi.Name = "rbtnIcesi";
            this.rbtnIcesi.Size = new System.Drawing.Size(52, 17);
            this.rbtnIcesi.TabIndex = 18;
            this.rbtnIcesi.Text = "ICESI";
            this.rbtnIcesi.UseVisualStyleBackColor = true;
            this.rbtnIcesi.CheckedChanged += new System.EventHandler(this.rbtnIcesi_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(266, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Visible = false;
            // 
            // labelseleccionar
            // 
            this.labelseleccionar.AutoSize = true;
            this.labelseleccionar.Location = new System.Drawing.Point(27, 113);
            this.labelseleccionar.Name = "labelseleccionar";
            this.labelseleccionar.Size = new System.Drawing.Size(206, 13);
            this.labelseleccionar.TabIndex = 29;
            this.labelseleccionar.Text = "* Seleccione el punto de partida y llegada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Lugar de Partida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Lugar de Destino";
            // 
            // textBoxPartida
            // 
            this.textBoxPartida.Enabled = false;
            this.textBoxPartida.Location = new System.Drawing.Point(560, 154);
            this.textBoxPartida.Name = "textBoxPartida";
            this.textBoxPartida.Size = new System.Drawing.Size(172, 20);
            this.textBoxPartida.TabIndex = 32;
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Enabled = false;
            this.textBoxDestino.Location = new System.Drawing.Point(560, 201);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(172, 20);
            this.textBoxDestino.TabIndex = 33;
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(560, 252);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(172, 23);
            this.btnRuta.TabIndex = 34;
            this.btnRuta.Text = "Mostrar Ruta";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(18, 57);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 35;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(15, 29);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(119, 13);
            this.lbFecha.TabIndex = 36;
            this.lbFecha.Text = "Fecha y hora de Salida:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbHora);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.lbFecha);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 182);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha y hora";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(18, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Hora de llegada (aprox):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "lugar de partida:";
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(603, 112);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnconfirmar.TabIndex = 39;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // HacerServicioVENTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(830, 709);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.textBoxPartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelseleccionar);
            this.Controls.Add(this.rbtnIcesi);
            this.Controls.Add(this.btnAtrasS);
            this.Controls.Add(this.cupoos);
            this.Controls.Add(this.lbCupos);
            this.Controls.Add(this.btVender);
            this.Controls.Add(this.gmapServicios);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HacerServicioVENTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.HacerServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupoos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private GMap.NET.WindowsForms.GMapControl gmapServicios;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Button btVender;
        private System.Windows.Forms.Label lbCupos;
        private System.Windows.Forms.NumericUpDown cupoos;
        private System.Windows.Forms.Button btnAtrasS;
        private System.Windows.Forms.RadioButton rbtnIcesi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelseleccionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPartida;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnconfirmar;
    }
}