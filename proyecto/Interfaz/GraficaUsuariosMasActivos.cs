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
    public partial class GraficaUsuariosMasActivos : Form
    {
        private Login principal;
        public GraficaUsuariosMasActivos(Login prin)
        {
            InitializeComponent();
            principal = prin;
        }

        private void GraficaUsuariosMasActivos_Load(object sender, EventArgs e)
        {
            chartUsu.Titles.Add("Usuarios mas activos");

            Usuario mayorUsu1 = principal.Sirtru.Usuarios[0];
            Usuario mayorUsu2 = principal.Sirtru.Usuarios[0];
            Usuario mayorUsu3 = principal.Sirtru.Usuarios[0];

            int iNumeroMayor, iPosicion;

            //Presuponemos que el numero mayor es el primero
            iNumeroMayor = principal.Sirtru.Usuarios[0].ServiciosRegistrados.Count;
            iPosicion = 0;

            for (int i = 1; i < principal.Sirtru.Usuarios.Count; i++)
            {
                if (principal.Sirtru.Usuarios[i].ServiciosRegistrados.Count > iNumeroMayor)
                {
                    iNumeroMayor = principal.Sirtru.Usuarios[i].ServiciosRegistrados.Count;
                    iPosicion = i;
                    mayorUsu1 = principal.Sirtru.Usuarios[i];
                }

            }

            iNumeroMayor = principal.Sirtru.Usuarios[0].ServiciosRegistrados.Count;
            iPosicion = 0;

            for (int i = 1; i < principal.Sirtru.Usuarios.Count; i++)
            {
                if (principal.Sirtru.Usuarios[i].ServiciosRegistrados.Count > iNumeroMayor)
                {
                    if (!mayorUsu1.Id.Equals(principal.Sirtru.Usuarios[i].Id))
                    {
                        iNumeroMayor = principal.Sirtru.Usuarios[i].ServiciosRegistrados.Count;
                        iPosicion = i;
                        mayorUsu2 = principal.Sirtru.Usuarios[i];
                    }
                }

            }

            iNumeroMayor = principal.Sirtru.Usuarios[0].ServiciosRegistrados.Count;
            iPosicion = 0;

            for (int i = 1; i < principal.Sirtru.Usuarios.Count; i++)
            {
                if (principal.Sirtru.Usuarios[i].ServiciosRegistrados.Count > iNumeroMayor)
                {
                    if (!mayorUsu1.Id.Equals(principal.Sirtru.Usuarios[i].Id) && !mayorUsu2.Id.Equals(principal.Sirtru.Usuarios[i].Id))
                    {
                        iNumeroMayor = principal.Sirtru.Usuarios[i].ServiciosRegistrados.Count;
                        iPosicion = i;
                        mayorUsu3 = principal.Sirtru.Usuarios[i];
                    }
                }

            }

            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(mayorUsu1);
            if (!mayorUsu1.Id.Equals(mayorUsu2.Id))
            {
                usuarios.Add(mayorUsu2);
            }
            if (!mayorUsu2.Id.Equals(mayorUsu3.Id))
            {
                usuarios.Add(mayorUsu3);
            } 
            
            for (int i = 0; i< usuarios.Count;i++)
            {

                if (usuarios[i] != null)
                    {
                        Series serie = chartUsu.Series.Add(usuarios[i].Nombre);
                        serie.Label = usuarios[i].ServiciosRegistrados.Count.ToString();
                        serie.Points.Add(usuarios[i].ServiciosRegistrados.Count);
                    }                
                
            }

           

        }

        private void chartUsu_Click(object sender, EventArgs e)
        {

        }
    }
}
