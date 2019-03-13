using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mundo;

namespace PruebasUnitarias
{
    [TestClass]
    public class SirtruTest
    {
         private Sirtru mundo;

        private void escenario1()
        {
            mundo = new Sirtru();
            mundo.registrarUsuarioSinVehiculo("Leslie", 4330199, "1144205402", "Hola");
        }

        private void escenario2()
        { 
            mundo = new Sirtru();
            mundo.registrarUsuarioConVehiculo("Sarai", 32455555, "1144506709", "Holiwi", "KWZ99","Mazda","Gris");
            mundo.registrarUsuarioConVehiculo("Leslie", 4330199, "1144205402", "Holi", "ZYM755", "chevrolet", "Rojo");
            mundo.registrarUsuarioConVehiculo("Andres", 4556777, "1144789909", "Chau", "MNG88", "Mazda", "Blanco");
        }

        private void escenario3()
        {
            mundo = new Sirtru();
            mundo.registrarUsuarioConVehiculo("Sarai", 32455555, "1144506709", "Holiwi", "KWZ99", "Mazda", "Gris");
            mundo.registrarUsuarioConVehiculo("Leslie", 4330199, "1144205402", "Holi", "ZYM755", "chevrolet", "Rojo");
            mundo.registrarUsuarioConVehiculo("Andres", 4556777, "1144789909", "Chau", "MNG88", "Mazda", "Blanco");
            mundo.registrarUsuarioSinVehiculo("Paola", 43306666, "1144203302", "Integrador");
        }

        private void escenario4()
        {
            mundo = new Sirtru();
            mundo.registrarUsuarioConVehiculo("Sarai", 32455555, "1144506709", "Holiwi", "KWZ99", "Mazda", "Gris");
            mundo.agregarServicio("1144506709", "3:00PM", 3, "Icesi", "Jardin plaza","Universidad Icesi","Centro comercial Jardin Plaza",1,"VEN");
        }

        private void escenario5()
        {
            mundo = new Sirtru();
            mundo.lecturaAutomaticaUsuarios(Properties.Resources.Usuarios);
            mundo.lecturaAutomaticaServiciosActivos(Properties.Resources.Servicios);
        }

        //Metodo agregar ususario sin
        [TestMethod]
        public void TestMethod1()
        {
            //PARA USUARIOS SIN VEHICULO
            escenario1();

            //Comprobamos que la lista tenga un elemento
            Assert.IsTrue(1 == mundo.Usuarios.Count);

            //Comprobamos que el primer usuario de la lista sea el esperado
            Assert.AreEqual("Leslie", mundo.Usuarios[0].Nombre);
            Assert.AreEqual(4330199, mundo.Usuarios[0].NumeroTelefono);
            Assert.AreEqual("1144205402", mundo.Usuarios[0].Id);
            Assert.AreEqual("Hola", mundo.Usuarios[0].Contraseña);            
            
        }

        //Metodo agregar usuaario con

        [TestMethod]
        public void TestMethod4()
        {
            escenario2();

            //comprobamos que la lisa tiene mas de un elemento
            Assert.IsFalse(1 == mundo.Usuarios.Count);

            //Comprobamos que los id de los usuarios que se han registrado existan en la lista
            Assert.AreEqual("1144506709", mundo.Usuarios[0].Id);
            Assert.AreEqual("1144205402", mundo.Usuarios[1].Id);
            Assert.AreEqual("1144789909", mundo.Usuarios[2].Id);

            Assert.IsNotNull(mundo.Usuarios[0]);
            Assert.IsNotNull(mundo.Usuarios[1]);
            Assert.IsNotNull(mundo.Usuarios[2]);

        }
        

        //Metodo buscar usuario
        [TestMethod]
        public void TestMethod2()
        {
            escenario3();

            Assert.IsNotNull(mundo.buscarUsuario("1144205402"));
            Assert.IsNotNull(mundo.buscarUsuario("1144506709"));
            Assert.IsNotNull(mundo.buscarUsuario("1144789909"));
            Assert.IsNotNull(mundo.buscarUsuario("1144203302"));

            Assert.IsTrue(mundo.buscarUsuario("1144205402").Nombre.Equals("Leslie"));
        }      

        //Metodo agregar servicio

        [TestMethod]
        public void TestMethod3()
        {
            escenario4();

            Assert.IsTrue(1 == mundo.Servicios.Count);
            Assert.IsNotNull(mundo.Servicios[0]);
        }

        //Metodo seEncuentraUsuario
        [TestMethod]
        public void TestMethod5()
        {
            escenario3();
            //Caso que si esten en la lista
            Assert.IsTrue(mundo.seEncuentraUsuario("1144205402") == 1);
            Assert.IsTrue(mundo.seEncuentraUsuario("1144506709") == 0);
            Assert.IsTrue(mundo.seEncuentraUsuario("1144789909") == 2);
            Assert.IsTrue(mundo.seEncuentraUsuario("1144203302") == 3);

            //Que no este en la lista
            Assert.IsTrue(mundo.seEncuentraUsuario("1144203305") == -1);
        }

        //Metodo cargar ususarios
        [TestMethod]
        public void TestMethod6()
        {
            escenario5();
            Assert.IsNotNull(mundo.buscarUsuario("1143875490"));
            Assert.IsNotNull(mundo.buscarUsuario("1143444502"));
            Assert.IsNotNull(mundo.buscarUsuario("1133567890"));
            Assert.IsNotNull(mundo.buscarUsuario("1155767890"));
        }

        //Metodo cargar servicios
        [TestMethod]
        public void TestMethod7()
        {
            escenario5();
            Assert.IsTrue(2 == mundo.Servicios.Count);
            Assert.IsNotNull(mundo.Servicios[0]);
            Assert.IsNotNull(mundo.Servicios[1]);
        }

        //Metodo filtrar
        [TestMethod]
        public void TestMethod8()
        {
            escenario3();
            Assert.IsTrue(mundo.Filtrar());
            Assert.IsFalse(mundo.Filtrar() == false);
        }

        //Metodo Recomendar
        [TestMethod]
        public void TestMethod9()
        {
            escenario3();
            Assert.IsTrue(mundo.Recomendar());
            Assert.IsFalse(mundo.Recomendar() == false);
        }
    }
}