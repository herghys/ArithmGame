using UnityEngine;
namespace Manager
{
    public class MainMenuScript : Managers
    {
        [SerializeField] bool isContextActive = false;
        [SerializeField] int contextIndex = 0;
        public void GoToScene(int metode)
        {
            GameData.Metode = (MetodeBelajar)metode;
            base.GotoScene("MenuMateri");
        }

        public void InvokeUIChange()
        {
            if (contextIndex == 0) contextIndex = 1;
            else if (contextIndex > 0) contextIndex = 0;

            ContextManager.Instance.UpdateContext?.Invoke(contextIndex);
            /*isContextActive = !isContextActive;
            UIManagers.Instance.UpdateUI?.Invoke(isContextActive);*/
        }

        /*public void InvokeUIChange(GameObject @object)
        {
            UIManagers.Instance.UpdateUI?.Invoke(@object);
        }

        public void InvokeUIChange(RectTransform rect)
        {
            isContextActive = !isContextActive;
        }*/
    }
}