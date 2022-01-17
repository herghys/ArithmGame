using System.Collections.Generic;

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