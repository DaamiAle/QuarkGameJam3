
namespace QuarkGameJam3.src
{
    public abstract class Jugador
    {
        /// <summary>
        /// Atributo que representa la entidad del jugador.
        /// </summary>
        private static Movible entidad;
        /// <summary>
        /// Inicializa al jugador
        /// </summary>
        /// <param name="posicionInicial">Coordenadas donde va a iniciar el jugador</param>
        public static void Inicializar(Coordenadas posicionInicial)
        {
            entidad = new Movible(posicionInicial, "@");
            Engine.Mostrar(entidad);
        }
        /// <summary>
        /// Mueve al jugar segun la direccion deseada.
        /// </summary>
        /// <param name="direccion">Direccion en la que se va a mover el jugador</param>
        public static void Mover(Direccion direccion)
        {
            // Acá va una verificacion de si en la direccion que se quiere mover hay una caja

            entidad.Mover(direccion);
        }
    }
}