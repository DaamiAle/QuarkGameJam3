
using QuarkGameJam3.src.Utilities;

namespace QuarkGameJam3.src.Domain.Entities
{
    public  class Board
    {
        public int filas;
        public int columnas;
        private GameObject[,] objetos;

        public Board(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
            this.objetos = new GameObject[filas, columnas];
            Inicializar();
        }
        public void Inicializar()
        {
            
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;
  
            for (int i = 0; i < consoleHeight; i++)
            {
               
                for (int j = 0; j < columnas; j++)
                {
                    if (i < 0 || i >= filas || j < 0 || j >= columnas)
                    {
                     
                        continue;
                    }
                    if (i == 0 || j == 0 || i == consoleHeight - 1 || j == consoleWidth - 1)
                    {
                        objetos[i, j] = new Wall(new Coordinates(i, j), this);
                    }
                    else
                    {
                        objetos[i, j] = new EmptySpace(new Coordinates(i, j), this);
                    }
                }
            }
        }

        public bool PosicionVacia(Coordinates posicion)
        {
            return objetos[posicion.X, posicion.Y].GetType() == typeof(EmptySpace);
        }

        public bool HayBox(Coordinates posicion)
        {
            return objetos[posicion.X, posicion.Y].GetType() == typeof(Box);
        }


        public Box GetBoxAtPosition(Coordinates posicion)
        {
            if (objetos[posicion.X, posicion.Y].GetType() == typeof(Box))
            {
                return (Box)objetos[posicion.X, posicion.Y];
            }
            else
            {
                return null;
            }
        }
        public void MoverGameObject(GameObject objeto, Coordinates posicionNueva)
        {
            // Obtener la posición actual del objeto
            Coordinates posicionActual = objeto.Posicion();

            // Actualizar el tablero: vaciar la casilla actual y colocar el objeto en la nueva casilla
            objetos[posicionActual.X, posicionActual.Y] = new EmptySpace(posicionActual, this);
            objetos[posicionNueva.X, posicionNueva.Y] = objeto;

            // Actualizar la posición del objeto
            objeto.SetPosition(posicionNueva);
        }

        public void Dibujar()
        {

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (i == 0 || i == filas - 1 || j == 0 || j == columnas - 1)
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
       
        public bool EstaDentroDelTablero(Coordinates coordenada)
        {
            return coordenada.X >= 0 && coordenada.X < columnas && coordenada.Y >= 0 && coordenada.Y < filas;
        }


        public void AddGameObject(GameObject objeto)
        {
            Coordinates coordenada = objeto.Posicion();

            if (EstaDentroDelTablero(coordenada))
            {
                objetos[coordenada.Y, coordenada.X] = objeto;
            }
            else
            {
                Console.WriteLine("It's on the outside");
            }
        }
    }
}
