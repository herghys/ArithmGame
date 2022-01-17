using UnityEngine;
using System.Collections.Generic;

namespace Manager
{
    public class MenuMateriScript : Managers
    {
        [SerializeField] internal MetodeBelajar metode;
        [SerializeField] internal List<MateriData> materiData;

        protected override void Awake()
        {
            Instance = this;
            metode = GameData.Metode;
        }
    }
}