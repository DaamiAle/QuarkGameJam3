using QuarkGameJam3.src.Domain.Entities;
using QuarkGameJam3.src.Manager;
using QuarkGameJam3.src.Presenter.Menu;
using QuarkGameJam3.src.Utilities;
using static QuarkGameJam3.src.Utilities.Enum;

namespace QuarkGameJam3.src.Presenter
{
    public class Presenter
    {
        #region Properties and fields
        private readonly IViewMenu _view;
        private MenuModel _model;
        public List<MenuOption> MenuOptions => _model.State.MenuOptions;
        public MenuOption SelectedOption => _model.State.SelectedOption;

        public Presenter(IViewMenu view)
        {
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
                    StartGame();
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

        private void StartGame()
        {
            Console.Clear();
            Board board = new Board(30, 30);
            int wallSize = 50;
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;
            int wallLeft = (consoleWidth - wallSize) / 2;
            int wallTop = (consoleHeight - wallSize) / 2;

            for (int i = wallTop; i < wallTop + wallSize; i++)
            {
                for (int j = wallLeft; j < wallLeft + wallSize; j++)
                {
                    if (i == wallTop || j == wallLeft || i == wallTop + wallSize - 1 || j == wallLeft + wallSize - 1)
                    {
                        if (i >= 0 && i < board.rows && j >= 0 && j < board.columns)
                        {
                            if (board.Insidethedashboard(new Coordinates(wallTop, wallLeft)))
                            {
                                Wall wall = new Wall(new Coordinates(i, j), board);
                                board.AddGameObject(wall);
                            }
                        
                        }
                    }
                }
            }


            board.Draw();

            QuarkGameJam3.src.Domain.Entities.Player Player = new QuarkGameJam3.src.Domain.Entities.Player(new Coordinates(5, 5) , board);

            Engine.ShowGameObjectOnScreen(Player);
  
            Box caja1 = new Box(new Coordinates(10, 10), board);
            Box caja2 = new Box(new Coordinates(20, 15), board);

            Engine.ShowGameObjectOnScreen(caja1);
            Engine.ShowGameObjectOnScreen(caja2);

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Player.Move(Direction.Up);
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    Player.Move(Direction.Right);
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Player.Move(Direction.Down);
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    Player.Move(Direction.Left);
                }
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
