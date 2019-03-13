using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mundo;

namespace Interfaz
{
    public partial class Admin : Form
    {

        private Login principal;


        public Admin(Login prin)
        {
            principal = prin;
            InitializeComponent();
        }


        private void Admin_Load(object sender, EventArgs e)
        {
            dataGridView1.Height = this.Height - 68;
            dataGridView1.Width = (this.Width / 2) - 200;

            for (int i = 0; i < principal.Sirtru.Usuarios.Count; i++)
            {
                if (principal.Sirtru.Usuarios[i].Tipo.Equals("c"))
                {
                    dataGridView1.Rows.Add(principal.Sirtru.Usuarios[i].Id, principal.Sirtru.Usuarios[i].Nombre, principal.Sirtru.Usuarios[i].ServiciosRegistrados.Count, "Si");
                }
                else
                {
                    dataGridView1.Rows.Add(principal.Sirtru.Usuarios[i].Id, principal.Sirtru.Usuarios[i].Nombre, principal.Sirtru.Usuarios[i].ServiciosRegistrados.Count, "No");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void graficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void listaDeServiciosT_Click(object sender, EventArgs e)
        {
            AdminListaServicios listServicios = new AdminListaServicios(principal);
            Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            listServicios.Height = this.Height - 68;
            //listServicios.Width = (this.Width / 2) - 400;
            listServicios.Show();
            /*listServicios.MdiParent = this;
            listServicios.Show();
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);

            //Usuario us = principal.Sirtru.buscarUsuario(id);

            if (principal.Sirtru.buscarUsuario(id).Tipo.Equals("c"))
            {
                principal.UsuarioActual = principal.Sirtru.buscarUsuario(id);
                InfoUsuarioCON info = new InfoUsuarioCON(principal);
                Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;

                info.Width = (this.Width / 2) + 170;
                info.Height = this.Height - 68;

                Int32 ancho = (this.Width / 2) - 190;
                info.Location = new Point(ancho, 0);
                info.MdiParent = this;
                info.Show();
            }
            else if (principal.Sirtru.buscarUsuario(id).Tipo.Equals("s"))
            {
                principal.UsuarioActual = principal.Sirtru.buscarUsuario(id);
                infoUsuarioSIN info = new infoUsuarioSIN(principal);
                Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;

                info.Width = (this.Width / 2) + 170;
                info.Height = this.Height - 68;

                Int32 ancho = (this.Width / 2) - 190;
                info.Location = new Point(ancho, 0);
                info.MdiParent = this;
                info.Show();
            }
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string contraseña = Microsoft.VisualBasic.Interaction.InputBox("Nueva contraseña: ");
            principal.Sirtru.ContraAdmin = contraseña;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void masServicios_Click(object sender, EventArgs e)
        {

            }

        private void usuarioConMasServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario mayorUsu = principal.Sirtru.Usuarios[0];

            int iNumeroMayor, iPosicion;

            //Presuponemos que el numero mayor es el primero
            iNumeroMayor = principal.Sirtru.Usuarios[0].ServiciosRegistrados.Count;
            iPosicion = 0;

            for (int i = 1; i < principal.Sirtru.Usuarios.Count ; i++)
            {
                if (principal.Sirtru.Usuarios[i].ServiciosRegistrados.Count > iNumeroMayor)
                {
                    iNumeroMayor = principal.Sirtru.Usuarios[i].ServiciosRegistrados.Count;
                    iPosicion = i;
                    mayorUsu = principal.Sirtru.Usuarios[i];
                }

            }

            MessageBox.Show("El usuario con mayor número de servicios registrados es :  " + mayorUsu.Nombre + "  con id : " + mayorUsu.Id + "  y con cantidad de servicios de:  " + mayorUsu.ServiciosRegistrados.Count, "Información adicional", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void númeroDeServiciosRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           int num = principal.Sirtru.Servicios.Count;
            MessageBox.Show("La cantidad de servicios registrados es :  " + num , "Información adicional", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void númeroDeUsuariosRegistradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = principal.Sirtru.Usuarios.Count;
            MessageBox.Show("La cantidad de Usuarios registrados es :  " + num, "Información adicional", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficaUsuariosMasActivos gra = new GraficaUsuariosMasActivos(principal);
            Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;

            gra.Width = (this.Width / 2) + 170;
            gra.Height = this.Height - 68;

            Int32 ancho = (this.Width / 2) - 190;
            gra.Location = new Point(ancho, 0);
            gra.MdiParent = this;
            gra.Show();
        }

        private void usuariosVsCantidadDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficaUsuVsNumServ gra = new GraficaUsuVsNumServ(principal);
            Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;

            gra.Width = (this.Width / 2) + 170;
            gra.Height = this.Height - 68;

            Int32 ancho = (this.Width / 2) - 190;
            gra.Location = new Point(ancho, 0);
            gra.MdiParent = this;
            gra.Show();
        }

        private void serviciosDeCompraVsServiciosDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficaVentsVsCompra gra = new GraficaVentsVsCompra(principal);
            Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;

            gra.Width = (this.Width / 2) + 170;
            gra.Height = this.Height - 68;

            Int32 ancho = (this.Width / 2) - 190;
            gra.Location = new Point(ancho, 0);
            gra.MdiParent = this;
            gra.Show();
        }

        private void mesVsCantidadServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficaMesVsNumServicios gra = new GraficaMesVsNumServicios(principal);
            Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;

            gra.Width = (this.Width / 2) + 170;
            gra.Height = this.Height - 68;

            Int32 ancho = (this.Width / 2) - 190;
            gra.Location = new Point(ancho, 0);
            gra.MdiParent = this;
            gra.Show();
        }
    }
}
