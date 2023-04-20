

using static QuarkGameJam3.src.Utilities.Enum;

namespace QuarkGameJam3.src.Presenter.Menu
{
    public class MenuState
    {
        #region Properties and fields
        public List<MenuOption> MenuOptions { get; set; }
        public MenuOption SelectedOption { get; set; }

        public MenuState()
        {
            MenuOptions = new List<MenuOption>() { 
                    MenuOption.StartGame, 
                    MenuOption.LevelList,
                    MenuOption.Exit
            };
            SelectedOption = MenuOption.StartGame;
        }
        #endregion
    }
}
