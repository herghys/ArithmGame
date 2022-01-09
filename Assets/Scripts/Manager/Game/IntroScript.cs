using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    public class IntroScript : Managers
    {
        public List<ColorAccents> colorAccents;

        private void Start()
        {
            HelperScript.AccentList = colorAccents;
        }
    }
}