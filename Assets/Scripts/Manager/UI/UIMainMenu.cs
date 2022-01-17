using UnityEngine;

namespace Manager
{
    public class UIMainMenu : UIManagers
    {
        private void OnEnable()
        {
            UpdateTitle += SetTitle;
        }

        private void OnDisable()
        {
            UpdateTitle -= SetTitle;
        }

        private void Start()
        {
            UpdateTitle.Invoke("Menu");
        }
    }
}