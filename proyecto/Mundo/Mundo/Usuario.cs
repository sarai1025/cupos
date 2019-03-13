using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundo
{
    [Serializable]
    public class Usuario
    {
        public static string USUARIO_CON_CARRO = "c";

        public static string USUARIO_SIN_CARRO = "s";

        private string nombre;

        private double numeroTelefono;

        private string id;

        private string contraseña;

        private string tipo;

        private string imagen;

        private List<Carro> carros;

        // su concatenacion sera: fue respondida/id usuario que solicito el servicio/ id servicio que esta
        //solicitando/el mensaje 
        private List<string> notificaciones;

        //new
        private List<Servicio> serviciosRegistrados;


        public string Nombre { get { return nombre; } set { nombre = value; } }
        public double NumeroTelefono { get { return numeroTelefono; } set { numeroTelefono = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string Contraseña { get { return contraseña; } set { contraseña = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }

        public List<Carro> Carros { get => carros; set => carros = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public List<Servicio> ServiciosRegistrados { get => serviciosRegistrados; set => serviciosRegistrados = value; }
        public List<string> Notificaciones { get => notificaciones; set => notificaciones = value; }



        // Constructor de la clase
        public Usuario(string name, double phoneNumber, string identification, string password)
        {
            tipo = USUARIO_SIN_CARRO;

            nombre = name;
            numeroTelefono = phoneNumber;
            id = identification;
            contraseña = password;
            carros = new List<Carro>();
            //new
            serviciosRegistrados = new List<Servicio>();
            notificaciones = new List<string>();
        }

        public void cambiarAUsuarioConCarro()
        {
            tipo = USUARIO_CON_CARRO;
        }

        //Agrega informacion del carro´exclusivamente para usuarios con vehiculo
        public void agregarInfoCarro(string placa, string modelo, string color)
        {
            Carro nuevo = new Carro(placa, modelo, color);
            carros.Add(nuevo);
        }


        //Compara si el id pasado por parametro es igual al de este usuario especifico
        public bool comparar(string identificacion)
        {
            if (id.Equals(identificacion))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //new 
        /*public void agregarServicioTerminado(Usuario usuario, string fechayhoraSalida, int cupos, string partida, string destino,string Dpartida,string Ddestino)
        {

            Servicio servicio = new Servicio(usuario, fechayhoraSalida, cupos, partida, destino,Dpartida,Ddestino);
            serviciosRegistrados.Add(servicio);
        }*/

        public void agregarServicTerminado(Servicio serv)
        {
            serviciosRegistrados.Add(serv); 
        }
        

    }
}
