using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Mundo;

namespace Interfaz
{
    public partial class Login : Form
    {
        private Sirtru sirtru;

        private Usuario usuarioActual;          

        public Usuario UsuarioActual { get => usuarioActual; set => usuarioActual = value; }
        public Sirtru Sirtru { get => sirtru; set => sirtru = value; }     

        public Login()
        {
            sirtru = new Sirtru();
            InitializeComponent();
            usuarioActual = null;             
        }   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            Int32 ancho = (this.Width - panel1.Width) / 2;
            //panel1.Location = new Point(ancho, panel1.Location.Y);

            Int32 alto = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(ancho, alto);
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            usuarioActual = sirtru.buscarUsuario(txtID.Text);
            if (usuarioActual != null)
            {
                if (txtContraseña.Text.Equals(usuarioActual.Contraseña))
                {
                    string msm = ("Bienvenido " + usuarioActual.Nombre + " !" );
                    MessageBox.Show(msm, "Usuario registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // Formulario fmFormulario = new Formulario(this);
                    txtID.Text = "";
                    txtContraseña.Text = "";
                    // fmFormulario.Show();

                    Visualizador programa = new Visualizador(this);
                    programa.Show();
                }
                else{ MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);        }
            }else {   MessageBox.Show("El usuario no está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);      }
        }

        private void btRegistrarse_Click(object sender, EventArgs e)
        {
            Registro fmRegistro = new Registro(this);
            fmRegistro.Show();
            txtID.Text = "";
            txtContraseña.Text = "";

        }

        public bool registrarUsuarioConCarro(string nombre, double telefono, string id, string contraseña, string placa, string modelo, string color)
        {
            return sirtru.registrarUsuarioConVehiculo(nombre, telefono, id, contraseña, placa, modelo, color);
        }

        public bool registrarUsuarioSinCarro(string nombre, double telefono, string id, string contraseña)
        {
            return sirtru.registrarUsuarioSinVehiculo(nombre, telefono, id, contraseña);
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCargarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {   OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Documento de texto|*.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sirtru.cargarUsuarios(openFileDialog1.FileName);
                    btCargarServicios.Enabled = true;
                    MessageBox.Show("Archivo cargado con exito!");
                }
            }
            catch (Exception ex)
            { MessageBox.Show("El archivo no es valido, asegurese de seleccionar el txt de usuarios correcto"); }

            
        }

        private void btCargarServicios_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Documento de texto|*.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sirtru.cargarServiciosActivos(openFileDialog1.FileName);
                    MessageBox.Show("Archivo cargado con exito!");
                }
            }
            catch (Exception ex)
            { MessageBox.Show("El archivo no es valido, asegurese de seleccionar el txt de usuarios correcto"); }

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contraseña = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la contraseña: ");
            if (contraseña.Equals("administrador"))
            {
                Admin admincito = new Admin(this);
                admincito.Show();
            }
            else if(contraseña.Equals(Sirtru.ContraAdmin))
            {
                Admin admincito = new Admin(this);
                admincito.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
