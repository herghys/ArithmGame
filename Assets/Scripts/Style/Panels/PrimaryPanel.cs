public class PrimaryPanel : PanelColorChanger
{
    protected override void ColorChange()
    {
        m_Image.color = accents.primary;
        if (m_Text!=null) m_Text.color = accents.fontPrimary;
    }
}
