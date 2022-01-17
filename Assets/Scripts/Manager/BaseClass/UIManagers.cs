using UnityEngine;
using TMPro;

namespace Manager
{
    public class UIManagers : MonoBehaviour
    {
        #region Variables
        [Header("Base Variables")]
        public TextMeshProUGUI txt_Title;
        #endregion

        #region Event Subscriber
        public UpdateString UpdateTitle;
        #endregion

        #region Instance
        public static UIManagers Instance;
        #endregion

        #region Unity Default
        protected virtual void Awake()
        {
            Instance = this;
        }
        #endregion

        #region Functions
        protected virtual void SetTitle(string text)
        {
            txt_Title.text = text;
        }
        #endregion
    }
}