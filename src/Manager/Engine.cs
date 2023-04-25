using QuarkGameJam3.src.Domain;
using QuarkGameJam3.src.Utilities;
using static QuarkGameJam3.src.Utilities.Enum;

namespace QuarkGameJam3.src.Manager
{
    public abstract class Engine
    {

        public static void Move(Movible movibleObject, Direction direccion)
        {
            HideGameObjectOnScreen(movibleObject);
            if (direccion == Direction.Up)
            {
                movibleObject.Posicion().Y -= 2;
            }
            else if (direccion == Direction.Right)
            {
                movibleObject.Posicion().X += 2;
            }
            else if (direccion == Direction.Down)
            {
                movibleObject.Posicion().Y += 2;
            }
            else if (direccion == Direction.Left)
            {
                movibleObject.Posicion().X -= 2;
            }
            ShowGameObjectOnScreen(movibleObject);

        }


        public static void ShowGameObjectOnScreen(GameObject gameObject)
        {
            string reprGameObject = gameObject.Repr();
            Coordinates posGameObject = gameObject.Posicion();
            Console.SetCursorPosition(posGameObject.X, posGameObject.Y);
            Console.Write(reprGameObject + reprGameObject);
            Console.SetCursorPosition(posGameObject.X, posGameObject.Y + 1); // Sumar 1 aquí
            Console.Write(reprGameObject + reprGameObject);
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
