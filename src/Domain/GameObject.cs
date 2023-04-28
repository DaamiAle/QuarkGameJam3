using QuarkGameJam3.src.Domain.Entities;
using QuarkGameJam3.src.Utilities;
namespace QuarkGameJam3.src.Domain
{
    public abstract class GameObject
    {
        public Coordinates Position;
        public Board Board { get; protected set; }
        public virtual string Symbol { get; }
        public Coordinates Posicion() => Position;
        public string Repr() => Symbol ?? "null";

        public GameObject(Coordinates position, Board board)
        {
            this.Position = position;
            this.Board = board;
        }
        public void SetPosition(Coordinates newPosition)
        {
            this.Position = newPosition;

        }

    }

}