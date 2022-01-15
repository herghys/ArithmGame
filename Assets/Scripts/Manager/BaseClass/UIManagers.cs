using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Manager
{
    public class UIManagers : MonoBehaviour
    {
        #region Events
        public UpdateGameObjectState UpdateUI;
        public UpdateString UpdateTitle;
        #endregion

        #region Variables
        public TextMeshProUGUI txt_Title;
        #endregion

        public static UIManagers Instance;

        protected virtual void Awake()
        {
            Instance = this;
        }

        protected virtual void UIUpdated(GameObject @object)
        {
            @object.SetActive(!@object.activeSelf);
        }

        protected virtual void SetTitle(string text)
        {
            txt_Title.text = text;
        }
    }
}