using UnityEngine;
using UnityEngine.UI;

public class PanelColorChanger : ColorChanger
{
    [SerializeField] protected Image m_Image;
    [SerializeField] protected TMPro.TextMeshProUGUI m_Text;

    protected override void InitComponents()
    {
        metode = GameData.Metode;
        if (m_Image == null) m_Image =  GetComponentInChildren<Image>();
        if (m_Text == null ) m_Text = GetComponentInChildren<TMPro.TextMeshProUGUI>();
        accents = Accents();
    }
}