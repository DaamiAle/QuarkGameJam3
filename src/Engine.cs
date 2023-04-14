
namespace QuarkGameJam3.src
{
    public abstract class Engine
    {
        /// <summary>
        /// Mueve un objeto que puede ser movido hacia la direccion dada.
        /// </summary>
        /// <param name="gameObject">Objeto movible a mover</param>
        /// <param name="direccion">Direccion a mover</param>
        public static void Mover(Movible gameObject, Direccion direccion)
        {
            Coordenadas posicionObject = gameObject.Posicion();
            Console.SetCursorPosition(posicionObject.X, posicionObject.Y);
            Console.Write(" ");
            if (direccion == Direccion.Arriba)
            {
                posicionObject.Y -= 1;
            }
            else if (direccion == Direccion.Derecha)
            {
                posicionObject.X += 1;
            }
            else if (direccion == Direccion.Abajo)
            {
                posicionObject.Y += 1;
            }
            else if (direccion == Direccion.Izquierda)
            {
                posicionObject.X -= 1;
            }
            Console.SetCursorPosition(posicionObject.X, posicionObject.Y);
            Console.Write(gameObject.Repr());
        }
        

    }
}
