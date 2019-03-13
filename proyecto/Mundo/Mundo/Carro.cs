using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundo
{
    [Serializable]
    public class Carro
    {
        private string modelo;

        private string placa;

        private string color;

        // Constructor de la clase
        public Carro(string pla, string mod, string col)
        {
            modelo = mod;

            placa = pla;

            color = col;
        }

        public string Modelo { get => modelo; set => modelo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Color { get => color; set => color = value; }

        public void setModelo(string m)
        {
            modelo = m;
        }

        public void setPlaca(string m)
        {
            placa = m;
        }

        public void setColor(string m)
        {
            color = m;
        }
    }
}

