
namespace QuarkGameJam3.src
{
    public enum Direccion { Arriba = 0, Derecha, Abajo, Izquierda }
    public class Coordenadas
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Coordenadas(int x, int y) { X = x; Y = y; }
    }
    public static class Utilidades
    {
        public static bool Between(int valor, int inicio, int final)
        {
            return inicio <= valor && valor <= final;
        }
    }
}