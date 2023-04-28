
using QuarkGameJam3.src.Manager;
using QuarkGameJam3.src.Utilities;
using static QuarkGameJam3.src.Utilities.Enum;

namespace QuarkGameJam3.src.Domain.Entities
{
        public  class Player : Movible
        {

        public override string Symbol => "X";
        public Player(Coordinates pos, Board board) : base(pos, board)
        {
        }


        public override Coordinates CalculateNewPosition(Direction direction)
        {
            Coordinates newPosition = base.CalculateNewPosition(direction);
            if (!Board.Insidethedashboard(newPosition))
            {
                return Position;
            }
            return newPosition;
        }


        public void Move(Direction direction)
        {
            Coordinates newPosition = CalculateNewPosition(direction);
            GameObject objectEnNewPosition = Board.GetBoxAtPosition(newPosition);

            if (objectEnNewPosition is Wall)
            {
                return;
            }

            if (objectEnNewPosition is Box)
            {
                Box box = (Box)objectEnNewPosition;
                Coordinates newPositionBox = box.CalculateNewPosition(direction);
                GameObject objectInNewPosBox = Board.GetBoxAtPosition(newPositionBox);

                if (objectInNewPosBox is Wall || objectInNewPosBox is Box)
                {
                    return;
                }
                Board.MoverGameObject(box, newPositionBox);
            }

            if (newPosition != null)
            {
                Board.RemoveGameObject(this);
                Position = newPosition;
               
            }
            Board.MoverGameObject(this, newPosition);
        }
      
        }
    }

