using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New_Accent", menuName = "Color Accent")]
public class ColorAccents : ScriptableObject
{
    [Header("Main Color")]
    public Color primary;
    public Color secondary;
    public Color tertiary;
    public Color accent_1;
    public Color accent_2;
    public Color accent_3;
    public Color disabled;

    [Header("Font Color")]
    public Color fontPrimary;
    public Color fontSecondary;
    public Color fontTertiary;
    public Color fontAccent_1;
    public Color fontAccent_2;
    public Color fontAccent_3;
}
