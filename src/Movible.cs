using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkGameJam3.src
{
    public class Movible : GameObject
    {
        public Movible(Coordenadas pos, string repr) : base(pos, repr) { }
        /// <summary>
        /// Mueve a la entidad en la direccion dada.
        /// Verifica que este dentro de los limites del tablero.
        /// </summary>
        /// <param name="direccion">Direccion en la que se desea mover</param>
        public void Mover(Direccion direccion)
        {
            bool sePuedeMover = false;
            if (Utilidades.Between(posicion.X, 1, 19) && Utilidades.Between(posicion.Y, 1, 9)) sePuedeMover = true;
            else if (direccion == Direccion.Arriba && posicion.Y > 0) sePuedeMover = true;
            else if (direccion == Direccion.Derecha && posicion.X < 20) sePuedeMover = true;
            else if (direccion == Direccion.Abajo && posicion.Y < 10) sePuedeMover = true;
            else if (direccion == Direccion.Izquierda && posicion.X > 0) sePuedeMover = true;

            if (sePuedeMover) Engine.Mover(this, direccion);
        }
    }
}
