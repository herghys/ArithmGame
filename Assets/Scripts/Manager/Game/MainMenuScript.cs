using UnityEngine;
namespace Manager
{
    public class MainMenuScript : Managers
    {
        [SerializeField] int contextIndex = 0;
        public void GoToScene(int metode)
        {
            GameData.Metode = (MetodeBelajar)metode;
            base.GotoScene("MenuMateri");
        }

        public void InvokeContextChange()
        {
            if (contextIndex == 0) contextIndex = 1;
            else if (contextIndex > 0) contextIndex = 0;

            ContextManager.Instance.UpdateContext?.Invoke(contextIndex);
        }
    }
}