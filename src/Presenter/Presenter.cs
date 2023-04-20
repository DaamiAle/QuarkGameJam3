

using QuarkGameJam3.src.Presenter.Menu;
using QuarkGameJam3.src.Utilities;
using static QuarkGameJam3.src.Utilities.Enum;

namespace QuarkGameJam3.src.Presenter
{
    public class Presenter
    {
        #region Properties and fields
        //private readonly Player _player;
        private readonly IViewMenu _view;
        private MenuModel _model;
        public List<MenuOption> MenuOptions => _model.State.MenuOptions;
        public MenuOption SelectedOption => _model.State.SelectedOption;

        public Presenter(IViewMenu view)
        {
            //_player = new Player();
            _view = view;
            _model = new MenuModel();
        }
        #endregion

        #region Methods
        public void ExecuteSelectedMenuOption()
        {
            switch (_model.State.SelectedOption)
            {
                case MenuOption.StartGame:
                    // Code to start the game
                    break;
                case MenuOption.LevelList:
                    // Code to display the list of levels
                    break;
                case MenuOption.Exit:
                    _view.Close();
                    break;
                default:
                    _view.ShowText(Message.ErrorMessage);
                    break;
            }
        }

        public int GetSelectedOptionIndex()
        {
            return MenuOptions.IndexOf(SelectedOption);
        }
        public void MoveSelectionUp()
        {
            int selectedIndex = GetSelectedOptionIndex();
            int count = MenuOptions.Count;

            _model.State.SelectedOption = (selectedIndex == 0) ? _model.State.SelectedOption = MenuOptions[count - 1] : _model.State.SelectedOption = MenuOptions[selectedIndex - 1];
            _view.ShowMenuOptions(MenuOptions, SelectedOption);
        }
        public void MoveSelectionDown()
        {
            int selectedIndex = GetSelectedOptionIndex();
            int count = MenuOptions.Count;

            _model.State.SelectedOption = (selectedIndex == count - 1) ? _model.State.SelectedOption = MenuOptions[0] : _model.State.SelectedOption = MenuOptions[selectedIndex + 1];
            _view.ShowMenuOptions(MenuOptions, SelectedOption);
        }


        #endregion

    }
}
