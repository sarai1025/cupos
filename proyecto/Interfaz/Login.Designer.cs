namespace Interfaz
{
    partial class Login
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
            sirtru.guardarInformacion();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btRegistrarse = new System.Windows.Forms.Button();
            this.btIniciarSesion = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btCargarUsuarios = new System.Windows.Forms.Button();
            this.btCargarServicios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btRegistrarse
            // 
            this.btRegistrarse.Location = new System.Drawing.Point(159, 259);
            this.btRegistrarse.Name = "btRegistrarse";
            this.btRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.btRegistrarse.TabIndex = 4;
            this.btRegistrarse.Text = "Registrarse";
            this.btRegistrarse.UseVisualStyleBackColor = true;
            this.btRegistrarse.Click += new System.EventHandler(this.btRegistrarse_Click);
            // 
            // btIniciarSesion
            // 
            this.btIniciarSesion.Location = new System.Drawing.Point(146, 162);
            this.btIniciarSesion.Name = "btIniciarSesion";
            this.btIniciarSesion.Size = new System.Drawing.Size(100, 23);
            this.btIniciarSesion.TabIndex = 3;
            this.btIniciarSesion.Text = "Iniciar Sesión";
            this.btIniciarSesion.UseVisualStyleBackColor = true;
            this.btIniciarSesion.Click += new System.EventHandler(this.btIniciarSesion_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(89, 100);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(24, 13);
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Text = "ID:";
            this.lbl_ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID
            // 
            this.txtID.AcceptsTab = true;
            this.txtID.Location = new System.Drawing.Point(146, 97);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContraseña.Location = new System.Drawing.Point(61, 126);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbContraseña.Size = new System.Drawing.Size(75, 13);
            this.lbContraseña.TabIndex = 4;
            this.lbContraseña.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "¿No está registrado?";
            // 
            // txtContraseña
            // 
            this.txtContraseña.AcceptsTab = true;
            this.txtContraseña.Location = new System.Drawing.Point(146, 123);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // btCargarUsuarios
            // 
            this.btCargarUsuarios.Location = new System.Drawing.Point(1, 331);
            this.btCargarUsuarios.Name = "btCargarUsuarios";
            this.btCargarUsuarios.Size = new System.Drawing.Size(91, 23);
            this.btCargarUsuarios.TabIndex = 7;
            this.btCargarUsuarios.Text = "Cargar Usuarios";
            this.btCargarUsuarios.UseVisualStyleBackColor = true;
            this.btCargarUsuarios.Visible = false;
            this.btCargarUsuarios.Click += new System.EventHandler(this.btCargarUsuarios_Click);
            // 
            // btCargarServicios
            // 
            this.btCargarServicios.Enabled = false;
            this.btCargarServicios.Location = new System.Drawing.Point(93, 331);
            this.btCargarServicios.Name = "btCargarServicios";
            this.btCargarServicios.Size = new System.Drawing.Size(93, 23);
            this.btCargarServicios.TabIndex = 8;
            this.btCargarServicios.Text = "Cargar Servicios";
            this.btCargarServicios.UseVisualStyleBackColor = true;
            this.btCargarServicios.Visible = false;
            this.btCargarServicios.Click += new System.EventHandler(this.btCargarServicios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_ID);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lbContraseña);
            this.panel1.Controls.Add(this.btIniciarSesion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btRegistrarse);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Location = new System.Drawing.Point(50, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 305);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.SLOGAN_ULTIMO;
            this.pictureBox1.Location = new System.Drawing.Point(54, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interfaz.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 352);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCargarServicios);
            this.Controls.Add(this.btCargarUsuarios);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRegistrarse;
        private System.Windows.Forms.Button btIniciarSesion;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btCargarUsuarios;
        private System.Windows.Forms.Button btCargarServicios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}