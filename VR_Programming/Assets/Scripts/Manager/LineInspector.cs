using System.Collections;
using System.Collections.Generic;
public class LineInspector
{
    List<Action> actionList = new List<Action>();
    int curActionIdx = 0;

    public LineInspector(List<Action> actionList)
    {
        this.actionList = actionList;
    }
    public LineInspector(string line)
    {
        SetLine(line);
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

    public Action CurAction
    {
        get
        {
            if (IsFinished())
            {
                return null;
            }
            return actionList[curActionIdx];
        }
    }
    public void AddAction(Action action)
    {
        actionList.Add(action);
    }

    public void SetLine(string line)
    {
        string[] actions = line.Split('\t');
        foreach(string action in actions)
        {
            AddAction(new Action(action));
        }
    }
}
