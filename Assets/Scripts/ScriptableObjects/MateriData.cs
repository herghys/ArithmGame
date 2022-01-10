using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMateriData", menuName = "Menu Materi Data")]
public class MateriData : ScriptableObject
{
    #region Variables
    [SerializeField] string metode;
    [SerializeField] GameObject materiPrefab;
    [SerializeField] Sprite backgrounSprite;
    [SerializeField] ColorAccents accent;
    #endregion

    #region Get-Setter
    public string Metode { get => metode; set => metode = value; }
    public GameObject MateriPrefab { get => materiPrefab; set => materiPrefab = value; }
    public Sprite BackgrounSprite { get => backgrounSprite; set => backgrounSprite = value; }
    public ColorAccents Accent { get => accent; set => accent = value; }
    #endregion
}
