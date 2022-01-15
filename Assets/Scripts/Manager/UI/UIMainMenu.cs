using UnityEngine;

namespace Manager
{
    public class UIMainMenu : UIManagers
    {
        private void OnEnable()
        {
            UpdateUI += UIUpdated;
            UpdateTitle += SetTitle;
        }

        private void OnDisable()
        {
            UpdateUI -= UIUpdated;
            UpdateTitle -= SetTitle;
        }

        private void Start()
        {
            UpdateTitle.Invoke("Menu");
        }
    }
}