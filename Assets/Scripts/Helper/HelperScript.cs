using System.Collections.Generic;
using UnityEngine;

public class HelperScript
{
    static HelperScript() { }

    #region Color Helper
    public static List<ColorAccents> AccentList { get; set; }

    public static ColorAccents Accents(MetodeBelajar metode)
    {
        ColorAccents _accent = ScriptableObject.CreateInstance<ColorAccents>();
        switch (metode)
        {
            case MetodeBelajar.SENSING:
                _accent = AccentList[0];
                break;
            case MetodeBelajar.THINKING:
                _accent = AccentList[1];
                break;
            case MetodeBelajar.INTUITING:
                _accent = AccentList[2];
                break;
            case MetodeBelajar.FEELING:
                _accent = AccentList[3];
                break;
            case MetodeBelajar.INSTING:
                _accent = AccentList[4];
                break;
        }

        return _accent;
    }
    #endregion
}