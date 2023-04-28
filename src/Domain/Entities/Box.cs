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


        public override Coordinates CalculateNewPosition(Direction direccion)
        {
            Coordinates newPosition = Position.MoverEnDireccion(direccion);

            if (!Board.Insidethedashboard(newPosition))
            {
                return null;
            }
            GameObject objetoEnNuevaPosicion = Board.GetBoxAtPosition(newPosition);
            if (objetoEnNuevaPosicion is Wall || objetoEnNuevaPosicion is Box)
            {
                return null;
            }

            return newPosition;
        }

    }


}
