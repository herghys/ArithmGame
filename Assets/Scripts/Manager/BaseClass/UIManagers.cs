using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    public class UIManagers : MonoBehaviour
    {
        [Header("Reference")]
        public Managers manager;

        private void Start()
        {
            if (manager == null) manager = GetComponent<Managers>();
        }

        public void SetActive(GameObject gameObject)
        {
            if(gameObject.activeSelf) gameObject.SetActive(false);
            else gameObject.SetActive(true);    
        }
    }
}