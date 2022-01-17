using System.Collections.Generic;
using UnityEngine;
using Manager;

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
        currentIndex = index;
        GetSelectedContext(index);
    }

    protected void GetSelectedContext(int index)
    {
        contextLists[index].MoveIn();
        foreach (var item in contextLists)
        {
            if (item.contextIndex < index)
            {
                item.MoveOut(-2000);
            }
            else if(item.contextIndex > index)
            {
                item.MoveOut(2000);
            }
        }
        UIManagers.Instance.UpdateTitle?.Invoke(contextLists[index].contextTitle);
    }

    public void NextIndex()
    {
        int index = currentIndex;
        if (!(currentIndex > 0))
        {
            index++;
        }
        ContextUpdated(index);
    }
    public void PreviousIndex()
    {
        int index = currentIndex;
        if(!(currentIndex < 0))
        {
            index--; 
        }
        ContextUpdated(index);
    }
}