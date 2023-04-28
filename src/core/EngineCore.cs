using QuarkGameJam3.src.objects;
using QuarkGameJam3.src.scenes;
using QuarkGameJam3.src.utilities;

namespace QuarkGameJam3.src.core
{
    public class EngineCore : IRenderer, IBehabour
    {
        #region Singleton Structure
        private static EngineCore engine;
        private EngineCore() { }
        public static EngineCore Instance() => engine ??= new();
        #endregion
        private IRenderer renderer = RendererEngine.Instance();
        private IBehabour behabour = BehabourEngine.Instance();

        public void Move(GameObject gameObject, Direction direction) => behabour.Move(gameObject, direction);

        public void Render(GameObject gameObject) => renderer.Render(gameObject);

        public void Hide(GameObject gameObject) => renderer.Hide(gameObject);

        public void Render(BaseScene scene) => renderer.Render(scene);

        public void Hide(BaseScene scene) => renderer.Hide(scene);
        
    }
}