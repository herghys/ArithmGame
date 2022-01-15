using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ContextSelection : MonoBehaviour
{
    public int contextIndex;
    public string contextTitle;
    public bool toLeft;

    public void MoveIn()
    {
        transform.DOLocalMoveX(0, 0.5f);
    }

    public void MoveOut(float posx, bool _left)
    {
        toLeft = _left;

        if (toLeft) MoveOutLeft(posx);
        MoveOutRight(posx);
    }

    private void MoveOutLeft(float posx)
    {
        toLeft = true;
        transform.DOLocalMoveX(-posx, 0.5f);
    }

    private void MoveOutRight(float posx)
    {
        toLeft = false;
        transform.DOLocalMoveX(posx, 0.5f);
    }
}
