using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace Manager
{
    public class UIManagers : MonoBehaviour
    {
        [Header("Reference")]
        public Managers manager;

        [Header("Color Lists")]
        public List<ColorAccents> accents = new List<ColorAccents>();

        public static UIManagers instance;

        private void Awake()
        {
            if (instance == null) instance = this;
        }

        private void Start()
        {
            if (manager == null) manager = GetComponent<Managers>();
        }

        public static ColorAccents SetAccent(MetodeBelajar metode)
        {
            ColorAccents _accent = ScriptableObject.CreateInstance<ColorAccents>();
            switch (metode)
            {
                case MetodeBelajar.SENSING:
                    _accent = instance.accents[0];
                    break;
                case MetodeBelajar.THINKING:
                    _accent = instance.accents[1];
                    break;
                case MetodeBelajar.INTUITING:
                    _accent = instance.accents[2];
                    break;
                case MetodeBelajar.FEELING:
                    _accent = instance.accents[3];
                    break;
                case MetodeBelajar.INSTING:
                    _accent = instance.accents[4];
                    break;
            }

            return _accent;
        }
    }
}