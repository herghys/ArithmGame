using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    public class MenuMateriScript : Managers
    {
        [SerializeField] int contextIndex = 0;
        public void InvokeContextChange()
        {
            if (contextIndex == 0) contextIndex = 1;
            else if (contextIndex > 0) contextIndex = 0;

            ContextManager.Instance.UpdateContext?.Invoke(contextIndex);
        }
    }
}