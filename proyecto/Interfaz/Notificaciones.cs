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
    public partial class Notificaciones : Form
    {
        private Login principal;

        public Notificaciones(Login p)
        {
            InitializeComponent();
            principal = p;
            button1.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;

        }

        private void Notificaciones_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            for (int i = 0; i < principal.UsuarioActual.Notificaciones.Count; i++)
            {
                string[] infoNoti = principal.UsuarioActual.Notificaciones[i].Split('/');
                dataGridView1.Rows.Add(infoNoti[0], infoNoti[1], infoNoti[2], infoNoti[3]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["Column1"].Value.ToString().Equals("False"))
            {
                var result = MessageBox.Show("¿Desea aceptar esta solicitud de servicio?", "¿?",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question);
                Usuario usuario = principal.Sirtru.Usuarios[Int32.Parse(dataGridView1.CurrentRow.Cells["Column3"].Value.ToString())];

                if (result == DialogResult.Yes)
                {
                    usuario.Notificaciones.Add(true + "/" + dataGridView1.CurrentRow.Cells["Column3"].Value.ToString() + "/" + dataGridView1.CurrentRow.Cells["Column2"].Value.ToString() + "/" + "El usuario " + principal.UsuarioActual.Nombre + " acepto su solicitud de servicio.\nPara más información comunicarse al: " + principal.UsuarioActual.NumeroTelefono);
                    principal.Sirtru.Servicios[Int32.Parse(dataGridView1.CurrentRow.Cells["Column2"].Value.ToString())].Reservados.Add(usuario);
                }
                else
                {
                    usuario.Notificaciones.Add(true + "/" + dataGridView1.CurrentRow.Cells["Column3"].Value.ToString() + "/" + dataGridView1.CurrentRow.Cells["Column2"].Value.ToString() + "/" + "El usuario " + principal.UsuarioActual.Nombre + " no acepto su solicitud de servicio");
                    principal.Sirtru.Servicios[Int32.Parse(dataGridView1.CurrentRow.Cells["Column2"].Value.ToString())].Cupos += 1;
                }

                dataGridView1.CurrentRow.Cells["Column1"].Value = "true";
            }
            else
            {
                MessageBox.Show("Ya respondio a esta solicitud");
            }
        }
    }
}
