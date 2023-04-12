using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkGameJam3
{
    internal class Jugador
    {
        private string _nombre;
        public Jugador(string nombre)
        {
            _nombre = nombre;
        }
        public void ImprimirNombre()
        {
            Console.WriteLine("Hola, soy " + _nombre);
        }
    }
}
