namespace QuarkGameJam3.src.Presenter.Menu
{
    public class MenuModel
    {
        #region Properties and fields
        public MenuState State { get; set; }

        public MenuModel()
        {
            State = new MenuState();
        }
        #endregion
    }
}
