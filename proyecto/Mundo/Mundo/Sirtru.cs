using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace Mundo
{
    [Serializable]
    public class Sirtru
    {

        public readonly string RUTA_ARCHIVO = "./archivo.txt";

        // lista de usuarios
        private List<Usuario> usuarios;

        // lista de servicios vigentes
        private List<Servicio> servicios;

        public int IdServicio;

        private Usuario actual;
        private string contraAdmin;        

        public Usuario Actual { get => actual; set => actual = value; }
        public List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        public List<Servicio> Servicios { get => servicios; set => servicios = value; }
        public string ContraAdmin { get => contraAdmin; set => contraAdmin = value; }


        // Constructor de la clase
        public Sirtru()
        {
            if (File.Exists(RUTA_ARCHIVO))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(RUTA_ARCHIVO, FileMode.Open, FileAccess.Read, FileShare.Read);
                usuarios = (List<Usuario>)formatter.Deserialize(stream);
                servicios = (List<Servicio>)formatter.Deserialize(stream);
                stream.Close();
                IdServicio = servicios.Count;
                if (servicios.Count>0) {
                    eliminarServiciosVencidos();
                }
            }
            else
            {
                usuarios = new List<Usuario>();
                servicios = new List<Servicio>();
                IdServicio = 0;
               
            }
        }

        /*Se encarga de dejar la posicion id de determinado servicio en null 
         * si la fecha y hora actual es mayor que la de la salida en la publicacion
         * los servicios deben apuntar a null ya que si se hace con .remove, los servicios
         * se corren y el id de servicios generaria excepciones por que el .count ya no seria igual
         */
        public void eliminarServiciosVencidos()
        {
            for (int i = 0; i < servicios.Count; i++)
            {
             //   if(hora actual es mayor que la hora de salida en la publicacion)
              //  servicios[i] = null;
            }
        }


        public void guardarInformacion()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(RUTA_ARCHIVO, FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(stream, usuarios);
            formatter.Serialize(stream, servicios);
            stream.Close();
            IdServicio = servicios.Count;
        }



        //Retorna true si se pudo agregar al nuevo usuario con vehiculo a la lista, retorna false si el usuario ya se encontraba
        public bool registrarUsuarioConVehiculo(string nombre, double telefono, string id, string contraseña, string placa, string modelo, string color)
        {
            //Si el usuario no está presenta en la lista, se agrega
            if (seEncuentraUsuario(id) == -1)
            {
                Usuario nuevo = new Usuario(nombre, telefono, id, contraseña);
                nuevo.cambiarAUsuarioConCarro();
                nuevo.agregarInfoCarro(placa, modelo, color);
                usuarios.Add(nuevo);
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Servicio> getServicios()
        {
            return servicios;
        }

        //Retorna true si se pudo agregar al nuevo usuario sin vehiculo a la lista, retorna false si el usuario ya se encontraba
        public bool registrarUsuarioSinVehiculo(string nombre, double telefono, string id, string contraseña)
        {
            //Si el usuario no está presenta en la lista, se agrega
            if (seEncuentraUsuario(id) == -1)
            {
                Usuario nuevo = new Usuario(nombre, telefono, id, contraseña);
                usuarios.Add(nuevo);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void agregarServicio(string id, string horaPartida, int cupos, string Cpartida, string Cdestino, string Dpartida, string Ddestino, int idServ, string tip)
        {
            
            Usuario usua = buscarUsuario(id);
            Servicio nuevo = new Servicio(usua, horaPartida, cupos, Cpartida, Cdestino, Dpartida, Ddestino, idServ, tip);
            servicios.Add(nuevo);
            usua.agregarServicTerminado(nuevo);
            IdServicio++;
        }

        public void agregarServicio(Servicio nuevoServicio)
        {
           
            string id = nuevoServicio.Solicitante.Id;
            Usuario usua = buscarUsuario(id);
            usua.agregarServicTerminado(nuevoServicio);
            servicios.Add(nuevoServicio);
            IdServicio++;
        }



        /*public List<Servicio> getListaServicios()
        {
            return servicios;
        }*/

        /*public List<Usuario> getListaUsuarios()
        {
            return usuarios;
        }*/

        public void iniciarSesion(string id)
        {
            actual = buscarUsuario(id);
        }

        


        //Devuelve al usuario con el id indicado, si no se encunetra en la lista retorna null
        public Usuario buscarUsuario(String id)
        {
            int indice = seEncuentraUsuario(id);
            if (indice != -1)
            {
                return usuarios[indice];
            }
            else
            {
                return null;
            }
        }

        //Retorna el indice en la lista si se encuentra el usuario con el id en la lista, de lo contrario retorna el valor negativo -1
        public int seEncuentraUsuario(string id)
        {
            int indice = -1;
            int tamanio = usuarios.Count;
            if (tamanio >= 0)
            {
                for (int i = 0; i < tamanio; i++)
                {
                    if (usuarios[i] != null)
                    {
                        if (usuarios[i].comparar(id))
                        {
                            indice = i;
                            break;
                        }
                    }
                }
            }
            else
            {
                return indice;
            }
            return indice;
        }

        
        public void cambiarRutaId(int id, GMapRoute ruta)
        {
            servicios[id].Ruta = ruta;
        }

        public void cambiarPuntos(int id, List<PointLatLng> punt)
        {
            servicios[id].Puntos = punt;
        }



















        // OTROS METODOS - NO SE USAN

        public void cargarUsu (string texto)
        {
            StreamReader lector = new StreamReader(texto);
            string linea = lector.ReadLine();

            while (linea != null)
            {
                string[] atributos = linea.Split(';');
                string nom = atributos[0];
                double tel = Double.Parse(atributos[1]);
                string id = atributos[2];
                string contra = atributos[3];
                string tipoU = atributos[4];

                Usuario usuario = new Usuario(nom, tel, id, contra);
                if (tipoU.Equals("USUARIO_CON_CARRO"))
                {
                    usuario.cambiarAUsuarioConCarro();
                }

                int numeroCarros = Int32.Parse(atributos[5]);
                int numeroServicios = Int32.Parse(atributos[6]);
            }
        }

        public void cargarUsuarios(string texto)
        {
            StreamReader lector = new StreamReader(texto);
            string linea = lector.ReadLine();

            while (linea!=null)
            {
                string[] atributos = linea.Split(';');
                string nom = atributos[0];
                double tel = Double.Parse(atributos[1]);
                string id = atributos[2];
                string contra = atributos[3];
                string tipoU = atributos[4];

                Usuario usuario = new Usuario(nom, tel, id, contra);
                if (tipoU.Equals("USUARIO_CON_CARRO"))
                {
                    usuario.cambiarAUsuarioConCarro();
                }


                int numeroCarros = Int32.Parse(atributos[5]);
                int numeroServicios = Int32.Parse(atributos[6]);

                if (numeroCarros > 0)
                {
                    for (int i = 0; i < numeroCarros; i++)
                    {
                        linea = lector.ReadLine();
                        string[] atributosCarro = linea.Split(';');

                        string modelo = atributosCarro[0];
                        string placa = atributosCarro[1];
                        string color = atributosCarro[2];

                        usuario.agregarInfoCarro(placa, modelo, color);
                    }
                }

                if (numeroServicios > 0)
                {
                    for (int i = 0; i < numeroServicios; i++)
                    {
                        linea = lector.ReadLine();
                        string[] atributosServicio = linea.Split(';');

                        string horaFechaSalida = atributosServicio[0];
                        int cupos = Int32.Parse(atributosServicio[1]);
                        string destino = atributosServicio[2];
                        string ubicacion = atributosServicio[3];

                       // usuario.agregarServicioTerminado(usuario, horaFechaSalida, cupos, destino, ubicacion,"","");

                    }
                }

                usuarios.Add(usuario);

                linea = lector.ReadLine();
            }
            lector.Close();
        }

        public void cargarServiciosActivos(string texto)
        {
            StreamReader lector = new StreamReader(texto);
            string linea = lector.ReadLine();

            while (linea!=null)
            {
                string[] atributos = linea.Split(';');

                string idusuario = atributos[0];
                Usuario usuario = buscarUsuario(idusuario);

                string fechayhorasalida = atributos[1];
                int cupos = Int32.Parse(atributos[2]);
                string partida = atributos[3];
                string destino = atributos[4];

                int numeroUsuariosqueHanReservado = Int32.Parse(atributos[5]);

                Servicio servicio = new Servicio(usuario, fechayhorasalida, cupos, partida, destino,"","",0,"");

                if (numeroUsuariosqueHanReservado > 0)
                {
                    for (int i = 0; i < numeroUsuariosqueHanReservado; i++)
                    {
                        string idUsuarioAux = lector.ReadLine();
                        Usuario usuarioAux = buscarUsuario(idUsuarioAux);

                        servicio.reservarCupo(usuarioAux);
                    }
                }

                servicios.Add(servicio);
                linea = lector.ReadLine();

            }
            lector.Close();
        }


        //NEW 

        public void lecturaAutomaticaUsuarios(string leer)
        {
            string[] lineas = leer.Split('\n');

            for (int i = 0; i < lineas.Length; i++)
            {

                string[] usuario = lineas[i].Split(';');

                string nombre = usuario[0];
                double telefono = Double.Parse(usuario[1]);
                string id = usuario[2];
                string clave = usuario[3];
                string tipoUsuario = usuario[4];

                Usuario nuevoUsuario = new Usuario(nombre, telefono, id, clave);

                if (tipoUsuario.Equals("USUARIO_CON_CARRO"))
                {
                    nuevoUsuario.cambiarAUsuarioConCarro();
                }
                int numCarros = Int32.Parse(usuario[5]);
                int numServiciosRegistrados = Int32.Parse(usuario[6]);

                if (numCarros > 0) {

                    for (int j = 0; j<numCarros; j++)
                    {
                        i++;

                        string[] carro = lineas[i].Split(';');

                        string modelo = carro[0];
                        string placa = carro[1];
                        string color = carro[2];

                        nuevoUsuario.agregarInfoCarro(placa, modelo, color);
                    }

                }


                if (numServiciosRegistrados > 0)
                {
                    for(int j =0; j<numServiciosRegistrados; j++)
                    {
                        i++;

                        string[] servicio = lineas[i].Split(';');

                        string fechayhora = servicio[0];
                        int cupos = Int32.Parse(servicio[1]);
                        string destino = servicio[2];
                        string partida = servicio[3];

                       // nuevoUsuario.agregarServicioTerminado(nuevoUsuario, fechayhora, cupos, destino, partida,"","");
                        
                    }
                }
                usuarios.Add(nuevoUsuario);

            }
        }


        public bool Filtrar()
        {
            return true;
        }


        public void lecturaAutomaticaServiciosActivos(string texto)
        {

            string[] linea = texto.Split('\n');


            for(int i = 0; i<linea.Length; i++)
            {

                string[] servicio = linea[i].Split(';');

                string idusuario = servicio[0];
                Usuario usuario = buscarUsuario(idusuario);

                string fechayhorasalida = servicio[1];
                int cupos = Int32.Parse(servicio[2]);
                string partida = servicio[3];
                string destino = servicio[4];

                int numeroUsuariosqueHanReservado = Int32.Parse(servicio[5]);

                Servicio nuevoServicio = new Servicio(usuario, fechayhorasalida, cupos, partida, destino,"","",0,"");

                if (numeroUsuariosqueHanReservado > 0)
                {
                    for (int j = 0; j < numeroUsuariosqueHanReservado; j++)
                    {
                        i++;
                        string idUsuarioAux = linea[i];
                        Usuario usuarioAux = buscarUsuario(idUsuarioAux);

                        nuevoServicio.reservarCupo(usuarioAux);
                    }
                }
                servicios.Add(nuevoServicio);
            }
        }



        public bool Recomendar()
        {
            return true;
        }

        public List<Servicio> RecomendacionUSUSIN(string id)
        {
            List<Servicio> listaRecomendaciones = new List<Servicio>();
            Usuario user = buscarUsuario(id);
            string direccionDes = "";
            string direccionPar = "";

            for (int j=0; j< user.ServiciosRegistrados.Count;j++)
            {
                if (j== user.ServiciosRegistrados.Count-1)
                {
                    direccionDes = user.ServiciosRegistrados[j].Direccdestino1;
                    direccionPar = user.ServiciosRegistrados[j].Direccpartida1;
                }
            }
            
            for (int i=0; i<servicios.Count;i++)
            {
                if (servicios[i].TipoServ.Equals("VEN"))
                {
                    if (!(servicios[i].Solicitante.Id.Equals(id)))
                    {
                        if(servicios[i].Direccdestino1.Equals(direccionDes) && servicios[i].Direccpartida1.Equals(direccionPar))
                        {
                            listaRecomendaciones.Add(Servicios[i]);
                        }
                    }

                }
            }
            return listaRecomendaciones;
        }
            // RecomendacionUsuariosSin(){}

            // public boolean eliminarServicio(){}

            // public boolean editarservicio(){}


        }
}
