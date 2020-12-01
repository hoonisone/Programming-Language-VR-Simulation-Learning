using System.Collections;
using System.Collections.Generic;
public class LineInspector
{
    List<Action> actionList;
    int curActionIdx;

    public LineInspector(List<Action> actionList)
    {
        this.actionList = actionList;
        this.curActionIdx = 0;
    }


    public bool Check(Action action)
    {
        if (actionList[curActionIdx].Compare(action))
        {
            return true;
        }
        return false;
    }

    public bool IsFinished()
    {
        if(actionList.Count == curActionIdx)
        {
            return true;
        }
        return false;
    }

    public void Next()
    {
        curActionIdx++;
    }

    public void Init()
    {
        curActionIdx = 0;
    }
}
