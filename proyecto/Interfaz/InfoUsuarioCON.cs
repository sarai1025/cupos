using Mundo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;



namespace Interfaz
{
    public partial class InfoUsuarioCON : Form
    {
        private Login principal;

        private Usuario user;

        private GMapOverlay markersOverlay;

        private GMapOverlay marcadores;

        public static InfoUsuarioCON infoC;

        public InfoUsuarioCON(Login prin)
        {
            principal = prin;
            InitializeComponent();
            user = principal.UsuarioActual;

            markersOverlay = new GMapOverlay("Overlay");

            marcadores = new GMapOverlay("Marcadores");

            InfoUsuarioCON.infoC = this;

        }



        public void InfoUsuario_Load(object sender, EventArgs e)
        {

            txtNombre.Text = user.Nombre;
            txtID.Text = user.Id;
            txtTel.Text = user.NumeroTelefono+"";
            txtPlaca.Text = user.Carros[0].Placa;
            txtModelo.Text = user.Carros[0].Modelo;
            txtColor.Text = user.Carros[0].Color;
            

            if (user.ServiciosRegistrados != null)
            {
                
                for (int i = 0; i < user.ServiciosRegistrados.Count; i++)
                {                                      
                   dataRutas.Rows.Add(user.ServiciosRegistrados[i].Direccdestino1, user.ServiciosRegistrados[i].Direccpartida1, user.ServiciosRegistrados[i].TiempoSalida);
                }
            }

        }

