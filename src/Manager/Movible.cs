using QuarkGameJam3.src.Domain;
using QuarkGameJam3.src.Domain.Entities;
using QuarkGameJam3.src.Utilities;
using System.Runtime.CompilerServices;
using static QuarkGameJam3.src.Utilities.Enum;

namespace QuarkGameJam3.src.Manager
{
    public abstract class Movible : GameObject
    {

        private readonly Board tablero;

        public Movible(Coordinates pos, Board tablero) : base(pos, tablero)
        {
            this.tablero = tablero;
        }

        public virtual Coordinates CalcularNuevaPosicion(Direction direccion)
        {
            Coordinates nuevaPosicion;
            switch (direccion)
            {
                case Direction.Up:
                    nuevaPosicion = new Coordinates(Position.X, Position.Y - 1);
                    break;
                case Direction.Down:
                    nuevaPosicion = new Coordinates(Position.X, Position.Y + 1);
                    break;
                case Direction.Left:
                    nuevaPosicion = new Coordinates(Position.X - 1, Position.Y);
                    break;
                case Direction.Right:
                    nuevaPosicion = new Coordinates(Position.X + 1, Position.Y);
                    break;
                default:
                    throw new ArgumentException("Dirección inválida");
            }
            return nuevaPosicion;
        }
        //public void Move(Direction direction)
        //{
        //    bool canMove = false;

        //    if (Utilities.Utilities.Between(posicion.X, 1, 19) && Utilities.Utilities.Between(posicion.Y, 1, 9))
        //        canMove = true;
        //    else if (direction == Direction.Up && posicion.Y > 0)
        //        canMove = true;
        //    else if (direction == Direction.Right && posicion.X < 20)
        //        canMove = true;
        //    else if (direction == Direction.Down && posicion.Y < 10)
        //        canMove = true;
        //    else if (direction == Direction.Left && posicion.X > 0)
        //        canMove = true;

        //    Engine.Move(this, direction);
          
        //}

        public virtual void Move(Direction direction)
        {
            Coordinates newPos = CalcularNuevaPosicion(direction);

            if (tablero.PosicionVacia(newPos))
            {
                tablero.MoverGameObject(this, newPos);
                Position = newPos;
            }
            else if (tablero.HayBox(newPos))
            {
                Box box = tablero.GetBoxAtPosition(newPos);
                Coordinates newBoxPos = box.CalcularNuevaPosicion(direction);

                if (tablero.PosicionVacia(newBoxPos))
                {
                    tablero.MoverGameObject(box, newBoxPos);
                    tablero.MoverGameObject(this, newPos);
                    Position = newPos;
                }
            }
        }

        protected bool PuedeMover(Direction direccion, Board tablero)
        {
            Coordinates nuevaPosicion = CalcularNuevaPosicion(direccion);
            return tablero.PosicionVacia(nuevaPosicion) && !tablero.HayBox(nuevaPosicion);
        }

      
    }
}
