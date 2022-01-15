using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonColorChanger : ColorChanger
{
    [SerializeField] Button button;
    [SerializeField] TextMeshProUGUI text;
    protected override void InitComponents()
    {
        accents = Accents();
        if (button == null) button = GetComponent<Button>();
        if (text == null) text = GetComponentInChildren<TextMeshProUGUI>();
    }

    protected virtual ColorBlock NewColorBlock()
    {
        ColorBlock newBlock = button.colors;

        newBlock.normalColor = accents.primary;
        newBlock.highlightedColor = accents.buttonHighlighted;
        newBlock.pressedColor = accents.buttonPressed;
        newBlock.selectedColor = accents.buttonSelected;
        newBlock.disabledColor = accents.buttonInactive;

        return newBlock;
    }

    protected override void ColorChange()
    {
        button.colors = NewColorBlock();
        text.color = Accents().fontPrimary;
    }
}