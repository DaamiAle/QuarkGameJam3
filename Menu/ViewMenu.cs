using QuarkGameJam3_Presenter;
using static QuarkGameJam3_Utilities.Enum;
using QuarkGameJam3_Presenter.Menu;

namespace QuarkGameJam3.Menu
{
    public class ViewMenu : IViewMenu
    {
        private readonly Presenter _menuPresenter;

        public ViewMenu()
        {
            _menuPresenter = new Presenter(this);
            ShowMainMenu();
        }

        public void ShowMainMenu()
        {

            ClearScreen();
            ShowMenuOptions(_menuPresenter.MenuOptions, _menuPresenter.SelectedOption);
            while (true)
            {
                var key = GetKeyPress();
                HandleKeyPress(key);
            }
        }

        #region Methods private

        private void ClearScreen()
        {
            Console.Clear();
        }
        private ConsoleKeyInfo GetKeyPress()
        {
            return Console.ReadKey(true);
        }

        private void HandleKeyPress(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    _menuPresenter.MoveSelectionUp();
                    break;
                case ConsoleKey.DownArrow:
                    _menuPresenter.MoveSelectionDown();
                    break;
                case ConsoleKey.Enter:
                    _menuPresenter.ExecuteSelectedMenuOption();
                    break;
            }
        }

        #endregion

        #region Methods implements IView
        public void ShowText(string text)
        {
            Console.Write(text);
        }
        public void ShowMenuOptions(List<MenuOption> menuOptions, MenuOption selectedOption)
        {
            Console.Clear();
            int maxWidth = 0;
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;
            int titleHeight = MenuTitle.TitleElements.Length;
            int menuHeight = menuOptions.Count;
            int totalHeight = titleHeight + menuHeight + 1;
            int top = (consoleHeight - totalHeight) / 2;

            foreach (string line in MenuTitle.TitleElements)
            {
                CenterText(line, top++);
            }

            top++;
            for (int i = 0; i < menuOptions.Count; i++)
            {
                string prefix = i == menuOptions.IndexOf(selectedOption) ? ">" : "  ";
                string[] lines = MenuLabels.GetLabel(menuOptions[i]).Split('\n');
                int menuLeft = consoleWidth / 2 - maxWidth / 2;
                for (int j = 0; j < lines.Length; j++)
                {
                    Console.SetCursorPosition(menuLeft, top + i * lines.Length + j);
                    Console.BackgroundColor = i == menuOptions.IndexOf(selectedOption) ? ConsoleColor.DarkBlue : ConsoleColor.Black;
                    Console.ForegroundColor = i == menuOptions.IndexOf(selectedOption) ? ConsoleColor.White : ConsoleColor.Gray;
                    Console.Write(prefix + " ");
                    Console.Write(lines[j].PadRight(maxWidth));
                }
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }


        public static void CenterText(string text, int top)
        {
            int left = Console.WindowWidth / 2 - text.Length / 2;
            Console.SetCursorPosition(left, top);
            Console.WriteLine(text);
        }

        public void Close()
        {
            Environment.Exit(0);
        }

        #endregion


    }
}
