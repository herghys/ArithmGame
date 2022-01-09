using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{
    static MetodeBelajar metode;

    //static string metode;
    #region Get-Setter
    public static MetodeBelajar Metode { get => metode; set => metode = value; }
    //public static string Metode { get => metode; set => metode = value; }
    #endregion
}
public enum MetodeBelajar
{
    SENSING = 1,
    THINKING = 2,
    INTUITING = 3,
    FEELING = 4,
    INSTING = 5,
}