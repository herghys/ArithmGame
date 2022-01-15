using UnityEngine;
using DG.Tweening;
using Manager;
using System.Collections;

public class ContextTitleChanger : MonoBehaviour
{
    [SerializeField] string titleOnEnable;
    [SerializeField] string titleOnDisable;

    public UpdateGameObjectState UpdateUI;

    public static ContextTitleChanger Instance;
    private void OnEnable() => UpdateUI += UIChanged;
    private void OnDisable() => UpdateUI -= UIChanged;

    private void Awake()
    {
        Instance = this;
    }
    void MoveIn()
    {
        UIManagers.Instance.UpdateTitle?.Invoke(titleOnEnable);
        StartCoroutine(StartTween(0));
    }

    void MoveOut()
    {
        StartCoroutine(StartTween(2100));
        UIManagers.Instance?.UpdateTitle?.Invoke(titleOnDisable);
    }

    void UIChanged(bool state)
    {
        if (state) MoveIn();
        else MoveOut();
    }

    IEnumerator StartTween(float posX)
    {
        transform.DOLocalMoveX(posX, 0.5f);
        yield return new WaitForSeconds(0.15f);
    }
}