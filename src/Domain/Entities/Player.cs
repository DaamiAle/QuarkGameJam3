
using QuarkGameJam3.src.Manager;
using QuarkGameJam3.src.Utilities;
using static QuarkGameJam3.src.Utilities.Enum;

namespace QuarkGameJam3.src.Domain.Entities
{
        public  class Player : Movible
        {

        public override string Symbol => "X";
        public Player(Coordinates pos, Board tablero) : base(pos, tablero)
        {
           // Engine.ShowGameObjectOnScreen(");
        }

        public override Coordinates CalcularNuevaPosicion(Direction direccion)
        {
            Coordinates nuevaPos = base.CalcularNuevaPosicion(direccion);
            if (!Board.EstaDentroDelTablero(nuevaPos))
            {
                return Position;
            }

            return nuevaPos;
            
        }


        public void Move(Direction direction)
        {
            Coordinates nuevaPos = CalcularNuevaPosicion(direction);
            GameObject objetoEnNuevaPos = Board.GetBoxAtPosition(nuevaPos);


            if (objetoEnNuevaPos is Wall)
            {
                return;
            }

            if (objetoEnNuevaPos is Box)
            {
                Box box = (Box)objetoEnNuevaPos;
                Coordinates nuevaPosBox = box.CalcularNuevaPosicion(direction);
                GameObject objetoEnNuevaPosBox =Board.GetBoxAtPosition(nuevaPosBox);

                if (objetoEnNuevaPosBox is Wall || objetoEnNuevaPosBox is Box)
                {
                    return;
                }

                Board.MoverGameObject(box, nuevaPosBox);
            }

            Board.MoverGameObject(this, nuevaPos);
        }

    }
  }

