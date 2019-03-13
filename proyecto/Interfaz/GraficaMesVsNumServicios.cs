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

namespace Interfaz
{
    public partial class GraficaMesVsNumServicios : Form
    {
        private Login principal;
        public GraficaMesVsNumServicios(Login prin)
        {
            InitializeComponent();
            principal = prin;
        }

        private void GraficaMesVsNumServicios_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("Grafica de Mes vs Cantidad de servicios");

            string[] meses = { "Enero","Febrero", "Marzo", "Abril", "Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre" };
            string[] mesesNum = {"01","02","03","04","05","06","07","08","09","10","11","12" };
            int can = 0;

            for (int i = 0; i < meses.Length; i++)
            {
                Series serie = chart1.Series.Add(meses[i]);

                for (int j = 0; j< principal.Sirtru.Servicios.Count; j++)
                {
                    string tiemporServicio = principal.Sirtru.Servicios[j].TiempoSalida;
                    string[] separoTime = tiemporServicio.Split(' ');

                    string fechaSer = separoTime[0];
                    string[] separoFecha = fechaSer.Split('/');

                    string mesSer = separoFecha[1];

                    if (mesSer.Equals(mesesNum[i]))
                    {
                        can++;
                    }

                }
                serie.Label = can.ToString();
                serie.Points.Add(can);
                can = 0;
            }
        }
    }
}
