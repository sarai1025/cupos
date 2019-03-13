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
    public partial class HacerServicioVENTA : Form
    {

        private Login principal;

        private GMapOverlay markersOverlay;

        private GMapOverlay marcadores;

        private double lat;

        private double lon;

        private String CDestino;

        private String CPartida;

        private String direccionPartida;

        private string direccionDestino;
        
        private GMapRoute ruta;

        public string CDestino1 { get => CDestino; set => CDestino = value; }
        public string CPartida1 { get => CPartida; set => CPartida = value; }

        public HacerServicioVENTA(Login prin)
        {
            principal = prin;

            InitializeComponent();

            gmapServicios.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

            markersOverlay = new GMapOverlay("Overlay");

            marcadores = new GMapOverlay("Marcadores");

            ruta = null;

            // Si es usuario sin carro no puede vender cupos
            if (principal.UsuarioActual.Tipo.Equals("s"))
            {
                btVender.Enabled = false;
                cupoos.Enabled = false;
            }

        }

        private void HacerServicio_Load(object sender, EventArgs e)
        {
             gmapServicios.SetPositionByKeywords("Cali, Colombia");
            this.dateTimePicker1.Format = DateTimePickerFormat.Time;
            this.dateTimePicker1.Width = 100;
            this.dateTimePicker1.ShowUpDown = true;

            btVender.Enabled = false;

        }
        
        private void btnAtrasS_Click(object sender, EventArgs e)
        {
            Formulario fmformulario = new Formulario(principal);
            fmformulario.Show();
            this.Close();
        }

        private void gmapServicios_Load(object sender, EventArgs e)
        {

           
        }
       

    
        private void gmapServicios_Click(object sender, EventArgs e){
            //obtener coordenadas desde el mapa
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
            gmapServicios.Overlays.Add(markersOverlay);
            btnconfirmar.Enabled = true;

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
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
                CPartida = lat + "*" + lon;
                textBoxPartida.Text = CPartida;
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

                gmapServicios.Overlays.Clear();
                marcadores.Markers.Add(destino);
                gmapServicios.Overlays.Add(marcadores);
                gmapServicios.ZoomAndCenterMarkers("Marcadores");

                CDestino = lat + "*" + lon;               

                textBoxDestino.Text = CDestino;      
                
                          
                
            }

            btnconfirmar.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void horaActual_Click(object sender, EventArgs e)
        {
            
        }

        private void btComprar_Click(object sender, EventArgs e)
        {
          /*  //aqui agrego el usuario actual
            principal.Sirtru.Actual = principal.UsuarioActual;


            string hora ="";
            string fecha = "";        
           

            //aqui la hora
            hora = dateTimePicker1.Value +"";           

            //fecha
            fecha = dateTimePicker3.Value + "";

            //Aqui los lugares de destino y partida que serian las COORDENADAS
            String partida = CPartida;
            String destino = CDestino;

            //Cupos siempre sera 0 cuando se compra

            principal.Sirtru.agregarServicio(principal.Sirtru.Actual.getID(), hora, 0, partida,destino);

            MessageBox.Show("El servicio se ha registrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                */
        }

        private void btVender_Click(object sender, EventArgs e)
        {
            //aqui agrego el usuario actual
            principal.Sirtru.Actual = principal.UsuarioActual;

            String hora = "";
            String partida = CPartida;
            String destino = CDestino;
            
            string fecha = "";
            int cupo = (Int32)cupoos.Value;
            fecha = dateTimePicker3.Value + "";
            //aqui la hora
            //hora = dateTimePicker1.Value + "";

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

            principal.Sirtru.agregarServicio(principal.Sirtru.Actual.Id,fecha, Int32.Parse("" + cupoos.Value), partida, destino, ss.StartAddress, ss.EndAddress, principal.Sirtru.IdServicio,"VEN");

            //principal.Sirtru.agregarServicio(principal.Sirtru.Actual.Id, hora + " " + fecha,0, CPartida, CDestino, direccionPartida, direccionDestino, principal.Sirtru.IdServicio, "VEN");
            principal.Sirtru.cambiarPuntos((principal.Sirtru.IdServicio - 1), ruta.Points);

            
            InfoUsuarioCON.infoC.cargarData();
          
            MessageBox.Show("El servicio se ha registrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            String[] inicio = CPartida.Split('*'); //textBoxPartida.Text.Split('*');
            double i1 = Double.Parse(inicio[0]);
            double i2 = Double.Parse(inicio[1]);

            string[] fin = CDestino.Split('*'); //textBoxDestino.Text.Split('*');
            double f1 = Double.Parse(fin[0]);
            double f2 = Double.Parse(fin[1]);
            generarRuta(i1, i2, f1, f2);

            btVender.Enabled = true;
        }

        private void generarRuta(double i1, double i2, double f1, double f2)
        {

            PointLatLng start = new PointLatLng(i1, i2);
            PointLatLng end = new PointLatLng(f1, f2);
            GDirections ss = new GDirections();
            try
            {
                // var xx = GMapProviders.BingMap.GetRoute(start, end, false, false, 10);
                var xx = GMapProviders.GoogleMap.GetDirections(out ss, start, end, false, false, true, false, false);
                ruta = new GMapRoute(ss.Route, "Mi ruta");
                ruta.Stroke = new Pen(Color.Red, 3);
                //routes.Routes.Add(ruta);
                marcadores.Routes.Add(ruta);
                gmapServicios.Overlays.Add(marcadores);
                gmapServicios.ZoomAndCenterRoute(ruta);
                gmapServicios.ReloadMap();
            }
            catch (Exception d)
            {
                
                i1++;
                i2++;
                f1++;
                f2++;
                start = new PointLatLng(i1, i2);
                end = new PointLatLng(f1, f2);
                generarRuta(i1, i2, f1, f2);
                ruta.Stroke = new Pen(Color.Red, 3);
                //routes.Routes.Add(ruta);
                marcadores.Routes.Add(ruta);
                gmapServicios.Overlays.Add(marcadores);
                gmapServicios.ZoomAndCenterRoute(ruta);
                gmapServicios.ReloadMap();
            }

            gmapServicios.Click -= gmapServicios_Click;
            //textBoxDestino.Text = ss.EndAddress;
            //textBoxPartida.Text = ss.StartAddress;
            //direccionPartida = ss.StartAddress;
            //direccionDestino = ss.EndAddress;
            CPartida = i1 + "*" + i2;
            CDestino = f1 + "*" + f2;
            //textBox1.Text = ss.Distance;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }


        private void textBoxPartida_TextChanged(object sender, EventArgs e)
        {

        }


        private void rbtLlegadaIcesi_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            String[] inicio = CPartida.Split('*'); //textBoxPartida.Text.Split('*');
            double i1 = Double.Parse(inicio[0]);
            double i2 = Double.Parse(inicio[1]);

            string[] fin = CDestino.Split('*'); //textBoxDestino.Text.Split('*');
            double f1 = Double.Parse(fin[0]);
            double f2 = Double.Parse(fin[1]);

            PointLatLng start = new PointLatLng(i1, i2);
            PointLatLng end = new PointLatLng(f1, f2);
            GDirections ss = new GDirections();

            try
            {
                // var xx = GMapProviders.BingMap.GetRoute(start, end, false, false, 10);
                var xx = GMapProviders.GoogleMap.GetDirections(out ss, start, end, false, false, true, false, false);
                ruta = new GMapRoute(ss.Route, "Mi ruta");
                ruta.Stroke = new Pen(Color.Red, 3);
                //routes.Routes.Add(ruta);
                marcadores.Routes.Add(ruta);
                gmapServicios.Overlays.Add(marcadores);
                gmapServicios.ZoomAndCenterRoute(ruta);
                gmapServicios.ReloadMap();
            }
            catch (Exception d)
            {
                i1++;
                i2++;
                f1++;
                f2++;
                string c1 = i1 + "*" + i2;
                string c2 = f1 + "*" + f2;
                textBoxPartida.Text = c1;
                textBoxDestino.Text = c2;
                start = new PointLatLng(i1, i2);
                end = new PointLatLng(f1, f2);
                var xx = GMapProviders.GoogleMap.GetDirections(out ss, start, end, false, false, true, false, false);
                ruta = new GMapRoute(ss.Route, "Mi ruta");
                ruta.Stroke = new Pen(Color.Red, 3);
                //routes.Routes.Add(ruta);
                marcadores.Routes.Add(ruta);
                gmapServicios.Overlays.Add(marcadores);
                gmapServicios.ZoomAndCenterRoute(ruta);
                gmapServicios.ReloadMap();
                
            }
            gmapServicios.Click -= gmapServicios_Click;
            textBoxDestino.Text = ss.EndAddress;
            textBoxPartida.Text = ss.StartAddress;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;


        }

        private void rbtnIcesi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnIcesi.Checked)
            {
                gmapServicios.SetPositionByKeywords("Universidad Icesi");
                gmapServicios.ReloadMap();
                rbtnIcesi.Checked = false;
            }
            else
            {
                rbtnIcesi.Checked = false;
            }
        }

        
    }      
}

