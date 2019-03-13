namespace Interfaz
{
    partial class Formulario
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btInfoUsuario = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btRecomendaciones = new System.Windows.Forms.Button();
            this.btVenta = new System.Windows.Forms.Button();
            this.btCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btInfoUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btVenta);
            this.groupBox1.Controls.Add(this.btRecomendaciones);
            this.groupBox1.Controls.Add(this.btCompra);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Que desea hacer?";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btInfoUsuario
            // 
            this.btInfoUsuario.Location = new System.Drawing.Point(330, 171);
            this.btInfoUsuario.Name = "btInfoUsuario";
            this.btInfoUsuario.Size = new System.Drawing.Size(98, 23);
            this.btInfoUsuario.TabIndex = 3;
            this.btInfoUsuario.Text = "Mi información";
            this.btInfoUsuario.UseVisualStyleBackColor = true;
            this.btInfoUsuario.Click += new System.EventHandler(this.btInfoUsuario_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(365, 240);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 2;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btRecomendaciones
            // 
            this.btRecomendaciones.Location = new System.Drawing.Point(41, 171);
            this.btRecomendaciones.Name = "btRecomendaciones";
            this.btRecomendaciones.Size = new System.Drawing.Size(144, 23);
            this.btRecomendaciones.TabIndex = 0;
            this.btRecomendaciones.Text = "Buscar recomendaciones";
            this.btRecomendaciones.UseVisualStyleBackColor = true;
            this.btRecomendaciones.Click += new System.EventHandler(this.btRecomendaciones_Click);
            // 
            // btVenta
            // 
            this.btVenta.Location = new System.Drawing.Point(41, 86);
            this.btVenta.Name = "btVenta";
            this.btVenta.Size = new System.Drawing.Size(75, 23);
            this.btVenta.TabIndex = 3;
            this.btVenta.Text = "Venta";
            this.btVenta.UseVisualStyleBackColor = true;
            this.btVenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCompra
            // 
            this.btCompra.Location = new System.Drawing.Point(156, 86);
            this.btCompra.Name = "btCompra";
            this.btCompra.Size = new System.Drawing.Size(75, 23);
            this.btCompra.TabIndex = 4;
            this.btCompra.Text = "Compra";
            this.btCompra.UseVisualStyleBackColor = true;
            this.btCompra.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Solicitar Servicio de:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "o";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ver sus recomendaciones:";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 279);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btRecomendaciones;
        private System.Windows.Forms.Button btInfoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVenta;
        private System.Windows.Forms.Button btCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}