using QuarkGameJam3.src.objects;
using QuarkGameJam3.src.utilities;

namespace QuarkGameJam3.src.core
{
    public class BehabourEngine : IBehabour
    {
        #region Singleton Structure
        private static BehabourEngine engine;
        private BehabourEngine() { }
        public static BehabourEngine Instance() => engine ??= new();
        #endregion
        /// <summary>
        /// Mueve a la entidad en la direccion dada.
        /// Verifica que este dentro de los limites del tablero.
        /// </summary>
        /// <param name="direccion">Direccion en la que se desea mover</param>
        public void Mover(GameObject gameObject, Direction direccion)
        {
            bool sePuedeMover = false;
            //if (AuxFunctions.Between(posicion.X, 1, 19) && AuxFunctions.Between(posicion.Y, 1, 9)) sePuedeMover = true;
            //else if (direccion == Direction.Up && posicion.Y > 0) sePuedeMover = true;
            //else if (direccion == Direction.Right && posicion.X < 20) sePuedeMover = true;
            //else if (direccion == Direction.Down && posicion.Y < 10) sePuedeMover = true;
            //else if (direccion == Direction.Left && posicion.X > 0) sePuedeMover = true;

            //if (sePuedeMover) RendererEngine.Mover(this, direccion);
        }

        public void Move(GameObject gameObject, Direction direction)
        {
            if (CanBeMove(gameObject, direction))
            {

            }
        }

        private bool CanBeMove(GameObject gameObject, Direction direction)
        {
            bool isMovableObject = gameObject.CanBeMove();
            bool isBorderPosition = true;
            bool willColide = true;
            bool isMovableCollide = false;
            bool coliderWillColide;
            if (isMovableObject)
            {
                isBorderPosition = IsBorderPosition(gameObject.Position());
                if (!isBorderPosition)
                {
                    willColide = WillCollideIn(gameObject, direction);
                    if (willColide)
                    {
                        // ya que va a colicionar hay que ver con que
                        Coordinates directionCoordinates = gameObject.Position().Translate(direction);
                        GameObject objectColider = GameEngine.ActualScene().GameObjects.Find(obj => obj.Position().EquialsTo(directionCoordinates));
                        // ver si se puede mover
                        coliderWillColide = WillCollideIn(objectColider, direction);
                        if (coliderWillColide)
                        {
                            // si el objeto con el que coliciona se puede mover
                        }
                        else
                        {
                            // si el objeto con el que coliciona se puede mover
                        }
                    }
                }
                else
                {
                    // ya que esta en el borde no se puede mover
                    
                }


            }
            return isMovableObject && (!willColide || isMovableCollide);
        }

        private bool WillCollideIn(GameObject gameObject, Direction direction)
        {
            Coordinates directionCoordinates = gameObject.Position().Translate(direction);
            return GameEngine.ActualScene().GameObjects.Any(obj => obj.Position().EquialsTo(directionCoordinates));
        }
        private bool IsBorderPosition(Coordinates coordinates)
        {
            return coordinates.X == 0 || coordinates.X == GameEngine.MaxCoordinates().X || coordinates.Y == 0 || coordinates.Y == GameEngine.MaxCoordinates().Y;
        }
    }
}
