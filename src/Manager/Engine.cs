using QuarkGameJam3.src.Domain;
using QuarkGameJam3.src.Utilities;
using static QuarkGameJam3.src.Utilities.Enum;

namespace QuarkGameJam3.src.Manager
{
    public abstract class Engine
    {

        public static void ShowGameObjectOnScreen(GameObject gameObject)
        {
            string reprGameObject = gameObject.Repr();
            Coordinates posGameObject = gameObject.Posicion();
            Console.SetCursorPosition(posGameObject.X, posGameObject.Y);
            Console.Write(reprGameObject);
        }
        public static void HideGameObjectOnScreen(GameObject gameObject)
        {
            Coordinates posGameObject = gameObject.Posicion();
            Console.SetCursorPosition(posGameObject.X, posGameObject.Y);
            Console.Write("  ");
            Console.SetCursorPosition(posGameObject.X, posGameObject.Y + 1);
            Console.Write("  ");
        }

    }
}
