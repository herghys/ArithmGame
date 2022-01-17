using UnityEngine;
using DG.Tweening;

public class ContextSelection : MonoBehaviour
{
    #region Variables
    public int contextIndex;
    public string contextTitle;
    public bool b_toLeft;
    public bool b_isActive;
    public bool b_previousLeft;
    #endregion

    #region Components
    RectTransform rect;
    #endregion

    private void Awake()
    {
        if (rect == null) rect = GetComponent<RectTransform>();
    }

    public void MoveIn()
    {
        b_isActive = true;
        rect.DOAnchorPos(Vector2.zero, 0.5f);
    }

    public void MoveOut(float posx)
    {
        //b_toLeft = _left;
        b_isActive = false;
        if (b_toLeft && !b_previousLeft) MoveOutLeft(posx);
        MoveOutRight(posx);
    }

    private void MoveOutLeft(float posx)
    {
        b_toLeft = true;
        b_previousLeft = false;
        rect.DOAnchorPosX(-posx, 0.5f);
    }

    private void MoveOutRight(float posx)
    {
        b_toLeft = false;
        b_previousLeft = true;
        rect.DOAnchorPosX(posx, 0.5f);
    }
}
