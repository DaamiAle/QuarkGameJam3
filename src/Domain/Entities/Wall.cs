using QuarkGameJam3.src.Utilities;
using System.Drawing;

namespace QuarkGameJam3.src.Domain.Entities
{
    public class Wall : GameObject
    {
        private const int SIZE = 10;
        public  override string Symbol => "#";
        public Wall(Coordinates posicion, Board board) : base(posicion, board) { }


        public void Draw()
        {
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;
            int left = (consoleWidth - SIZE) / 2;
            int top = (consoleHeight - SIZE) / 2;

            Console.SetCursorPosition(left, top);

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    Console.Write(Symbol);
                }
                Console.WriteLine();
                Console.SetCursorPosition(left, Console.CursorTop);
            }
        }
     }
 }

