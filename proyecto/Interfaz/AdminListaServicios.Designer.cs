﻿namespace Interfaz
{
    partial class AdminListaServicios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btCerrar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDeServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idServicio,
            this.tipoDeServicio,
            this.FechaServicio,
            this.Part,
            this.Dest});
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 552);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(392, 580);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 1;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Id Usuario";
            this.id.Name = "id";
            // 
            // idServicio
            // 
            this.idServicio.HeaderText = "Id del Servicio";
            this.idServicio.Name = "idServicio";
            // 
            // tipoDeServicio
            // 
            this.tipoDeServicio.HeaderText = "TipoDeServicio";
            this.tipoDeServicio.Name = "tipoDeServicio";
            // 
            // FechaServicio
            // 
            this.FechaServicio.HeaderText = "Fecha del Servicio";
            this.FechaServicio.Name = "FechaServicio";
            // 
            // Part
            // 
            this.Part.HeaderText = "Lugar de Partida";
            this.Part.Name = "Part";
            // 
            // Dest
            // 
            this.Dest.HeaderText = "Lugar de destino";
            this.Dest.Name = "Dest";
            // 
            // AdminListaServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 615);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminListaServicios";
            this.Text = "AdminListaServicios";
            this.Load += new System.EventHandler(this.AdminListaServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDeServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dest;
    }
}