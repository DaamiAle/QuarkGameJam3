using System;


namespace QuarkGameJam3.src.utilities
{
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Coordinates(int x, int y) { X = x; Y = y; }
        public Coordinates Translate(Direction direction)
        {
            return (int)direction switch
            {
                0 => new Coordinates(X, Y - 2),
                1 => new Coordinates(X + 2, Y),
                2 => new Coordinates(X, Y + 2),
                3 => new Coordinates(X - 2, Y),
                _ => this
            };
        }

        public bool EquialsTo(Coordinates coordinates) => coordinates.X == X && coordinates.Y == Y;
        public override string ToString() => $"({X}, {Y})";
    }
}