        public void cargarData()
        {
            dataRutas.Rows.Clear();

                for (int i = 0; i < user.ServiciosRegistrados.Count; i++)
                {
                    dataRutas.Rows.Add(user.ServiciosRegistrados[i].Direccdestino1, user.ServiciosRegistrados[i].Direccpartida1, user.ServiciosRegistrados[i].TiempoSalida);
                }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listRutas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gMapRutas_Load(object sender, EventArgs e)
        {
            gMapRutas.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapRutas.SetPositionByKeywords("Cali, Colombia");
            GMapOverlay markersOverlay = new GMapOverlay("MarkersOverlay");

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                marcadores.Clear();
                int index = dataRutas.CurrentRow.Index;
                Servicio temporal = user.ServiciosRegistrados[index];

            if (temporal.TipoServ.Equals(Servicio.SERVICIO_DE_COMPRA))
            {

                String[] inicio = temporal.Partida.Split('*');
                double i1 = Double.Parse(inicio[0]);
                double i2 = Double.Parse(inicio[1]);

                string[] fin = temporal.Destino.Split('*');
                double f1 = Double.Parse(fin[0]);
                double f2 = Double.Parse(fin[1]);

                PointLatLng start = new PointLatLng(i1, i2);
                PointLatLng end = new PointLatLng(f1, f2);

                GMapMarker partida;
                partida = new GMarkerGoogle(start, GMarkerGoogleType.red);
                partida.ToolTipText = "Partida";
                partida.ToolTipMode = MarkerTooltipMode.Always;
                marcadores.Markers.Add(partida);

                GMapMarker destino;
                destino = new GMarkerGoogle(end, GMarkerGoogleType.red);
                destino.ToolTipText = "Destino";
                destino.ToolTipMode = MarkerTooltipMode.Always;
                marcadores.Markers.Add(destino);

                gMapRutas.Overlays.Add(marcadores);
                gMapRutas.Refresh();
                gMapRutas.ReloadMap();
            }
            else
            {
                if (temporal.Ruta == null)
                {
                    generarRuta(temporal.Partida, temporal.Destino);
                }
                else
                {
                    GMapRoute ruta = temporal.Ruta;

                    String[] inicio = temporal.Partida.Split('*');
                    double i1 = Double.Parse(inicio[0]);
                    double i2 = Double.Parse(inicio[1]);

                    string[] fin = temporal.Destino.Split('*');
                    double f1 = Double.Parse(fin[0]);
                    double f2 = Double.Parse(fin[1]);

                    PointLatLng start = new PointLatLng(i1, i2);
                    PointLatLng end = new PointLatLng(f1, f2);

                    GMapMarker partida;
                    partida = new GMarkerGoogle(start, GMarkerGoogleType.red);
                    partida.ToolTipText = "Partida";
                    partida.ToolTipMode = MarkerTooltipMode.Always;
                    marcadores.Markers.Add(partida);

                    GMapMarker destino;
                    destino = new GMarkerGoogle(end, GMarkerGoogleType.red);
                    destino.ToolTipText = "Destino";
                    destino.ToolTipMode = MarkerTooltipMode.Always;
                    marcadores.Markers.Add(destino);

                    marcadores.Routes.Add(ruta);
                    gMapRutas.Overlays.Add(marcadores);
                    gMapRutas.ZoomAndCenterRoute(ruta);
                    gMapRutas.ReloadMap();
                }
            }

            
        }

        private void generarRuta(string CPartida, string CDestino)
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
                GMapRoute ruta = new GMapRoute(ss.Route, "Mi ruta");
                ruta.Stroke = new Pen(Color.Red, 3);
                //routes.Routes.Add(ruta);
                marcadores.Routes.Add(ruta);
                gMapRutas.Overlays.Add(marcadores);
                gMapRutas.ZoomAndCenterRoute(ruta);
                gMapRutas.ReloadMap();
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
                GMapRoute ruta = new GMapRoute(ss.Route, "Mi ruta");

                ruta.Stroke = new Pen(Color.Red, 3);
                //routes.Routes.Add(ruta);
                marcadores.Routes.Add(ruta);
                gMapRutas.Overlays.Add(marcadores);
                gMapRutas.ZoomAndCenterRoute(ruta);
                gMapRutas.ReloadMap();

            }
        }        

     

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNombre.Enabled == false)
            {

                string entrada = Microsoft.VisualBasic.Interaction.InputBox("Ingresa la contraseña");
                if (entrada.Equals(principal.UsuarioActual.Contraseña))
                {
                    txtNombre.Enabled = true;
                    txtID.Enabled = true;
                    txtTel.Enabled = true;

                    txtColor.Enabled = true;
                    txtPlaca.Enabled = true;
                    txtModelo.Enabled = true;

                    button2.Text = "Confirmar cambios";
                }
            }
            else if (button2.Text.Equals("Confirmar cambios"))
            {

                principal.UsuarioActual.Nombre = txtNombre.Text;
                principal.UsuarioActual.Id = txtID.Text;
                principal.UsuarioActual.NumeroTelefono= Double.Parse(txtTel.Text);

                principal.UsuarioActual.Carros[0].Color = txtColor.Text;
                principal.UsuarioActual.Carros[0].Placa= txtPlaca.Text;
                principal.UsuarioActual.Carros[0].Modelo= txtModelo.Text;


               
                  principal.Sirtru.buscarUsuario(principal.UsuarioActual.Id).Nombre =txtNombre.Text;
                  principal.Sirtru.buscarUsuario(principal.UsuarioActual.Id).Id = txtID.Text;
                  principal.Sirtru.buscarUsuario(principal.UsuarioActual.Id).NumeroTelefono =Double.Parse(txtTel.Text);

                  for (int i =0; i < principal.Sirtru.Servicios.Count; i++)
                  {
                    if (principal.Sirtru.Servicios[i].Solicitante.Id.Equals(principal.UsuarioActual.Id))
                    {
                        principal.Sirtru.Servicios[i].Solicitante.Id = txtID.Text;
                        principal.Sirtru.Servicios[i].Solicitante.Nombre = txtNombre.Text;
                        principal.Sirtru.Servicios[i].Solicitante.NumeroTelefono = Double.Parse(txtTel.Text);

                        principal.Sirtru.Servicios[i].Solicitante.Carros[0].Color = txtColor.Text;
                        principal.Sirtru.Servicios[i].Solicitante.Carros[0].Placa = txtPlaca.Text;
                        principal.Sirtru.Servicios[i].Solicitante.Carros[0].Modelo = txtModelo.Text;
                    }
                  }
               

                txtNombre.Enabled = false;
                txtID.Enabled = false;
                txtTel.Enabled = false;
                txtModelo.Enabled = false;
                txtPlaca.Enabled = false;
                txtColor.Enabled = false;

                button2.Text = "Editar información";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
