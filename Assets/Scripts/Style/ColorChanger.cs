using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] protected MetodeBelajar metode;
    [SerializeField] protected ColorAccents accents;

     void Awake()
    {
        InitComponents();
        ColorChange();
    }
    protected virtual void InitComponents() { }

    protected virtual void ColorChange() { }

    protected virtual ColorAccents Accents()
    {
        return accents = HelperScript.Accents(metode);
    }
};