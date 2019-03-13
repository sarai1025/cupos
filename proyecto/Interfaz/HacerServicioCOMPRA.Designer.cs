namespace Interfaz
{
    partial class HacerServicioCOMPRA
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
            this.gMapServicio = new GMap.NET.WindowsForms.GMapControl();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.txtPartida = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lbPartida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelseleccionar = new System.Windows.Forms.Label();
            this.btAtras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapServicio
            // 
            this.gMapServicio.Bearing = 0F;
            this.gMapServicio.CanDragMap = true;
            this.gMapServicio.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapServicio.GrayScaleMode = false;
            this.gMapServicio.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapServicio.LevelsKeepInMemmory = 5;
            this.gMapServicio.Location = new System.Drawing.Point(54, 137);
            this.gMapServicio.MarkersEnabled = true;
            this.gMapServicio.MaxZoom = 20;
            this.gMapServicio.MinZoom = 10;
            this.gMapServicio.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapServicio.Name = "gMapServicio";
            this.gMapServicio.NegativeMode = false;
            this.gMapServicio.PolygonsEnabled = true;
            this.gMapServicio.RetryLoadTile = 0;
            this.gMapServicio.RoutesEnabled = true;
            this.gMapServicio.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapServicio.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapServicio.ShowTileGridLines = false;
            this.gMapServicio.Size = new System.Drawing.Size(557, 245);
            this.gMapServicio.TabIndex = 0;
            this.gMapServicio.Zoom = 12D;
            this.gMapServicio.Load += new System.EventHandler(this.gMapServicio_Load);
            this.gMapServicio.Click += new System.EventHandler(this.gMapServicio_Click_1);
            this.gMapServicio.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.gMapServicio_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(536, 106);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btConfirmar.TabIndex = 1;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // txtPartida
            // 
            this.txtPartida.Location = new System.Drawing.Point(637, 147);
            this.txtPartida.Name = "txtPartida";
            this.txtPartida.Size = new System.Drawing.Size(189, 20);
            this.txtPartida.TabIndex = 2;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(637, 220);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(189, 20);
            this.txtDestino.TabIndex = 3;
            // 
            // lbPartida
            // 
            this.lbPartida.AutoSize = true;
            this.lbPartida.Location = new System.Drawing.Point(634, 131);
            this.lbPartida.Name = "lbPartida";
            this.lbPartida.Size = new System.Drawing.Size(40, 13);
            this.lbPartida.TabIndex = 4;
            this.lbPartida.Text = "Partida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destino";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.UseWaitCursor = true;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(318, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.UseWaitCursor = true;
            this.dateTimePicker2.Visible = false;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hora de salida";
            this.label3.UseWaitCursor = true;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha y hora de salida:";
            this.label4.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 595);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Solicitar Compra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelseleccionar
            // 
            this.labelseleccionar.AutoSize = true;
            this.labelseleccionar.Location = new System.Drawing.Point(51, 108);
            this.labelseleccionar.Name = "labelseleccionar";
            this.labelseleccionar.Size = new System.Drawing.Size(169, 13);
            this.labelseleccionar.TabIndex = 11;
            this.labelseleccionar.Text = "Escoja puntos de partida y destino";
            // 
            // btAtras
            // 
            this.btAtras.Location = new System.Drawing.Point(508, 604);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(75, 23);
            this.btAtras.TabIndex = 12;
            this.btAtras.Text = "Atras";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Visible = false;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.logo_voy_con_cupo_ancho;
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(331, 106);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Icesi";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(65, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(546, 173);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha y Hora";
            this.groupBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "lugar de partida:";
            // 
            // HacerServicioCOMPRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(842, 639);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.labelseleccionar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPartida);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtPartida);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.gMapServicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HacerServicioCOMPRA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HaacerServicos";
            this.Load += new System.EventHandler(this.HacerServicioCOMPRA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapServicio;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.TextBox txtPartida;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lbPartida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelseleccionar;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}