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
    public partial class GraficaUsuVsNumServ : Form
    {
        private Login principal;
        public GraficaUsuVsNumServ(Login prin)
        {
            InitializeComponent();
            principal = prin;
        }

        private void Grafica_Load(object sender, EventArgs e)
        {

            GraficoSer.Titles.Add("Grafica de Usuarios vs cantidad de servicios");
            
            for (int i =0; i<principal.Sirtru.Usuarios.Count;i++)
            {
                
                Series serie = GraficoSer.Series.Add(principal.Sirtru.Usuarios[i].Nombre);
               
               serie.Label = principal.Sirtru.Usuarios[i].ServiciosRegistrados.Count.ToString();
                serie.Points.Add(principal.Sirtru.Usuarios[i].ServiciosRegistrados.Count);
            }

            
        }

        private void chart1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
