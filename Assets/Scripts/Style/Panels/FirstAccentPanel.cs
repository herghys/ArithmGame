public class FirstAccentPanel : PanelColorChanger
{
    protected override void ColorChange()
    {
        m_Image.color = accents.accent_1;
        if(m_Text != null) m_Text.color = accents.fontAccent_1;
    }
}
