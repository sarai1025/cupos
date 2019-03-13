namespace Interfaz
{
    partial class GraficaUsuVsNumServ
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.GraficoSer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GraficoSer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GraficoSer
            // 
            chartArea1.Name = "ChartArea1";
            this.GraficoSer.ChartAreas.Add(chartArea1);
            this.GraficoSer.DataSource = this.usuarioBindingSource;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            legend1.Title = "Grafico";
            this.GraficoSer.Legends.Add(legend1);
            this.GraficoSer.Location = new System.Drawing.Point(12, 29);
            this.GraficoSer.Name = "GraficoSer";
            this.GraficoSer.Size = new System.Drawing.Size(861, 533);
            this.GraficoSer.TabIndex = 0;
            this.GraficoSer.Text = "Diagrama";
            title1.Name = "Grafico1";
            this.GraficoSer.Titles.Add(title1);
            this.GraficoSer.Click += new System.EventHandler(this.chart1_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Mundo.Usuario);
            // 
            // GraficaUsuVsNumServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 574);
            this.Controls.Add(this.GraficoSer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GraficaUsuVsNumServ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Grafica";
            this.Load += new System.EventHandler(this.Grafica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GraficoSer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoSer;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
    }
}