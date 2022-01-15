using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    static GameData() { }

    static MetodeBelajar metode;
    static MateriData materi;

    //static string metode;
    #region Get-Setter
    public static MetodeBelajar Metode { get => metode; set => metode = value; }
    public static MateriData Materi { get => materi; set => materi = value; }
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

public delegate void UpdateGameObjectState(GameObject @object);
public delegate void UpdateString(string text);