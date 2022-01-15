public class SecondaryPanel : PanelColorChanger
{
    protected override void ColorChange()
    {
        m_Image.color = accents.secondary;
        if (m_Text != null) m_Text.color = accents.fontSecondary;
    }
}
