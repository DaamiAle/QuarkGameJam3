
using QuarkGameJam3.src.Manager;
using QuarkGameJam3.src.Utilities;
using static QuarkGameJam3.src.Utilities.Enum;

namespace QuarkGameJam3.src.Domain.Entities
{
    public  class Board
    {
        public int rows;
        public int columns;
        private GameObject[,] objects;

        public Board(int filas, int columnas)
        {
            this.rows = filas;
            this.columns = columnas;
            this.objects = new GameObject[filas, columnas];
            Initialize();
        }
        public void Initialize()
        {
            
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;
  
            for (int i = 0; i < consoleHeight; i++)
            {
               
                for (int j = 0; j < columns; j++)
                {
                    if (i < 0 || i >= rows || j < 0 || j >= columns)
                    {
                     
                        continue;
                    }
                    if (i == 0 || j == 0 || i == consoleHeight - 1 || j == consoleWidth - 1)
                    {
                        objects[i, j] = new Wall(new Coordinates(i, j), this);
                    }
                    else
                    {
                        objects[i, j] = new EmptySpace(new Coordinates(i, j), this);
                    }
                }
            }
        }

        public bool EmptyPosition(Coordinates position)
        {
            return objects[position.X, position.Y].GetType() == typeof(EmptySpace);
        }

        public bool ThereIsBox(Coordinates position)
        {
            return objects[position.X, position.Y].GetType() == typeof(Box);
        }


        public Box GetBoxAtPosition(Coordinates position)
        {
            if (objects[position.X, position.Y].GetType() == typeof(Box))
            {
                return (Box)objects[position.X, position.Y];
            }
            else
            {
                return null;
            }
        }

   
        public void MoverGameObject(GameObject gameObject, Coordinates newPosition)
        {
            Console.SetCursorPosition(newPosition.X, newPosition.Y);
            Console.Write(gameObject.Symbol);
        }

        public void Draw()
        {

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == 0 || i == rows - 1 || j == 0 || j == columns - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
       
        public bool Insidethedashboard(Coordinates coordinates)
        {
            return coordinates.X >= 0 && coordinates.X < columns && coordinates.Y >= 0 && coordinates.Y < rows;
        }


        public void AddGameObject(GameObject gameObject)
        {
            Coordinates coordinate = gameObject.Posicion();

            if (Insidethedashboard(coordinate))
            {
                objects[coordinate.Y, coordinate.X] = gameObject;
            }
            else
            {
                Console.WriteLine("It's on the outside");
            }
        }
     
            public void RemoveGameObject(GameObject gameObject)
            {

                Console.SetCursorPosition(gameObject.Position.X, gameObject.Position.Y);
                Console.Write(" ");
            }
    }

    }
 
    
