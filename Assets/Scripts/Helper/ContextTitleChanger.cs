using UnityEngine;
using Manager;

public class ContextTitleChanger : MonoBehaviour
{
    [SerializeField] string titleOnEnable;
    [SerializeField] string titleOnDisable;

    private void OnEnable() => UIManagers.Instance.UpdateTitle?.Invoke(titleOnEnable);
    private void OnDisable() => UIManagers.Instance.UpdateTitle?.Invoke(titleOnDisable);
}