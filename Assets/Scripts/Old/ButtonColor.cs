using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonColor : MonoBehaviour
{
    [SerializeField] protected MetodeBelajar metode;
    [SerializeField] Button button;
    [SerializeField] TextMeshProUGUI text;

    private void Start()
    {
        InitComponent();
        NewButtonColor();
    }

    protected virtual void InitComponent()
    {
        if (button == null) button = GetComponent<Button>();
        if (text == null) text = GetComponentInChildren<TextMeshProUGUI>();
    }

    private ColorAccents NewAccents()
    {
        return HelperScript.Accents(metode);
    }

    private ColorBlock NewColorBlock()
    {
        ColorBlock newColorBlock = button.colors;

        newColorBlock.normalColor = NewAccents().primary;
        newColorBlock.highlightedColor = NewAccents().buttonHighlighted;
        newColorBlock.pressedColor = NewAccents().buttonPressed;
        newColorBlock.selectedColor = NewAccents().buttonSelected;
        newColorBlock.disabledColor = NewAccents().buttonInactive;

        return newColorBlock;
    }

    void NewButtonColor()
    {
        button.colors = NewColorBlock();
        text.color = NewAccents().fontPrimary;
    }
}
