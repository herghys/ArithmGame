namespace Manager
{
    public class MainMenuScript : Managers
    {
        public void GoToScene(int metode)
        {
            GameData.Metode = (MetodeBelajar)metode;
            base.GotoScene("MenuMateri");
        }
    }
}