using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMateriData", menuName = "Menu Materi Data")]
public class MenuMateriData : ScriptableObject
{
    #region Variables
    [SerializeField] string metode;
    [SerializeField] GameObject materiPrefab;
    #endregion

    #region Get-Setter
    public string Metode { get => metode; set => metode = value; }
    public GameObject MateriPrefab { get => materiPrefab; set => materiPrefab = value; }
    #endregion
}
