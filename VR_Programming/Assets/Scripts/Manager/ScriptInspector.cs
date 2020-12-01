using System.Collections;
using System.Collections.Generic;

public class ScriptInspector
{
    List<LineInspector> lineList;
    int curLineIdx;

    public ScriptInspector(List<LineInspector> lineList)
    {
        this.lineList = lineList;
        this.curLineIdx = 0;
    }
    public bool Check(Action action)
    {
        return lineList[curLineIdx].Check(action);
    }
    public void Next()
    {
        LineInspector lineInspector = lineList[curLineIdx];
        lineInspector.Next();
        if (lineInspector.IsFinished())
        {
            lineInspector.Init();   // set idx to 0
            curLineIdx++;
        }
    }
    public bool IsFinished()
    {
        if(lineList.Count == curLineIdx)
        {
            return true;
        }
        return false;
    }
}
