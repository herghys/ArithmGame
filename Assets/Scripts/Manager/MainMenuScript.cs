using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    public class MainMenuScript : Managers
    {
        public override void GotoScene(string scene)
        {
            GameData.Metode = "Menu" + scene;
            base.GotoScene("MenuMateri");
        }
    }
}
