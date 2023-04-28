using QuarkGameJam3.src.objects;
using QuarkGameJam3.src.scenes;
using QuarkGameJam3.src.utilities;

namespace QuarkGameJam3.src.core
{
    public class RendererEngine : IRenderer
    {
        #region Singleton Structure
        private static RendererEngine engine;
        private RendererEngine() { }
        public static RendererEngine Instance() => engine ??= new();
        #endregion
        public void Render(GameObject gameObject)
        {
            string reprGameObject = gameObject.Repr();
            Coordinates posGameObject = gameObject.Posicion();
            Console.SetCursorPosition(posGameObject.X, posGameObject.Y);
            Console.Write(reprGameObject + reprGameObject);
            Console.SetCursorPosition(posGameObject.X, posGameObject.Y + 1);
            Console.Write(reprGameObject + reprGameObject);
        }
        public void Hide(GameObject gameObject)
        {
            Coordinates posGameObject = gameObject.Posicion();
            Console.SetCursorPosition(posGameObject.X, posGameObject.Y);
            Console.Write("  ");
            Console.SetCursorPosition(posGameObject.X, posGameObject.Y + 1);
            Console.Write("  ");
        }
        public void Render(BaseScene scene)
        {
            scene.GameObjects.ForEach(gameObject => Render(gameObject));
        }
        public void Hide(BaseScene scene)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
        }
    }
}
