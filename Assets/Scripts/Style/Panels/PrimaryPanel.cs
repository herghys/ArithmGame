public class PrimaryPanel : PanelColorChanger
{
    protected override void ColorChange()
    {
        m_Image.color = accents.primary;
        m_Text.color = accents.fontPrimary;
    }
}
