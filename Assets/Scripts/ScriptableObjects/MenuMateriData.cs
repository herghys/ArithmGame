using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMateriData", menuName = "Menu Materi Data")]
public class MenuMateriData : ScriptableObject
{
    #region Variables
    [SerializeField] string metode;
    #endregion

    #region Get-Setter
    public string Metode { get => metode; set => metode = value; }
    #endregion
}
