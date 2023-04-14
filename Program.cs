using QuarkGameJam3.src;

namespace QuarkGameJam3
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool finalizar = false;
            Console.CursorVisible = false;
            Console.Title = "Quark Game Jam 3";
            //Jugador.Inicializar(new Coordenadas(1, 5)); //
            
            
            // Renderizar Menu Principal
            
            while (!finalizar)// Este bucle se encarga de mantener el programa corriendo
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    
                    // Aca el control de eventos del menu
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        // Movimiento dentro del menu hacia arriba
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        // Movimiento dentro del menu hacia abajo
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        // Aca hay que verificar las coordenadas del cursor para saber
                        // que opcion esta seleccionada y desencadenarla
                    }

                    
                    bool salirAlMenuPrincipal = true;
                    // este sería el control de eventos de tecla dentro del nivel
                    // haciendo que cuando se precione Esc se salga al menu

                    while (!salirAlMenuPrincipal) 
                    {
                        if (key.Key == ConsoleKey.UpArrow)
                        {
                            Jugador.Mover(Direccion.Arriba);
                        }
                        else if (key.Key == ConsoleKey.RightArrow)
                        {
                            Jugador.Mover(Direccion.Derecha);
                        }
                        else if (key.Key == ConsoleKey.DownArrow)
                        {
                            Jugador.Mover(Direccion.Abajo);
                        }
                        else if (key.Key == ConsoleKey.LeftArrow)
                        {
                            Jugador.Mover(Direccion.Izquierda);
                        }
                        else if (key.Key == ConsoleKey.Escape)
                        {
                            salirAlMenuPrincipal = true;
                            // Renderizar Menu Principal
                        }
                    }
                     
                    
                }
            }
        }
    }
}
