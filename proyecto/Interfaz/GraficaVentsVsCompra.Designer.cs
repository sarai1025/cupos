﻿namespace Interfaz
{
    partial class GraficaVentsVsCompra
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
            this.chartGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGraf
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraf.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraf.Legends.Add(legend1);
            this.chartGraf.Location = new System.Drawing.Point(12, 12);
            this.chartGraf.Name = "chartGraf";
            this.chartGraf.Size = new System.Drawing.Size(833, 526);
            this.chartGraf.TabIndex = 0;
            this.chartGraf.Text = "chart";
            // 
            // GraficaVentsVsCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 550);
            this.Controls.Add(this.chartGraf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GraficaVentsVsCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GraficaVentsVsCompra";
            this.Load += new System.EventHandler(this.GraficaVentsVsCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf;
    }
}