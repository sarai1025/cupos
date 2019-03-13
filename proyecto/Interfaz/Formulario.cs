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
    public partial class Formulario : Form
    {

        private Login principal;


        public Formulario(Login prin)
        {
            principal = prin;
            InitializeComponent();
        }

        private void btRecomendaciones_Click(object sender, EventArgs e)
        {
            RecomendacionUsu fmrecomendar = new RecomendacionUsu(principal);
            fmrecomendar.Show();
            this.Close();
        }

        private void btComprarVender_Click(object sender, EventArgs e)
        {
            HacerServicioVENTA fmservicios = new HacerServicioVENTA(principal);
            fmservicios.Show();
            this.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //Login formlogin = new Login();
            //formlogin.Refresh();

            this.Close();
            }

        private void btInfoUsuario_Click(object sender, EventArgs e)
        {            
            if (principal.UsuarioActual.Tipo.Equals("c"))
            {
                InfoUsuarioCON con = new InfoUsuarioCON(principal);
                con.Show();

            }
            else
            {
                infoUsuarioSIN sin = new infoUsuarioSIN(principal);
                sin.Show();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HacerServicioVENTA fmservicios = new HacerServicioVENTA(principal);
            fmservicios.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           HacerServicioCOMPRA fmservicios = new HacerServicioCOMPRA(principal);
            fmservicios.Show();
            this.Close();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            if (principal.UsuarioActual.Tipo.Equals("c"))
            {             

            }
            else
            {
                btVenta.Enabled = false;
            }
        }
    }
}
