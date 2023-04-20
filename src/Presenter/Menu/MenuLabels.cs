

using static QuarkGameJam3.src.Utilities.Enum;

namespace QuarkGameJam3.src.Presenter.Menu
{
    public static class MenuLabels
    {
        #region Methods 

        private static readonly Dictionary<MenuOption, string> Labels = new Dictionary<MenuOption, string>
        {
            { MenuOption.StartGame, "Start game" },
            { MenuOption.LevelList, "Levels" },
            { MenuOption.Exit, "Exit" },
        };

        public static string GetLabel(MenuOption optionType)
        {
            if (Labels.TryGetValue(optionType, out string label))
            {
                return label;
            }
            return optionType.ToString(); 
        }
        #endregion

    }
}
