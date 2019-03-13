using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mundo;

namespace PruebasUnitarias
{
    [TestClass]
    public class UsuarioTest
    {
        private Sirtru mundo;

        private void escenario1()
        {
            mundo = new Sirtru();
            mundo.registrarUsuarioConVehiculo("Sarai", 32455555, "1144506709", "Holiwi", "KWZ99", "Mazda", "Gris");
            mundo.registrarUsuarioConVehiculo("Leslie", 4330199, "1144205402", "Holi", "ZYM755", "chevrolet", "Rojo");
        }

        //Metodo agregarInfoCarro
        [TestMethod]
        public void TestMethod1()
        {
            escenario1();
            Assert.IsTrue(mundo.buscarUsuario("1144506709").Carros[0].Placa == "KWZ99" );
            Assert.IsTrue(mundo.buscarUsuario("1144205402").Carros[0].Placa == "ZYM755");
        }
       
    }

    
}
