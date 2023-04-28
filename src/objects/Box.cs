using QuarkGameJam3.src.utilities;

namespace QuarkGameJam3.src.objects
{
    public class Box : GameObject
    {
        public Box(Coordinates pos, string repr) : base(pos, repr) { }
        override public bool CanBeMove() => true;
    }
}
