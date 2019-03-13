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
    public partial class Registro : Form
    {
        private Login principal; 

        public Registro(Login log)
        {
            principal = log;
            InitializeComponent();
            txtPlaca.Enabled = false;
            txtModelo.Enabled = false;
            txtColor.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            Size desk = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            Int32 ancho = (this.Width - panel1.Width) / 2;
            //panel1.Location = new Point(ancho, panel1.Location.Y);

            Int32 alto = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(ancho, alto);
        }

        public string getID()
        {
            return txtID.Text;
        }

        public string getNombreUsuario()
        {
            return txtNombre.Text;
        }

        public string getContraseña()
        {
            return txtContrasenia.Text;
        }

        public double getTelefono()
        {           
                return Double.Parse(txtTelefono.Text);
                       
        }

        public string getPlaca()
        {
            return txtPlaca.Text;
        }

        public string getModelo()
        {
            return txtModelo.Text;
        }

        public string getColor()
        {
            return txtColor.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPlaca.Enabled = true;
            txtModelo.Enabled = true;
            txtColor.Enabled = true;

        }

        private void btRegistro_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtContrasenia.Text.Equals(confirpasstxtb.Text))
                {
                    if (txtPlaca.Enabled)
                    {
                        bool x = principal.registrarUsuarioConCarro(txtNombre.Text, getTelefono(), txtID.Text, txtContrasenia.Text, txtPlaca.Text, txtModelo.Text, txtColor.Text);
                       if (x)
                        {
                            MessageBox.Show("El usuario se ha registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                           // Login login = new Login();
                            //login.Show();
                        }
                        else
                        {
                            MessageBox.Show("El usuario con el ID ingresado ya se encuentra registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        bool y = principal.registrarUsuarioSinCarro(txtNombre.Text, getTelefono(), txtID.Text, txtContrasenia.Text);
                        if (y)
                        {
                            MessageBox.Show("El usuario se ha registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                           // Login login = new Login();
                            //login.Show();
                        }
                        else
                        {
                            MessageBox.Show("El usuario con el ID ingresado ya se encuentra registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("La constraseña no coincide.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ingrese o corrija número del teléfono","Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                 
                    }
        }

        private void btFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                   fotopicbox.Image = Image.FromFile(imagen);

                    //guarda la ruta de la imagen para el usuario
                  //  principal.UsuarioActual.Imagen = imagen;
                }
            }
            catch (Exception ex)
            { MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");  }

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que solo se ingresen números en el campo de teléfono
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cbUbicacion_CheckedChanged(object sender, EventArgs e)
        {
            btRegistro.Enabled = true;
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void confirpasstxtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}