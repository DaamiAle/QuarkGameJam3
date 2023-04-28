using QuarkGameJam3.src.utilities;

namespace QuarkGameJam3.src.objects
{
    public class Player : GameObject
    {
        #region Singleton Structure
        private static Player instance;
        private Player(Coordinates pos, string repr) : base(pos, repr) { }
        public static Player Instance(Coordinates posicionInicial) => instance ??= new(posicionInicial, "@");
        #endregion
        override public bool CanBeMove() => true;
    }
}