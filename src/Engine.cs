
namespace QuarkGameJam3.src
{
    public abstract class Engine
    {
        /// <summary>
        /// Mueve un objeto que puede ser movido hacia la direccion dada.
        /// </summary>
        /// <param name="movibleObject">Objeto movible a mover</param>
        /// <param name="direccion">Direccion a mover</param>
        public static void Mover(Movible movibleObject, Direccion direccion)
        {
            Ocultar(movibleObject);
            if (direccion == Direccion.Arriba)
            {
                movibleObject.Posicion().Y -= 2;
            }
            else if (direccion == Direccion.Derecha)
            {
                movibleObject.Posicion().X += 2;
            }
            else if (direccion == Direccion.Abajo)
            {
                movibleObject.Posicion().Y += 2;
            }
            else if (direccion == Direccion.Izquierda)
            {
                movibleObject.Posicion().X -= 2;
            }
            Mostrar(movibleObject);
        }
        /// <summary>
        /// Renderiza en pantalla un GameObject.
        /// </summary>
        /// <param name="gameObject">GameObject a renderizar</param>
        public static void Mostrar(GameObject gameObject)
        {
            string reprGameObject = gameObject.Repr();
            Coordenadas posGameObject = gameObject.Posicion();
            Console.SetCursorPosition(posGameObject.X, posGameObject.Y);
            Console.Write(reprGameObject + reprGameObject);
            Console.SetCursorPosition(posGameObject.X, posGameObject.Y + 1);
            Console.Write(reprGameObject + reprGameObject);

        }
        /// <summary>
        /// Elimina de escena un GameObject.
        /// </summary>
        /// <param name="gameObject">GameObject a eliminar</param>
        public static void Ocultar(GameObject gameObject)
        {
            Coordenadas posGameObject = gameObject.Posicion();
            Console.SetCursorPosition(posGameObject.X, posGameObject.Y);
            Console.Write("  ");
            Console.SetCursorPosition(posGameObject.X, posGameObject.Y + 1);
            Console.Write("  ");
        }

    }
}
