using QuarkGameJam3.src.Manager;
using QuarkGameJam3.src.Utilities;
using static QuarkGameJam3.src.Utilities.Enum;

namespace QuarkGameJam3.src.Domain.Entities
{
    public class Box : Movible 
    {
        public override string Symbol => "|||";

        public Box(Coordinates pos, Board tablero) : base(pos, tablero)
        {
        }

        //protected override Coordinates CalcularNuevaPosicion(Direction direccion)
        //{
        //    return Position.MoverEnDireccion(direccion);
        //}


        public override Coordinates CalcularNuevaPosicion(Direction direccion)
        {
            Coordinates nuevaPosicion = Position.MoverEnDireccion(direccion);

            // Verificar si la nueva posición está dentro del tablero
            if (!Board.EstaDentroDelTablero(nuevaPosicion))
            {
                return null; // La nueva posición está fuera del tablero, no se puede mover
            }

            // Verificar si la nueva posición está ocupada por otro objeto
            GameObject objetoEnNuevaPosicion = Board.GetBoxAtPosition(nuevaPosicion);
            if (objetoEnNuevaPosicion is Wall || objetoEnNuevaPosicion is Box)
            {
                return null; // La nueva posición está ocupada por una pared o una caja, no se puede mover
            }

            return nuevaPosicion; // La nueva posición está libre, se puede mover
        }

    }


}
