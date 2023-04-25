
using static QuarkGameJam3.src.Utilities.Enum;

namespace QuarkGameJam3.src.Utilities
{
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Coordinates(int x, int y) { X = x; Y = y; }

        public Coordinates MoverEnDireccion(Direction direccion)
        {
            switch (direccion)
            {
                case Direction.Up:
                    return new Coordinates(X, Y - 1);
                case Direction.Down:
                    return new Coordinates(X, Y + 1);
                case Direction.Left:
                    return new Coordinates(X - 1, Y);
                case Direction.Right:
                    return new Coordinates(X + 1, Y);
                default:
                    throw new ArgumentException("Dirección inválida");
            }
        }
    }
}
