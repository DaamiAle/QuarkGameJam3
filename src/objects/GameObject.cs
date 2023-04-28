using QuarkGameJam3.src.utilities;

namespace QuarkGameJam3.src.objects
{
    public abstract class GameObject
    {
        protected Coordinates position;
        protected string? _repr;
        public Coordinates Position() => position;
        public string? Repr() => _repr;

        public GameObject(Coordinates pos, string repr)
        {
            position = pos;
            _repr = repr;
        }
        public virtual bool CanBeMove() => false;
    }

}