using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Manager;
using System;

public class ContextManager : MonoBehaviour
{
    public List<ContextSelection> contextLists;
    public static ContextManager Instance;

    public int currentIndex = 0;

    public UpdateContextUI UpdateContext;

    private void OnEnable()
    {
        UpdateContext += ContextUpdated;
    }

    private void OnDisable()
    {
        UpdateContext -= ContextUpdated;
    }

    private void Awake()
    {
        Instance = this;
    }

    private void ContextUpdated(int index)
    {
        GetSelectedContext(index);
    }

    protected void GetSelectedContext(int index)
    {
        foreach (var item in contextLists)
        {
            if (item.contextIndex < index)
            {
                item.MoveOut(-2000, true);
            }
            else if(item.contextIndex > index)
            {
                item.MoveOut(2000, false);
            }
            else if (item.contextIndex == index)
            {
                item.MoveIn();
            }
        }
        UIManagers.Instance.UpdateTitle?.Invoke(contextLists[index].contextTitle);
    }
}
