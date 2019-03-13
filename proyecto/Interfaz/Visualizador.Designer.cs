namespace Interfaz
{
    partial class Visualizador
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarVenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeSirtruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionalidadesToolStripMenuItem,
            this.notificacionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcionalidadesToolStripMenuItem
            // 
            this.funcionalidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarServicioToolStripMenuItem,
            this.comprarVenderToolStripMenuItem});
            this.funcionalidadesToolStripMenuItem.Name = "funcionalidadesToolStripMenuItem";
            this.funcionalidadesToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.funcionalidadesToolStripMenuItem.Text = "&Funcionalidades";
            // 
            // registrarServicioToolStripMenuItem
            // 
            this.registrarServicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem,
            this.ventaToolStripMenuItem});
            this.registrarServicioToolStripMenuItem.Name = "registrarServicioToolStripMenuItem";
            this.registrarServicioToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.registrarServicioToolStripMenuItem.Text = "Registrar servicio";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.compraToolStripMenuItem.Text = "Compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ventaToolStripMenuItem.Text = "Venta";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // comprarVenderToolStripMenuItem
            // 
            this.comprarVenderToolStripMenuItem.Name = "comprarVenderToolStripMenuItem";
            this.comprarVenderToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.comprarVenderToolStripMenuItem.Text = "Comprar/Vender";
            this.comprarVenderToolStripMenuItem.Click += new System.EventHandler(this.comprarVenderToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeSirtruToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // acercaDeSirtruToolStripMenuItem
            // 
            this.acercaDeSirtruToolStripMenuItem.Name = "acercaDeSirtruToolStripMenuItem";
            this.acercaDeSirtruToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.acercaDeSirtruToolStripMenuItem.Text = "Acerca de sirtru";
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            this.notificacionesToolStripMenuItem.Click += new System.EventHandler(this.notificacionesToolStripMenuItem_Click);
            // 
            // Visualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Visualizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sirtru";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Visualizador_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funcionalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarVenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeSirtruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificacionesToolStripMenuItem;
    }
}