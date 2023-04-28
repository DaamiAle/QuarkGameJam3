

namespace QuarkGameJam3.src.scenes
{
    public class Menu : BaseScene
    {
        private static Menu instance;
        private Menu() { }
        public static Menu Instance() => ( instance ??= new() );
    }
}
