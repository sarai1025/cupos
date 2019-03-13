namespace Interfaz
{
    partial class Admin
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
            this.idUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSerRegi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeServiciosT = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioConMasServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.númeroDeServiciosRegistradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.númeroDeUsuariosRegistradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosVsCantidadDeServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosDeCompraVsServiciosDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesVsCantidadServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsu,
            this.NomUsu,
            this.NumSerRegi,
            this.Carro});
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(322, 316);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idUsu
            // 
            this.idUsu.HeaderText = "id de usuario";
            this.idUsu.Name = "idUsu";
            // 
            // NomUsu
            // 
            this.NomUsu.HeaderText = "Nombre";
            this.NomUsu.Name = "NomUsu";
            // 
            // NumSerRegi
            // 
            this.NumSerRegi.HeaderText = "# Servicios Registrados";
            this.NumSerRegi.Name = "NumSerRegi";
            // 
            // Carro
            // 
            this.Carro.HeaderText = "¿Tiene carro?";
            this.Carro.Name = "Carro";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // listaDeServiciosT
            // 
            this.listaDeServiciosT.Name = "listaDeServiciosT";
            this.listaDeServiciosT.Size = new System.Drawing.Size(107, 20);
            this.listaDeServiciosT.Text = "Lista de servicios";
            this.listaDeServiciosT.Click += new System.EventHandler(this.listaDeServiciosT_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioConMasServiciosToolStripMenuItem,
            this.númeroDeServiciosRegistradosToolStripMenuItem,
            this.númeroDeUsuariosRegistradorToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // usuarioConMasServiciosToolStripMenuItem
            // 
            this.usuarioConMasServiciosToolStripMenuItem.Name = "usuarioConMasServiciosToolStripMenuItem";
            this.usuarioConMasServiciosToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.usuarioConMasServiciosToolStripMenuItem.Text = "Usuario con mas servicios";
            this.usuarioConMasServiciosToolStripMenuItem.Click += new System.EventHandler(this.usuarioConMasServiciosToolStripMenuItem_Click);
            // 
            // númeroDeServiciosRegistradosToolStripMenuItem
            // 
            this.númeroDeServiciosRegistradosToolStripMenuItem.Name = "númeroDeServiciosRegistradosToolStripMenuItem";
            this.númeroDeServiciosRegistradosToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.númeroDeServiciosRegistradosToolStripMenuItem.Text = "Número de servicios registrados";
            this.númeroDeServiciosRegistradosToolStripMenuItem.Click += new System.EventHandler(this.númeroDeServiciosRegistradosToolStripMenuItem_Click);
            // 
            // númeroDeUsuariosRegistradorToolStripMenuItem
            // 
            this.númeroDeUsuariosRegistradorToolStripMenuItem.Name = "númeroDeUsuariosRegistradorToolStripMenuItem";
            this.númeroDeUsuariosRegistradorToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.númeroDeUsuariosRegistradorToolStripMenuItem.Text = "Número de usuarios registrador";
            this.númeroDeUsuariosRegistradorToolStripMenuItem.Click += new System.EventHandler(this.númeroDeUsuariosRegistradorToolStripMenuItem_Click);
            // 
            // graficasToolStripMenuItem
            // 
            this.graficasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosVsCantidadDeServiciosToolStripMenuItem,
            this.serviciosDeCompraVsServiciosDeVentaToolStripMenuItem,
            this.mesVsCantidadServiciosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.graficasToolStripMenuItem.Name = "graficasToolStripMenuItem";
            this.graficasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.graficasToolStripMenuItem.Text = "Graficas";
            // 
            // usuariosVsCantidadDeServiciosToolStripMenuItem
            // 
            this.usuariosVsCantidadDeServiciosToolStripMenuItem.Name = "usuariosVsCantidadDeServiciosToolStripMenuItem";
            this.usuariosVsCantidadDeServiciosToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.usuariosVsCantidadDeServiciosToolStripMenuItem.Text = "Usuarios Vs CantidadDeServicios";
            this.usuariosVsCantidadDeServiciosToolStripMenuItem.Click += new System.EventHandler(this.usuariosVsCantidadDeServiciosToolStripMenuItem_Click);
            // 
            // serviciosDeCompraVsServiciosDeVentaToolStripMenuItem
            // 
            this.serviciosDeCompraVsServiciosDeVentaToolStripMenuItem.Name = "serviciosDeCompraVsServiciosDeVentaToolStripMenuItem";
            this.serviciosDeCompraVsServiciosDeVentaToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.serviciosDeCompraVsServiciosDeVentaToolStripMenuItem.Text = "ServiciosDeCompra Vs ServiciosDeVenta";
            this.serviciosDeCompraVsServiciosDeVentaToolStripMenuItem.Click += new System.EventHandler(this.serviciosDeCompraVsServiciosDeVentaToolStripMenuItem_Click);
            // 
            // mesVsCantidadServiciosToolStripMenuItem
            // 
            this.mesVsCantidadServiciosToolStripMenuItem.Name = "mesVsCantidadServiciosToolStripMenuItem";
            this.mesVsCantidadServiciosToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.mesVsCantidadServiciosToolStripMenuItem.Text = "Mes vs CantidadServicios";
            this.mesVsCantidadServiciosToolStripMenuItem.Click += new System.EventHandler(this.mesVsCantidadServiciosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios Mas activos";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.listaDeServiciosT,
            this.reportesToolStripMenuItem,
            this.graficasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(359, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSerRegi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carro;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeServiciosT;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioConMasServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem númeroDeServiciosRegistradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem númeroDeUsuariosRegistradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosVsCantidadDeServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosDeCompraVsServiciosDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesVsCantidadServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}