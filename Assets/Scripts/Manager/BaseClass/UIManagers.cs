using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    public class UIManagers : MonoBehaviour
    {
        [Header("Reference")]
        public Managers manager;

        /*//[Header("Color Lists")]
        //public List<ColorAccents> accents = new List<ColorAccents>();

        //public static UIManagers instance;

        private void Awake()
        {
            //if (instance == null) instance = this;
        }*/

        private void Start()
        {
            if (manager == null) manager = GetComponent<Managers>();
        }
    }
}