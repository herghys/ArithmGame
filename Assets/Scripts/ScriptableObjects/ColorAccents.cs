using UnityEngine;

[CreateAssetMenu(fileName = "New_Accent", menuName = "Color Accent")]
public class ColorAccents : ScriptableObject
{
    [Header("Name")]
    public string accentName;

    [Header("Main Color Accent")]
    public Color primary;
    public Color secondary;
    public Color accent_1;
    public Color fontPrimary;
    public Color fontSecondary;
    public Color fontAccent_1;

    [Header("Button Accent")]
    public Color buttonHighlighted;
    public Color buttonPressed;
    public Color buttonSelected;
    public Color buttonInactive;
}