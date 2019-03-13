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
    public partial class AdminListaServicios : Form
    {
        private Login principal;
        public AdminListaServicios(Login prin)
        {
            InitializeComponent();
            principal = prin;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminListaServicios_Load(object sender, EventArgs e)
        {
            for (int i =0; i<principal.Sirtru.Servicios.Count; i++)
            {
                dataGridView1.Rows.Add(principal.Sirtru.Servicios[i].Solicitante.Id, principal.Sirtru.Servicios[i].IdServicio,principal.Sirtru.Servicios[i].TipoServ,principal.Sirtru.Servicios[i].TiempoSalida,principal.Sirtru.Servicios[i].Direccpartida1, principal.Sirtru.Servicios[i].Direccdestino1 );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
