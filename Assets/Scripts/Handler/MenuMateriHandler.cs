using UnityEngine;
using TMPro;
using Manager;

public class MenuMateriHandler : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public ContextManager contextManager;
    public int selectedIndex;

    [SerializeField] MenuMateriScript manager;
    public void InvokeContextChange()
    {
        if (selectedIndex == 0) selectedIndex = 1;
        else if (selectedIndex > 0) selectedIndex = 0;

        ContextManager.Instance.UpdateContext?.Invoke(selectedIndex);
        titleText.text = contextManager.contextLists[selectedIndex].contextTitle;
    }

    public void InvokeSceneChange(string scene)
    {
        manager.GotoScene(scene);
    }
    private void Awake()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<MenuMateriScript>();
    }
}
