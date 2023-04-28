
using QuarkGameJam3.src.scenes;
using QuarkGameJam3.src.utilities;

namespace QuarkGameJam3.src
{
    public static class GameEngine
    {
        private static BaseScene scene;
        private static Coordinates maxCoordinates;
        public static BaseScene ActualScene() => scene;
        public static Coordinates MaxCoordinates() => maxCoordinates ??= new(104,24);
        public static void Run()
        {
            #region CLI Configuration
            // seteamos el tamaño de la CLI
            Console.WindowWidth = 128;
            Console.WindowHeight = 32;
            // ocultamos el cursor
            Console.CursorVisible = false;
            // Un poco de publicidad a Quark
            Console.Title = "Quark Academy - Game Jam 3 - Sokoban";
            #endregion

            Console.WriteLine(Console.Title);
            
            // Renderizamos el menu
            // Esperamos tecla


            bool closeProgram = false;
            while (!closeProgram)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        //Mover seleccion arriba
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        //Mover seleccion abajo
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        //Entrar en opcion
                    }
                }



            /*/ViewMenu menu = new();
            bool finalizar = false;
            
            Player.Inicializar(new(4, 6));
            while (!finalizar)// Este bucle se encarga de mantener el programa corriendo
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        Player.Mover(Direccion.Arriba);
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        Player.Mover(Direccion.Derecha);
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        Player.Mover(Direccion.Abajo);
                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                        Player.Mover(Direccion.Izquierda);
                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        finalizar = true;
                        // Renderizar Menu Principal
                    }
                    
                }*/
            }
        }
    }
}
