using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace Mundo
{
    [Serializable]
    public class Servicio
    {

        private Usuario solicitante;

        public static string SERVICIO_DE_COMPRA = "COM";

        public static string SERVICIO_DE_VENTA = "VEN";

        private List<Usuario> reservados;

        private DateTime tiempoPublicacion;

        private string tiempoSalida;

        private int cupos;

        private string Coordepartida;

        private string Coorddestino;

        private string Direccpartida;

        private string Direccdestino;
        
        private string tipoServ;

        private GMapRoute ruta;

        private int idServicio;

        private List<PointLatLng> puntos;

        public Servicio(Usuario soli, string tSalida, int cup, string Coorpart, string Coordest,string Direcpart,string Direcdest, int idSer, string tip)
        {
            solicitante = soli;
            tiempoPublicacion = DateTime.Now;
            tiempoSalida = tSalida;
            cupos = cup;
            Coordepartida = Coorpart;
            Coorddestino = Coordest;
            reservados = new List<Usuario>();
            Direccpartida = Direcpart;
            Direccdestino = Direcdest;
            tipoServ = tip;
            idServicio = idSer;
        }

        public List<Usuario> Reservados { get { return reservados; } set { reservados = value; } }

        public string Partida { get => Coordepartida; set => Coordepartida = value; }

        public string Destino { get => Coorddestino; set => Coorddestino = value; }

        public int Cupos { get => cupos; set => cupos = value; }

        public DateTime TiempoPublicacion { get => tiempoPublicacion; set => tiempoPublicacion = value; }

        public string TiempoSalida { get => tiempoSalida; set => tiempoSalida = value; }

        public string Direccpartida1 { get => Direccpartida; set => Direccpartida = value; }

        public string Direccdestino1 { get => Direccdestino; set => Direccdestino = value; }

        public Usuario Solicitante { get => solicitante; set => solicitante = value; }

        public string Coordepartida1 { get => Coordepartida; set => Coordepartida = value; }

        public string Coorddestino1 { get => Coorddestino; set => Coorddestino = value; }

        public string TipoServ { get => tipoServ; set => tipoServ = value; }

        public GMapRoute Ruta { get => ruta; set => ruta = value; }
        public int IdServicio { get => idServicio; set => idServicio = value; }
        public List<PointLatLng> Puntos { get => puntos; set => puntos = value; }

        public bool reservarCupo(Usuario reservado)
        {
            bool x = false;
            if (cupos >= 1)
            {
                reservados.Add(reservado);
                cupos--;
                x = true;
            }
            else
            {
                return x;
            }
            return x;
        }

        
    }
}
