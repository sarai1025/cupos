using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using GMap.NET;
using Mundo;

namespace Interfaz
{
    public partial class HacerServicioCOMPRA : Form
    {
        private Login principal;

        
        private String CDestino;
        private String CPartida;

        private double lat;
        private double lon;
        private GMapOverlay markersOverlay;

        private GMapOverlay marcadores;

        public HacerServicioCOMPRA(Login prin)
        {
            principal = prin;
            
            InitializeComponent();

            gMapServicio.SetPositionByKeywords("Cali, Colombia");
        }

        private void HacerServicioCOMPRA_Load(object sender, EventArgs e)
        {
            gMapServicio.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

            markersOverlay = new GMapOverlay("Overlay");

            marcadores = new GMapOverlay("Marcadores");

            this.dateTimePicker2.Format = DateTimePickerFormat.Time;
            this.dateTimePicker2.Width = 100;
            this.dateTimePicker2.ShowUpDown = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //aqui agrego el usuario actual
            principal.Sirtru.Actual = principal.UsuarioActual;


            string hora = "";
            string fecha = "";


            //aqui la hora
           // hora = dateTimePicker2.Value + "";

            //fecha
            fecha = dateTimePicker1.Value + "";

            //Aqui los lugares de destino y partida que serian las COORDENADAS
            String partida = CPartida;
            String destino = CDestino;


            //Cupos siempre sera 0 cuando se compra


            String[] inicio = partida.Split('*'); //textBoxPartida.Text.Split('*');
            double i1 = Double.Parse(inicio[0]);
            double i2 = Double.Parse(inicio[1]);

            string[] fin = destino.Split('*'); //textBoxDestino.Text.Split('*');
            double f1 = Double.Parse(fin[0]);
            double f2 = Double.Parse(fin[1]);

            PointLatLng start = new PointLatLng(i1, i2);
            PointLatLng end = new PointLatLng(f1, f2);
            GDirections ss = new GDirections();

            try
            {
                var xx = GMapProviders.GoogleMap.GetDirections(out ss, start, end, false, false, true, false, false);

            }
            catch (Exception d)
            {
                i1++;
                i2++;
                f1++;
                f2++;
                string c1 = i1 + "*" + i2;
                string c2 = f1 + "*" + f2;
                start = new PointLatLng(i1, i2);
                end = new PointLatLng(f1, f2);
                var xx = GMapProviders.GoogleMap.GetDirections(out ss, start, end, false, false, true, false, false);

            }

            //RecomendacionUsu.

            principal.Sirtru.agregarServicio(principal.Sirtru.Actual.Id, fecha, 0, partida, destino, ss.StartAddress, ss.EndAddress, principal.Sirtru.IdServicio,"COM");

            if (principal.UsuarioActual.Tipo.Equals("c"))
            {
                InfoUsuarioCON.infoC.cargarData();
            }
            else
            {
                infoUsuarioSIN.infoS.cargarData();
            }
            
            MessageBox.Show("El servicio se ha registrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

        } 


        private void btAtras_Click(object sender, EventArgs e)
        {
            Formulario fmformulario = new Formulario(principal);
            fmformulario.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gMapServicio.SetPositionByKeywords("Universidad Icesi");
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            //crear marker con coordenada escogida
            //hacer cambios
            if (label1.Text.Equals("lugar de partida:"))
            {
                //crear marker con coordenada escogida
                //GMapOverlay markersOverlay = new GMapOverlay("MarkersOverlay");
                marcadores.Clear();
                MouseEventArgs hj = (MouseEventArgs)e;
                GMapMarker partida;
                partida = new GMarkerGoogle(new GMap.NET.PointLatLng(lat, lon), GMarkerGoogleType.red);
                partida.ToolTipText = "Partida";
                partida.ToolTipMode = MarkerTooltipMode.Always;
                marcadores.Markers.Add(partida);

                //markersOverlay.Markers.Add(partida);
                //gmapServicios.Overlays.Add(marcadores);  //hacer cambios
                CPartida = lat + "*" + lon;

                txtPartida.Text = CPartida;
                label1.Text = "Lugar de Destino";
            }
            else
            {
                labelseleccionar.Text = " * Seleccione el punto de destino";

                MouseEventArgs hj = (MouseEventArgs)e;
                GMapMarker destino;
                destino = new GMarkerGoogle(new GMap.NET.PointLatLng(lat, lon), GMarkerGoogleType.red);
                destino.ToolTipText = "Destino";
                destino.ToolTipMode = MarkerTooltipMode.Always;

                gMapServicio.Overlays.Clear();
                marcadores.Markers.Add(destino);
                gMapServicio.Overlays.Add(marcadores);
                gMapServicio.ZoomAndCenterMarkers("Marcadores");

                CDestino = lat + "*" + lon;

                txtDestino.Text = CDestino;

                btConfirmar.Enabled = false;                
            }

            btConfirmar.Enabled = false;
        }

        
        private void gMapServicio_Load(object sender, EventArgs e)
        {

        }

        private void gMapServicio_Click(object sender, EventArgs e)
        {
            //obtener coordenadas desde el mapa
           
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gMapServicio_Click_1(object sender, EventArgs e)
        {
            markersOverlay.Clear();
            GMapControl gm = (GMapControl)sender;
            MouseEventArgs hj = (MouseEventArgs)e;
            lat = gm.FromLocalToLatLng(hj.X, hj.Y).Lat;
            lon = gm.FromLocalToLatLng(hj.X, hj.Y).Lng;
            GMapMarker marker =
         new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
         new GMap.NET.PointLatLng(lat, lon),
         GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
            markersOverlay.Markers.Add(marker);
            gMapServicio.Overlays.Add(markersOverlay);
            btConfirmar.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }
    }
}
