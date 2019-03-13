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
using Mundo;
using GMap.NET;

namespace Interfaz
{
    public partial class RecomendacionUsu : Form
    {
        public static double CERCANIA = 11000090000;

        private Login principal;

        //public static RecomendacionUsu recoUsu;

        private GMapOverlay markersOverlay;

        private GMapOverlay marcadores;

        private Usuario usuarioActual;

        private Servicio servicioActual;

        private List<Servicio> serviciosRecomendados;

        public RecomendacionUsu(Login prin)
        {
            principal = prin;
            InitializeComponent();
            //RecomendacionUsu.recoUsu = this;
            usuarioActual = principal.UsuarioActual;
            // serviciosRecomendados = new List<Servicio>();

            //MODIFICAR
            if (principal.UsuarioActual.ServiciosRegistrados.Count == 0)
            {
                MessageBox.Show("No se le puede recomendar, debido a que no ha solicitado ningun servicio", "Información Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                servicioActual = principal.UsuarioActual.ServiciosRegistrados[0];
            }

            

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cbPorFechaYHora_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPorFechaYHora.Checked == true)
            {
                dateTimePicker2.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
        }
        private void cbLugarPartida_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLugarPartida.Checked == true)
            {
                txtPartida.Enabled = true;
            }
            else
            {
                txtPartida.Text = "";
                txtPartida.Enabled = false;
            }
        }
        private void cbLugarDestino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLugarDestino.Checked == true)
            {
                txtDestino.Enabled = true;
            }
            else
            {
                txtDestino.Text = "";
                txtDestino.Enabled = false;
            }
        }

        private void btnAtrasR_Click(object sender, EventArgs e)
        {
            /*
            Formulario formformulario = new Formulario(principal);
            formformulario.Show();
            this.Close();
            */
        }

        private void gmapRecomendacion_Load(object sender, EventArgs e)
        {
            gmapRecomendacion.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmapRecomendacion.SetPositionByKeywords("Cali, Colombia");
            GMapOverlay markersOverlay = new GMapOverlay("MarkersOverlay");

    
        }

        private void RecomendacionUsu_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Format = DateTimePickerFormat.Time;
            this.dateTimePicker1.Width = 100;
            this.dateTimePicker1.ShowUpDown = true;

            markersOverlay = new GMapOverlay("Overlay");
            marcadores = new GMapOverlay("Marcadores");


            for (int i = 0; i < usuarioActual.ServiciosRegistrados.Count; i++)
            {
                if (usuarioActual.ServiciosRegistrados[i] != null && usuarioActual.ServiciosRegistrados[i].TipoServ.Equals("COM"))
                    dataGridView1.Rows.Add(usuarioActual.ServiciosRegistrados[i].IdServicio, usuarioActual.ServiciosRegistrados[i].Direccpartida1, usuarioActual.ServiciosRegistrados[i].Direccdestino1, usuarioActual.ServiciosRegistrados[i].TiempoSalida);
            }

            button3.Enabled = false;
            button4.Enabled = false;

            if (dataGridView1.Rows.Count < 1)
            {
                // MessageBox.Show("No tiene ningún servicio registrado para generarle recomendaciones");
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                label1.Visible = false;
                label2.Visible = false;

                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
            }


            for (int i = 0; i < principal.Sirtru.Servicios.Count; i++)
            {
                if (!principal.Sirtru.Servicios[i].Solicitante.Id.Equals(principal.UsuarioActual.Id))
                {
                    string[] fecha = principal.Sirtru.Servicios[i].TiempoSalida.Split(' ');
                    dataFiltros.Rows.Add(principal.Sirtru.Servicios[i].Solicitante.Nombre, principal.Sirtru.Servicios[i].Direccdestino1, principal.Sirtru.Servicios[i].Direccpartida1, fecha[0] + " " + fecha[1] + " " + fecha[2] + " " + fecha[3], principal.Sirtru.Servicios[i].Solicitante.NumeroTelefono);

                }
            }
        }

        public void recomendarvehiculos()
        {
            serviciosRecomendados = new List<Servicio>();

            if (principal.Sirtru.Servicios != null && principal.Sirtru.Servicios.Count > 1)
            {

                int idServ = Int32.Parse(dataGridView1.CurrentRow.Cells["colum4"].Value.ToString());

                //Partida del servicio actual del usuario que busca la recomendacion
                //string[] coordenadas = servicioActual.Partida.Split('*');
                string[] coordenadas = principal.Sirtru.Servicios[idServ].Partida.Split('*');

                double longitud1 = Double.Parse(coordenadas[0]);
                double latitud1 = Double.Parse(coordenadas[1]);

                PointLatLng partida = new PointLatLng(latitud1, longitud1);

                //Destino 

                // string[] coordenadasDestino = servicioActual.Destino.Split('*');
                string[] coordenadasDestino = principal.Sirtru.Servicios[idServ].Destino.Split('*');

                double longitud1destino = Double.Parse(coordenadas[0]);
                double latitud1destino = Double.Parse(coordenadas[1]);

                PointLatLng destino = new PointLatLng(latitud1destino, longitud1destino);

                // lista que contiene pasamos a la ruta
                List<PointLatLng> listaPuntos = new List<PointLatLng>();

                listaPuntos.Add(partida);


                bool cercaniaPartida = false;

                //servicios que cumplen

                // List<Servicio> serviciosDefinitivos = new List<Servicio>();
                List<Servicio> serviciosRecomendadosTemporales = new List<Servicio>();
                List<PointLatLng> puntosRuta = new List<PointLatLng>();

                for (int i = 0; i < principal.Sirtru.Servicios.Count && principal.Sirtru.Servicios[i] != null; i++)
                {
                    Servicio temporal = principal.Sirtru.Servicios[i];

                    // int tiempo = DateTime.Compare(DateTime.Parse(temporal.TiempoSalida), DateTime.Parse(principal.Sirtru.Servicios[idServ].TiempoSalida));
                    bool d = compararFechayHora(principal.Sirtru.Servicios[idServ].TiempoSalida, temporal.TiempoSalida);
                    if (temporal.TipoServ.Equals("VEN") && temporal.Cupos>=1 && principal.Sirtru.Servicios[idServ].TiempoSalida.Split(' ')[0].Equals(temporal.TiempoSalida.Split(' ')[0])  && d)
                    {
                        if (temporal.Puntos != null)
                        {

                            for (int j = 0; j < temporal.Puntos.Count; j += 2)
                            {
                                listaPuntos.Add(temporal.Puntos[j]);
                                GMapRoute distancia = new GMapRoute(listaPuntos, "distancia");
                                if (distancia.Distance <= CERCANIA)
                                {
                                    cercaniaPartida = true;
                                    serviciosRecomendadosTemporales.Add(temporal);
                                    break;
                                }
                                listaPuntos.RemoveAt(1);
                            }
                        }
                    }
                }
                
                if (cercaniaPartida)
                {
                    cercaniaPartida = false;
                    listaPuntos.Clear();
                    listaPuntos.Add(destino);
                    for (int i = 0; i < serviciosRecomendadosTemporales.Count; i++)
                    {
                        Servicio temporal = serviciosRecomendadosTemporales[i];
                        for (int j = 0; j < temporal.Puntos.Count; j += 2)
                        {

                            listaPuntos.Add(temporal.Puntos[j]);
                            GMapRoute distancia = new GMapRoute(listaPuntos, "distancia");

                            if (distancia.Distance <= CERCANIA)
                            {
                                cercaniaPartida = true;
                                serviciosRecomendados.Add(temporal);


                                break;
                            }
                            listaPuntos.RemoveAt(1);
                        }
                    }
                }

            }
            
        }


        public void pintarRutaRecomendada()
        {

            if (serviciosRecomendados.Count > 0) {

             int idserv = Int32.Parse(dataGridView2.CurrentRow.Cells["col1"].Value.ToString());

                GMapRoute t = new GMapRoute(principal.Sirtru.Servicios[idserv].Puntos, "PPPPPP");
                markersOverlay.Routes.Add(t);

                gmapRecomendacion.Overlays.Add(markersOverlay);
                gmapRecomendacion.Refresh();
                gmapRecomendacion.ReloadMap();
        }

        }

        public void serviciosrecomendadosenDatagrid()
        {
            if (serviciosRecomendados.Count > 0)
            {
                for(int i =0;  i<serviciosRecomendados.Count; i++)
                {                   
                    dataGridView2.Rows.Add(serviciosRecomendados[i].IdServicio, serviciosRecomendados[i].Solicitante.Id, serviciosRecomendados[i].Solicitante.Nombre, serviciosRecomendados[i].Solicitante.Carros[0].Placa, serviciosRecomendados[i].Solicitante.Carros[0].Color, serviciosRecomendados[i].Solicitante.Carros[0].Modelo, serviciosRecomendados[i].Coordepartida1, serviciosRecomendados[i].Coorddestino1, serviciosRecomendados[i].TiempoSalida);
                }
            }
            else
            {
                MessageBox.Show("No hay ningún servicio para recomendarle a esta solicitud;\n ¡Regrese más tarde!");
            }
        }


        private void listBRecomendacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            for(int i = 0; i<dataFiltros.RowCount; i++)
            {
                dataFiltros.Rows[i].Visible = false;
            }
            
            
            //dataFiltros.Rows.Clear();

            bool tiempo = cbPorFechaYHora.Checked;
            bool partida = cbLugarPartida.Checked;
            bool destino = cbLugarDestino.Checked;

            if (tiempo == true && partida == false && destino == false)
            {

                for (int i = 0; i < principal.Sirtru.getServicios().Count; i++)
                {
                    if (hora(i) && fecha(i))
                    {
                        string[] fecha = principal.Sirtru.Servicios[i].TiempoSalida.Split(' ');
                        dataFiltros.Rows.Add(principal.Sirtru.Servicios[i].Solicitante.Nombre, principal.Sirtru.Servicios[i].Direccdestino1, principal.Sirtru.Servicios[i].Direccpartida1, fecha[0] + " " + fecha[1] + " " + fecha[2] + " " + fecha[3], principal.Sirtru.Servicios[i].Solicitante.NumeroTelefono);
                    }
                }

            }
            else if (tiempo == false && partida == true && destino == false)
            {
                for (int i = 0; i < principal.Sirtru.getServicios().Count; i++)
                {
                    if (principal.Sirtru.getServicios()[i].Direccpartida1.Equals(txtPartida.Text))
                    {
                        string[] fecha = principal.Sirtru.Servicios[i].TiempoSalida.Split(' ');
                        dataFiltros.Rows.Add(principal.Sirtru.Servicios[i].Solicitante.Nombre, principal.Sirtru.Servicios[i].Direccdestino1, principal.Sirtru.Servicios[i].Direccpartida1, fecha[0] + " " + fecha[1] + " " + fecha[2] + " " + fecha[3], principal.Sirtru.Servicios[i].Solicitante.NumeroTelefono);
                    }
                }
            }
            else if (tiempo == false && partida == false && destino == true)
            {
                for (int i = 0; i < principal.Sirtru.getServicios().Count; i++)
                {
                    if (principal.Sirtru.getServicios()[i].Direccdestino1.Equals(txtDestino.Text))
                    {
                        string[] fecha = principal.Sirtru.Servicios[i].TiempoSalida.Split(' ');
                        dataFiltros.Rows.Add(principal.Sirtru.Servicios[i].Solicitante.Nombre, principal.Sirtru.Servicios[i].Direccdestino1, principal.Sirtru.Servicios[i].Direccpartida1, fecha[0] + " " + fecha[1] + " " + fecha[2] + " " + fecha[3], principal.Sirtru.Servicios[i].Solicitante.NumeroTelefono);
                    }
                }
            }

            else if (tiempo == true && partida == true && destino == false)
            {
                for (int i = 0; i < principal.Sirtru.getServicios().Count; i++)
                {
                    if (principal.Sirtru.getServicios()[i].Direccpartida1.Equals(txtPartida.Text) && hora(i) && fecha(i))
                    {
                        string[] fecha = principal.Sirtru.Servicios[i].TiempoSalida.Split(' ');
                        dataFiltros.Rows.Add(principal.Sirtru.Servicios[i].Solicitante.Nombre, principal.Sirtru.Servicios[i].Direccdestino1, principal.Sirtru.Servicios[i].Direccpartida1, fecha[0] + " " + fecha[1] + " " + fecha[2] + " " + fecha[3], principal.Sirtru.Servicios[i].Solicitante.NumeroTelefono);
                    }
                }
            }
            else if (tiempo == true && partida == false && destino == true)
            {
                for (int i = 0; i < principal.Sirtru.getServicios().Count; i++)
                {
                    if (principal.Sirtru.getServicios()[i].Direccdestino1.Equals(txtDestino.Text) && hora(i) && fecha(i))
                    {
                        string[] fecha = principal.Sirtru.Servicios[i].TiempoSalida.Split(' ');
                        dataFiltros.Rows.Add(principal.Sirtru.Servicios[i].Solicitante.Nombre, principal.Sirtru.Servicios[i].Direccdestino1, principal.Sirtru.Servicios[i].Direccpartida1, fecha[0] + " " + fecha[1] + " " + fecha[2] + " " + fecha[3], principal.Sirtru.Servicios[i].Solicitante.NumeroTelefono);
                    }
                }
            }
            else if (tiempo == false && partida == true && destino == true)
            {
                for (int i = 0; i < principal.Sirtru.getServicios().Count; i++)
                {
                    if (principal.Sirtru.getServicios()[i].Direccpartida1.Equals(txtPartida.Text) && principal.Sirtru.getServicios()[i].Direccdestino1.Equals(txtDestino.Text))
                    {
                        string[] fecha = principal.Sirtru.Servicios[i].TiempoSalida.Split(' ');
                        dataFiltros.Rows.Add(principal.Sirtru.Servicios[i].Solicitante.Nombre, principal.Sirtru.Servicios[i].Direccdestino1, principal.Sirtru.Servicios[i].Direccpartida1, fecha[0] + " " + fecha[1] + " " + fecha[2] + " " + fecha[3], principal.Sirtru.Servicios[i].Solicitante.NumeroTelefono);
                    }
                }
            }
            else if (tiempo == true && partida == true && destino == true)
            {
                for (int i = 0; i < principal.Sirtru.getServicios().Count; i++)
                {
                    if (principal.Sirtru.getServicios()[i].Direccpartida1.Equals(txtPartida.Text) && principal.Sirtru.getServicios()[i].Direccdestino1.Equals(txtDestino.Text) && hora(i) && fecha(i))
                    {
                        string[] fecha = principal.Sirtru.Servicios[i].TiempoSalida.Split(' ');
                        dataFiltros.Rows.Add(principal.Sirtru.Servicios[i].Solicitante.Nombre, principal.Sirtru.Servicios[i].Direccdestino1, principal.Sirtru.Servicios[i].Direccpartida1, fecha[0] + " " + fecha[1] + " " + fecha[2] + " " + fecha[3], principal.Sirtru.Servicios[i].Solicitante.NumeroTelefono);
                    }
                }
            }
        }

        public bool compararFechayHora(string f1, string f2)
        {
            string[] c1 = f1.Split(' ');
            string fecha1 = c1[0];
            string hora1 = c1[1];
            string indicador1 = c1[2];
            string m1 = c1[3];

            string RefernciaHora1 = hora1 + " " +indicador1+ " "+ m1;

            string[] c2 = f2.Split(' ');
            string fecha2 = c2[0];
            string hora2 = c2[1];
            string indicador2 = c2[2];
            string m2 = c2[3].Substring(0,1) + ".";
            string RefernciaHora2 = hora2 + " " +indicador2 + " "+ m2;
            bool yes = false;

            if ( DateTime.Compare(DateTime.Parse(fecha1).Date, DateTime.Parse(fecha2).Date) == -1){
                if( DateTime.Compare(DateTime.Parse(RefernciaHora1) , DateTime.Parse(RefernciaHora2) ) ==-1){
                    yes = true;
                }
            }
            
            return yes;
        }


        public bool hora(int i)
        {
            bool respuesta = false;

            //--- fecha y hora que se busca filtrar----------
            string fechayhora = dateTimePicker1.Text;
            Console.WriteLine(fechayhora);
            string[] amPm = fechayhora.Split(' ');
            string[] fechayhoraHSM = amPm[0].Split(':');
            //-----------------------------------------------

            //----fecha y hora de los servicios que cumplan con ese filtro---------------------------
            string[] fechaSEPARADODEhora = principal.Sirtru.getServicios()[i].TiempoSalida.Split(' ');
            string[] segMinMili = fechaSEPARADODEhora[1].Split(':');
            //----------------------------------------------------------------------------------------

            bool minutos = ((Int32.Parse(segMinMili[1]) >= 10 && Int32.Parse(segMinMili[1]) < 60)
                || segMinMili[1].Equals("00")
                || segMinMili[1].Equals("01")
                || segMinMili[1].Equals("02")
                || segMinMili[1].Equals("03")
                || segMinMili[1].Equals("04")
                || segMinMili[1].Equals("05")
                || segMinMili[1].Equals("06")
                || segMinMili[1].Equals("07")
                || segMinMili[1].Equals("08")
                || segMinMili[1].Equals("09"));

            bool segundos = ((Int32.Parse(segMinMili[2]) >= 10 && Int32.Parse(segMinMili[2]) < 60)
                || segMinMili[2].Equals("00")
                || segMinMili[2].Equals("01")
                || segMinMili[2].Equals("02")
                || segMinMili[2].Equals("03")
                || segMinMili[2].Equals("04")
                || segMinMili[2].Equals("05")
                || segMinMili[2].Equals("06")
                || segMinMili[2].Equals("07")
                || segMinMili[2].Equals("08")
                || segMinMili[2].Equals("09"));

            if ((segMinMili[0].Equals(fechayhoraHSM[0]) && minutos && segundos))
            {
                respuesta = true;
            }

            return respuesta;
        }

        public bool fecha(int i)
        {
            bool respuesta = false;

            // ---- datetime-------------------------------------
            string[] diamesanio = dateTimePicker2.Text.Split(' ');
            //---------------------------------------------------

            //-----servicios registrados---------------------------------------------------
            string[] diahora = principal.Sirtru.getServicios()[i].TiempoSalida.Split(' ');
            string[] aniomesdia = diahora[0].Split('/');
            //------------------------------------------------------------------------------

            string dia1 = diamesanio[1];
            string mes1 = numeroMes(diamesanio[3]) + "";
            string anio1 = diamesanio[5];

            string dia2 = aniomesdia[0];
            string mes2 = aniomesdia[1];
            string anio2 = aniomesdia[2];


            if (dia1.Equals(dia2) && mes1.Equals(mes2) && anio1.Equals(anio2))
            {
                respuesta = true;
            }
            return respuesta;
        }



        public int numeroMes(string mes)
        {
            int respuesta = 0;

            if (mes.Equals("enero"))
            {
                respuesta = 1;
            }
            else if (mes.Equals("febrero"))
            {
                respuesta = 2;
            }
            else if (mes.Equals("marzo"))
            {
                respuesta = 3;
            }
            else if (mes.Equals("abril"))
            {
                respuesta = 4;
            }
            else if (mes.Equals("mayo"))
            {
                respuesta = 5;
            }
            else if (mes.Equals("junio"))
            {
                respuesta = 6;
            }
            else if (mes.Equals("julio"))
            {
                respuesta = 7;
            }
            else if (mes.Equals("agosto"))
            {
                respuesta = 8;
            }
            else if (mes.Equals("septiembre"))
            {
                respuesta = 9;
            }
            else if (mes.Equals("octubre"))
            {
                respuesta = 10;
            }
            else if (mes.Equals("noviembre"))
            {
                respuesta = 11;
            }
            else if (mes.Equals("diciembre"))
            {
                respuesta = 12;
            }


            return respuesta;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            for(int i = 0; i<dataFiltros.RowCount; i++)
            {
                dataFiltros.Rows[i].Visible = false;
            }
            
           // dataFiltros.Rows.Clear();
        
            for (int i = 0; i < principal.Sirtru.Servicios.Count; i++)
            {
                if (!principal.Sirtru.Servicios[i].Solicitante.Id.Equals(principal.UsuarioActual.Id))
                {
                    string[] fecha = principal.Sirtru.Servicios[i].TiempoSalida.Split(' ');
                    dataFiltros.Rows.Add(principal.Sirtru.Servicios[i].Solicitante.Nombre, principal.Sirtru.Servicios[i].Direccdestino1, principal.Sirtru.Servicios[i].Direccpartida1, fecha[0] + " " + fecha[1] + " " + fecha[2] + " " + fecha[3], principal.Sirtru.Servicios[i].Solicitante.NumeroTelefono);

                }
            }
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.SetPositionByKeywords("Cali, Colombia");
            GMapOverlay markersOverlay = new GMapOverlay("MarkersOverlay");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idservicio = Int32.Parse(dataFiltros.CurrentRow.Cells["col1"].Value.ToString());



            if (principal.Sirtru.Servicios[idservicio].Cupos > 0)
            {
                if (principal.Sirtru.Servicios[idservicio].reservarCupo(usuarioActual))
                {
                    int idDueñoSericio = Int32.Parse(dataFiltros.CurrentRow.Cells["Column11"].Value.ToString());
                    string mensaje = (false + "/" + usuarioActual.Id + "/" + idservicio + "/" + "El usuario " + usuarioActual.Nombre + " desea comprar un cupo en su vehiculo para el servicio con id: " + idDueñoSericio + ", para más información comuniquese con " + usuarioActual.Nombre + " al " + usuarioActual.NumeroTelefono);
                    Usuario usuario = principal.Sirtru.buscarUsuario(idDueñoSericio + "");
                    usuario.Notificaciones.Add(mensaje);

                    MessageBox.Show("Su solicitud ha sido enviada, espere una respuesta por parte del dueño de la publicación");

                    if (principal.Sirtru.Servicios[idservicio].Cupos == 0)
                    {
                        dataFiltros.Rows.RemoveAt(dataFiltros.CurrentRow.Index);
                    }
                }


            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            recomendarvehiculos();
            serviciosrecomendadosenDatagrid();
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pintarRutaRecomendada();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idservicio = Int32.Parse(dataGridView2.CurrentRow.Cells["col1"].Value.ToString());

           

            if ( principal.Sirtru.Servicios[idservicio].Cupos > 0)
            {
                if (principal.Sirtru.Servicios[idservicio].reservarCupo(usuarioActual) && principal.Sirtru.Servicios[idservicio] != null)
                    {
                    string idDuenoSericio = dataGridView2.CurrentRow.Cells["Column11"].Value.ToString();
                    string mensaje = (false + "/" + usuarioActual.Id + "/" + idservicio + "/" + "El usuario " + usuarioActual.Nombre + " desea comprar un cupo en su vehiculo para el servicio con id: " + idDuenoSericio + ", para más información comuniquese con " + usuarioActual.Nombre + " al " + usuarioActual.NumeroTelefono);
                    Usuario usu = principal.Sirtru.buscarUsuario(idDuenoSericio);
                    usu.Notificaciones.Add(mensaje);          
                     

                    MessageBox.Show("Su solicitud ha sido enviada, espere una respuesta por parte del dueño de la publicación");

                    if(principal.Sirtru.Servicios[idservicio].Cupos == 0)
                    {
                        dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                    }
                }
                

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
