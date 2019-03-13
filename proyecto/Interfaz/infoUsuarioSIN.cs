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
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using GMap.NET;

namespace Interfaz
{
    public partial class infoUsuarioSIN : Form
    {
        private Login principal;

        private Usuario user;

        private GMapOverlay markersOverlay;

        private GMapOverlay marcadores;

        public static infoUsuarioSIN infoS;
        public infoUsuarioSIN(Login prin)
        {
            principal = prin;

            InitializeComponent();

            user = principal.UsuarioActual;

            markersOverlay = new GMapOverlay("Overlay");

            marcadores = new GMapOverlay("Marcadores");

            infoUsuarioSIN.infoS = this;

        }

        private void infoUsuarioSIN_Load(object sender, EventArgs e)
        {
            txtNombre.Text = user.Nombre;
            txtID.Text = user.Id;
            txtTel.Text = user.NumeroTelefono + "";
            string x = "";
            if (user.ServiciosRegistrados != null)
            {

                for (int i = 0; i < user.ServiciosRegistrados.Count; i++)
                {                    
                    dataPuntos.Rows.Add( user.ServiciosRegistrados[i].Direccdestino1, user.ServiciosRegistrados[i].Direccpartida1, user.ServiciosRegistrados[i].TiempoSalida);                   
                }
            }
        }

        public void cargarData()
        {
            dataPuntos.Rows.Clear();
            for (int i = 0; i < user.ServiciosRegistrados.Count; i++)
                {
                    dataPuntos.Rows.Add(user.ServiciosRegistrados[i].Direccdestino1, user.ServiciosRegistrados[i].Direccpartida1, user.ServiciosRegistrados[i].TiempoSalida);
                }
            

        }

        private void gMapPuntos_Load(object sender, EventArgs e)
        {
            gMapPuntos.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapPuntos.SetPositionByKeywords("Cali, Colombia");
            GMapOverlay markersOverlay = new GMapOverlay("MarkersOverlay");

        }
        private void dibujarMarcadores()
        {
            String seleccion = dataPuntos.SelectedRows.ToString();

            
        }

       private void button1_Click(object sender, EventArgs e)
        {
            /* string x = "";
            if (user.ServiciosRegistrados != null)
            {

                for (int i = 0; i < user.ServiciosRegistrados.Count; i++)
                {
                    String[] inicio = user.ServiciosRegistrados[i].Partida.Split('*'); //textBoxPartida.Text.Split('*');
                    double i1 = Double.Parse(inicio[0]);
                    double i2 = Double.Parse(inicio[1]);

                    string[] fin = user.ServiciosRegistrados[i].Destino.Split('*'); //textBoxDestino.Text.Split('*');
                    double f1 = Double.Parse(fin[0]);
                    double f2 = Double.Parse(fin[1]);

                    PointLatLng start = new PointLatLng(i1, i2);
                    PointLatLng end = new PointLatLng(f1, f2);
                    GDirections ss = new GDirections();

                    try
                    {
                        // var xx = GMapProviders.BingMap.GetRoute(start, end, false, false, 10);
                        var xx = GMapProviders.GoogleMap.GetDirections(out ss, start, end, false, false, true, false, false);


                        //routes.Routes.Add(ruta);

                        gMapPuntos.Overlays.Add(marcadores);

                        gMapPuntos.ReloadMap();
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

                        //routes.Routes.Add(ruta);

                        gMapPuntos.Overlays.Add(marcadores);

                        gMapPuntos.ReloadMap();

                    }

                    x = "Desde: " + ss.StartAddress;
                    x += " , Hasta: " + ss.EndAddress;
                    listPuntos.Items.Add(x);
                }

            }*/
        }

        private void listPuntos_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void dataPuntos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            marcadores.Clear();
            int index = dataPuntos.CurrentRow.Index;
            Servicio temporal = user.ServiciosRegistrados[index];
            

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

            gMapPuntos.Overlays.Add(marcadores);
            gMapPuntos.Refresh();
            gMapPuntos.ReloadMap();
            




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Enabled == false)
            {
                string entrada = Microsoft.VisualBasic.Interaction.InputBox("Ingresa la contraseña");
                
                if (entrada.Equals(principal.UsuarioActual.Contraseña))
                {
                    txtNombre.Enabled = true;
                    txtID.Enabled = true;
                    txtTel.Enabled = true;

                    button1.Text = "Confirmar cambios";
                }
            }
            else if (txtNombre.Enabled == true)
            {
                principal.UsuarioActual.Nombre= txtNombre.Text;
                principal.UsuarioActual.Id=txtID.Text;
                principal.UsuarioActual.NumeroTelefono= Double.Parse(txtTel.Text);

               
                principal.Sirtru.buscarUsuario(principal.UsuarioActual.Id).Nombre = txtNombre.Text;
                principal.Sirtru.buscarUsuario(principal.UsuarioActual.Id).Id = txtID.Text;
                principal.Sirtru.buscarUsuario(principal.UsuarioActual.Id).NumeroTelefono = Double.Parse(txtTel.Text);


                for (int i = 0; i < principal.Sirtru.Servicios.Count; i++)
                {
                    if (principal.Sirtru.Servicios[i].Solicitante.Id.Equals(principal.UsuarioActual.Id))
                    {
                        principal.Sirtru.Servicios[i].Solicitante.Id = txtID.Text;
                        principal.Sirtru.Servicios[i].Solicitante.Nombre = txtNombre.Text;
                        principal.Sirtru.Servicios[i].Solicitante.NumeroTelefono = Double.Parse(txtTel.Text);

                        }
                }



                txtNombre.Enabled = false;
                txtID.Enabled = false;
                txtTel.Enabled = false;

                button1.Text = "Editar información";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                string informacionservicio = dataPuntos.CurrentRow.Index.ToString();
                dataPuntos.Rows.RemoveAt(dataPuntos.CurrentRow.Index);
            
        }

        private void dataPuntos_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }
