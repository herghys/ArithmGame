using UnityEngine;
using UnityEngine.UI;

public class PanelColorChanger : ColorChanger
{
    [SerializeField] Image image;

    protected override void InitComponents()
    {
        metode = GameData.Metode;
        if (image == null) image = GetComponent<Image>();
    }

    protected override void ColorChange()
    {
        image.color = Accents().secondary;
    }
}