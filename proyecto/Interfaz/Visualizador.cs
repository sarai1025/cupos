using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Visualizador : Form
    {

        private Login principal;
       
        public Visualizador(Login prin)
        {
            InitializeComponent();
            principal = prin;
        }

        private void Visualizador_Load(object sender, EventArgs e)
        {
            if (principal.UsuarioActual.Tipo.Equals("c"))
            {
                InfoUsuarioCON con = new InfoUsuarioCON(principal);

                Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
                con.Height = this.Height-68;
                con.Width = (this.Width / 2) - 200;
                con.MdiParent = this;
                con.Show();
                
            }
            else
            {
                infoUsuarioSIN sin = new infoUsuarioSIN(principal);

                Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
                sin.Height = this.Height-68;
                sin.Width = (this.Width / 2) - 200;
                sin.MdiParent = this;
                sin.Show();

                ventaToolStripMenuItem.Visible = false;
            }
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            HacerServicioCOMPRA compra = new HacerServicioCOMPRA(principal);
            Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;

            compra.Width = (this.Width / 2) + 170;
            compra.Height = this.Height-68;

            Int32 ancho = (this.Width / 2) - 190;
            compra.Location = new Point(ancho, 0);
            compra.MdiParent = this;
            compra.Show();

        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                HacerServicioVENTA venta = new HacerServicioVENTA(principal);
                Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;

                venta.Width = (this.Width / 2) + 170;
                venta.Height = this.Height - 68;

                Int32 ancho = (this.Width / 2) - 190;
                venta.Location = new Point(ancho, 0);
                venta.MdiParent = this;
                venta.Show();

          

        }

        private void comprarVenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecomendacionUsu recomendaciones = new RecomendacionUsu(principal);
            Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;

            recomendaciones.Width = (this.Width / 2) + 170;
            recomendaciones.Height = this.Height-68;

            Int32 ancho = (this.Width / 2) - 190;
            recomendaciones.Location = new Point(ancho, 0);
            recomendaciones.MdiParent = this;
            recomendaciones.Show();


        }

        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notificaciones noti = new Notificaciones(principal);
            Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;

            noti.Width = (this.Width / 2) + 170;
            noti.Height = this.Height - 68;

            Int32 ancho = (this.Width / 2) - 190;
            noti.Location = new Point(ancho, 0);
            noti.MdiParent = this;
            noti.Show();
        }
    }
}
