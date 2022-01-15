using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    public class MenuMateriScript : Managers
    {
        [SerializeField] bool isContextActive = false;
        public void InvokeUIChange(GameObject @object)
        {
            isContextActive = !isContextActive;
            UIManagers.Instance.UpdateUI?.Invoke(isContextActive);
        }
    }
}