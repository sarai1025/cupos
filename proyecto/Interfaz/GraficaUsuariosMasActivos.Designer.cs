namespace Interfaz
{
    partial class GraficaUsuariosMasActivos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartUsu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // chartUsu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartUsu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartUsu.Legends.Add(legend1);
            this.chartUsu.Location = new System.Drawing.Point(12, 33);
            this.chartUsu.Name = "chartUsu";
            this.chartUsu.Size = new System.Drawing.Size(800, 475);
            this.chartUsu.TabIndex = 0;
            this.chartUsu.Text = "chart1";
            this.chartUsu.Click += new System.EventHandler(this.chartUsu_Click);
            // 
            // GraficaUsuariosMasActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 520);
            this.Controls.Add(this.chartUsu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GraficaUsuariosMasActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GraficaUsuariosMasActivos";
            this.Load += new System.EventHandler(this.GraficaUsuariosMasActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsu;
    }
}