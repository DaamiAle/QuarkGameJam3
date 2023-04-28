
using QuarkGameJam3.src.objects;
using QuarkGameJam3.src.scenes;

namespace QuarkGameJam3.src.core
{
    public interface IRenderer
    {
        public void Render(GameObject gameObject);
        public void Hide(GameObject gameObject);
        public void Render(BaseScene scene);
        public void Hide(BaseScene scene);
    }
}
