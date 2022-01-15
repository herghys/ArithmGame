using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RawImageColorChanger : ColorChanger
{
    [SerializeField] protected RawImage image;
    protected override void InitComponents()
    {
        metode = GameData.Metode;
        if(image==null) image = GetComponent<RawImage>();

        accents = Accents();
    }
}