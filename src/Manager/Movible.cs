using QuarkGameJam3.src.Domain;
using QuarkGameJam3.src.Domain.Entities;
using QuarkGameJam3.src.Utilities;
using static QuarkGameJam3.src.Utilities.Enum;

namespace QuarkGameJam3.src.Manager
{
    public abstract class Movible : GameObject
    {

        private readonly Board board;

        public Movible(Coordinates pos, Board board) : base(pos, board)
        {
            this.board = board;
        }

        public virtual Coordinates CalculateNewPosition(Direction direction)
        {
            Coordinates newPosition;
            switch (direction)
            {
                case Direction.Up:
                    newPosition = new Coordinates(Position.X, Position.Y - 1);
                    break;
                case Direction.Down:
                    newPosition = new Coordinates(Position.X, Position.Y + 1);
                    break;
                case Direction.Left:
                    newPosition = new Coordinates(Position.X - 1, Position.Y);
                    break;
                case Direction.Right:
                    newPosition = new Coordinates(Position.X + 1, Position.Y);
                    break;
                default:
                    throw new ArgumentException("invalid address");
            }
            return newPosition;
        }

        public virtual void Move(Direction direction)
        {
            Coordinates newPos = CalculateNewPosition(direction);

            if (board.EmptyPosition(newPos))
            {
                board.MoverGameObject(this, newPos);
                Position = newPos;
            }
            else if (board.ThereIsBox(newPos))
            {
                Box box = board.GetBoxAtPosition(newPos);
                Coordinates newBoxPos = box.CalculateNewPosition(direction);

                if (board.EmptyPosition(newBoxPos))
                {
                    board.MoverGameObject(box, newBoxPos);
                    board.MoverGameObject(this, newPos);
                    Position = newPos;
                }
            }
        }

        protected bool CanMove(Direction direction, Board board)
        {
            Coordinates newPosition = CalculateNewPosition(direction);
            
            return board.EmptyPosition(newPosition) && !board.ThereIsBox(newPosition);
        }

      
    }
}
