using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] protected MetodeBelajar metode;

     void Awake()
    {
        InitComponents();
        ColorChange();
    }

    protected virtual void InitComponents() { }

    protected virtual void ColorChange() { }

    protected virtual ColorAccents Accents()
    {
        return HelperScript.Accents(metode);
    }
}