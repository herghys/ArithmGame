using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Manager;

public class ButtonColor : MonoBehaviour
{
    [SerializeField] MetodeBelajar metode;
    [SerializeField] Button button;
    [SerializeField] TextMeshProUGUI text;

    private void Start()
    {
        if (button == null) button = GetComponent<Button>();
        if (text == null) text = GetComponentInChildren<TextMeshProUGUI>();

        NewButtonColor();
    }

    private ColorBlock NewColorBlock(MetodeBelajar metode)
    {
        ColorBlock newColorBlock = button.colors;
        newColorBlock.normalColor = UIManagers.SetAccent(metode).primary;
        newColorBlock.highlightedColor = UIManagers.SetAccent(metode).accent_2;
        newColorBlock.pressedColor = UIManagers.SetAccent(metode).secondary;
        newColorBlock.selectedColor = UIManagers.SetAccent(metode).tertiary;
        newColorBlock.disabledColor = button.colors.disabledColor;

        return newColorBlock;
    }

    void NewButtonColor()
    {
        button.colors = NewColorBlock(metode);
        text.color = UIManagers.SetAccent(metode).fontPrimary;
    }
}
