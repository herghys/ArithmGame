using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonColorChanger : ColorChanger
{
    [SerializeField] Button button;
    [SerializeField] TextMeshProUGUI text;
    protected override void InitComponents()
    {
        if (button == null) button = GetComponent<Button>();
        if (text == null) text = GetComponentInChildren<TextMeshProUGUI>();
    }

    protected virtual ColorBlock NewColorBlock()
    {
        ColorBlock newBlock = button.colors;
        newBlock.normalColor = Accents().primary;
        newBlock.highlightedColor = Accents().accent_2;
        newBlock.pressedColor = Accents().secondary;
        newBlock.selectedColor = Accents().tertiary;

        return newBlock;
    }

    protected override void ColorChange()
    {
        button.colors = NewColorBlock();
        text.color = Accents().fontPrimary;
    }
}