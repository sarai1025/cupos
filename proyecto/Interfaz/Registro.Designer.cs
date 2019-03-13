namespace Interfaz
{
    partial class Registro
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
            this.btFoto = new System.Windows.Forms.Button();
            this.btRegistro = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbTieneVehiculo = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbFoto = new System.Windows.Forms.Label();
            this.lbContraseñia = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.fotopicbox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.obligatoriolabel = new System.Windows.Forms.Label();
            this.confirmarpasslabel = new System.Windows.Forms.Label();
            this.confirpasstxtb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fotopicbox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFoto
            // 
            this.btFoto.Location = new System.Drawing.Point(392, 130);
            this.btFoto.Name = "btFoto";
            this.btFoto.Size = new System.Drawing.Size(135, 23);
            this.btFoto.TabIndex = 33;
            this.btFoto.Text = "Buscar foto";
            this.btFoto.UseVisualStyleBackColor = true;
            this.btFoto.Click += new System.EventHandler(this.btFoto_Click);
            // 
            // btRegistro
            // 
            this.btRegistro.Location = new System.Drawing.Point(451, 681);
            this.btRegistro.Name = "btRegistro";
            this.btRegistro.Size = new System.Drawing.Size(94, 39);
            this.btRegistro.TabIndex = 19;
            this.btRegistro.Text = "Registrarse";
            this.btRegistro.UseVisualStyleBackColor = true;
            this.btRegistro.Click += new System.EventHandler(this.btRegistro_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(27, 111);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "ID:";
            this.lbID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(4, 221);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(34, 13);
            this.lbColor.TabIndex = 4;
            this.lbColor.Text = "Color:";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(4, 153);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(203, 13);
            this.lbModelo.TabIndex = 6;
            this.lbModelo.Text = "Modelo (Información adicional; ej: marca):";
            // 
            // lbTieneVehiculo
            // 
            this.lbTieneVehiculo.AutoSize = true;
            this.lbTieneVehiculo.Location = new System.Drawing.Point(13, 42);
            this.lbTieneVehiculo.Name = "lbTieneVehiculo";
            this.lbTieneVehiculo.Size = new System.Drawing.Size(91, 13);
            this.lbTieneVehiculo.TabIndex = 8;
            this.lbTieneVehiculo.Text = "¿Tiene vehículo?";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(4, 79);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(37, 13);
            this.lbPlaca.TabIndex = 10;
            this.lbPlaca.Text = "Placa:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(27, 311);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(59, 13);
            this.lbTelefono.TabIndex = 12;
            this.lbTelefono.Text = "Telefono: *";
            // 
            // lbFoto
            // 
            this.lbFoto.AutoSize = true;
            this.lbFoto.Location = new System.Drawing.Point(389, 21);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(28, 13);
            this.lbFoto.TabIndex = 14;
            this.lbFoto.Text = "Foto";
            // 
            // lbContraseñia
            // 
            this.lbContraseñia.AutoSize = true;
            this.lbContraseñia.Location = new System.Drawing.Point(27, 238);
            this.lbContraseñia.Name = "lbContraseñia";
            this.lbContraseñia.Size = new System.Drawing.Size(64, 13);
            this.lbContraseñia.TabIndex = 16;
            this.lbContraseñia.Text = "Contraseña:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(27, 173);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 18;
            this.lbNombre.Text = "Nombre: ";
            // 
            // txtPlaca
            // 
            this.txtPlaca.AcceptsTab = true;
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Location = new System.Drawing.Point(7, 95);
            this.txtPlaca.MaxLength = 6;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(497, 20);
            this.txtPlaca.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AcceptsTab = true;
            this.txtTelefono.Location = new System.Drawing.Point(30, 327);
            this.txtTelefono.MaxLength = 12;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(497, 20);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.AcceptsTab = true;
            this.txtModelo.Location = new System.Drawing.Point(7, 169);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(497, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // txtColor
            // 
            this.txtColor.AcceptsTab = true;
            this.txtColor.Location = new System.Drawing.Point(7, 237);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(497, 20);
            this.txtColor.TabIndex = 8;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.AcceptsTab = true;
            this.txtContrasenia.Location = new System.Drawing.Point(30, 254);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(256, 20);
            this.txtContrasenia.TabIndex = 3;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsTab = true;
            this.txtNombre.Location = new System.Drawing.Point(30, 189);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(497, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.AcceptsTab = true;
            this.txtID.Location = new System.Drawing.Point(30, 127);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(256, 20);
            this.txtID.TabIndex = 1;
            // 
            // fotopicbox
            // 
            this.fotopicbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotopicbox.Location = new System.Drawing.Point(392, 37);
            this.fotopicbox.Name = "fotopicbox";
            this.fotopicbox.Size = new System.Drawing.Size(135, 87);
            this.fotopicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotopicbox.TabIndex = 32;
            this.fotopicbox.TabStop = false;
            this.fotopicbox.BackgroundImageChanged += new System.EventHandler(this.btFoto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Si";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // obligatoriolabel
            // 
            this.obligatoriolabel.AutoSize = true;
            this.obligatoriolabel.Location = new System.Drawing.Point(18, 707);
            this.obligatoriolabel.Name = "obligatoriolabel";
            this.obligatoriolabel.Size = new System.Drawing.Size(95, 13);
            this.obligatoriolabel.TabIndex = 35;
            this.obligatoriolabel.Text = "*Campo obligatorio";
            // 
            // confirmarpasslabel
            // 
            this.confirmarpasslabel.AutoSize = true;
            this.confirmarpasslabel.Location = new System.Drawing.Point(289, 238);
            this.confirmarpasslabel.Name = "confirmarpasslabel";
            this.confirmarpasslabel.Size = new System.Drawing.Size(107, 13);
            this.confirmarpasslabel.TabIndex = 36;
            this.confirmarpasslabel.Text = "Confirmar contraseña";
            this.confirmarpasslabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // confirpasstxtb
            // 
            this.confirpasstxtb.Location = new System.Drawing.Point(292, 254);
            this.confirpasstxtb.Name = "confirpasstxtb";
            this.confirpasstxtb.PasswordChar = '*';
            this.confirpasstxtb.Size = new System.Drawing.Size(235, 20);
            this.confirpasstxtb.TabIndex = 4;
            this.confirpasstxtb.TextChanged += new System.EventHandler(this.confirpasstxtb_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.cancelar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btRegistro);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.obligatoriolabel);
            this.panel1.Controls.Add(this.confirpasstxtb);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.fotopicbox);
            this.panel1.Controls.Add(this.confirmarpasslabel);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lbTelefono);
            this.panel1.Controls.Add(this.lbContraseñia);
            this.panel1.Controls.Add(this.txtContrasenia);
            this.panel1.Controls.Add(this.lbFoto);
            this.panel1.Controls.Add(this.btFoto);
            this.panel1.Location = new System.Drawing.Point(24, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 738);
            this.panel1.TabIndex = 38;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(351, 681);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(94, 39);
            this.cancelar.TabIndex = 40;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.SLOGAN_ULTIMO;
            this.pictureBox1.Location = new System.Drawing.Point(28, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTieneVehiculo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.lbPlaca);
            this.groupBox1.Controls.Add(this.lbModelo);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.lbColor);
            this.groupBox1.Location = new System.Drawing.Point(21, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 278);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información vehiculo";
            // 
            // Registro
            // 
            this.AcceptButton = this.btRegistro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(616, 741);
            this.Controls.Add(this.panel1);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotopicbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFoto;
        private System.Windows.Forms.Button btRegistro;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbTieneVehiculo;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbFoto;
        private System.Windows.Forms.Label lbContraseñia;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox fotopicbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label obligatoriolabel;
        private System.Windows.Forms.Label confirmarpasslabel;
        private System.Windows.Forms.TextBox confirpasstxtb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}