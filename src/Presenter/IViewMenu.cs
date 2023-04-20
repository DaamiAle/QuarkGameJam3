

using static QuarkGameJam3.src.Utilities.Enum;

namespace  QuarkGameJam3.src.Presenter
{
    public interface IViewMenu
    {
        void ShowMenuOptions(List<MenuOption> menuOptions, MenuOption selectedOption);
        void ShowText(string text);
        void Close();
    }
}
