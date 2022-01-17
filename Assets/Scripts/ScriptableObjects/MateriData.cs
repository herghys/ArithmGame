using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMateriData", menuName = "Menu Materi Data")]
public class MateriData : ScriptableObject
{
    #region Variables
    [SerializeField] MetodeBelajar metode;
    public MetodeBelajar Metode { get { return metode; } }

    [SerializeField] GameObject materiPrefab;
    public GameObject MaterialiPrefab { get { return materiPrefab; } }

    [SerializeField] GameObject menuMateriPrefab;
    public GameObject MenuMateriPrefab { get { return menuMateriPrefab; } }

    [SerializeField] Sprite backgroundSprite;
    public Sprite BackgroundSprite { get { return backgroundSprite; } }

    [SerializeField] ColorAccents accent;
    public ColorAccents Accent { get { return accent; } }
    #endregion
}
