using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Mundo;

namespace Interfaz
{
    public partial class GraficaVentsVsCompra : Form
    {
        private Login principal;
        public GraficaVentsVsCompra(Login prin)
        {
            principal = prin;
            InitializeComponent();
        }

        private void GraficaVentsVsCompra_Load(object sender, EventArgs e)
        {
            chartGraf.Titles.Add("Grafica de Ventas vs Compras");
            string[] seriees = {"Ventas","Compras" };

            List<Servicio> serviciosVEN = new List<Servicio>();
            List<Servicio> serviciosCOM = new List<Servicio>();

            for (int j=0; j<seriees.Length;j++)
            {
                Series serie = chartGraf.Series.Add(seriees[j]);
                // serie.Label = principal.Sirtru.Usuarios[i].ServiciosRegistrados.Count.ToString();
                for (int i = 0; i < principal.Sirtru.Servicios.Count; i++)
                {
                    if (principal.Sirtru.Servicios[i].TipoServ.Equals("VEN"))
                    {
                        serviciosVEN.Add(principal.Sirtru.Servicios[i]);
                    }
                    else if (principal.Sirtru.Servicios[i].TipoServ.Equals("COM"))
                    {
                        serviciosCOM.Add(principal.Sirtru.Servicios[i]);

                    }
                   
                }
                int[] cantidades = { serviciosVEN.Count, serviciosCOM.Count };
                serie.Label = cantidades[j].ToString();
                serie.Points.Add(cantidades[j]);

            }
            
        }
    }
}
