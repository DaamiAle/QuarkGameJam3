
namespace QuarkGameJam3.src
{
    public abstract class GameObject
    {
        protected Coordenadas posicion;
        protected string? _repr;
        public Coordenadas Posicion() => posicion;
        public string Repr() => _repr ?? "null";

        public GameObject(Coordenadas pos, string repr)
        {
            posicion = pos;
            _repr = repr;
        }
    }
    
}