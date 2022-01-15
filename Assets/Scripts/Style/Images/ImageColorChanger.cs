using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImageColorChanger : ColorChanger
{
    [SerializeField] Image image;
    protected override void InitComponents()
    {
        metode = GameData.Metode;
        if(image==null) image = GetComponent<Image>();
        accents = Accents();
    }
}