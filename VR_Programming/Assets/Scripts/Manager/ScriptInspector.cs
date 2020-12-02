using System.Collections;
using System.Collections.Generic;

public class ScriptInspector
{
    List<LineInspector> lineList = new List<LineInspector>();
    int curLineIdx = 0;


    public ScriptInspector(string script)
    {
        setScript(script);
    }

    public ScriptInspector(List<LineInspector> lineList)
    {
        this.lineList = lineList;
        this.CurLineIdx = 0;
    }
    public bool Check(Action action)
    {
        return lineList[CurLineIdx].Check(action);
    }
    public void Next()
    {
        CurLineIdx++;
    }
    public void Execute(string message)
    {
        if (CurAction.Performer.Equals(Performer.Auto))
        {
            if(CurAction.ObjectType.Equals(ObjectType.Control) && CurAction.MotionType.Equals(MotionType.Jump))
            {
                if (message.Equals("true"))
                {
                    CurLineIdx = CurLineIdx + CurAction.JumpSize;
                    CurLineInspector.Init();
                }
                else
                {
                    CurLineInspector.Init();
                    CurLineIdx++;
                }
            }
        }
        else
        {
            LineInspector.Next();

            if (CurLineInspector.IsFinished())
            {
                CurLineInspector.Init();   // set idx to 0
                Next();
            }
        }
        return;
    }
    public void Jump(int size)
    {
        CurLineIdx += size;
    }

    public bool IsFinished()
    {
        if(lineList.Count <= CurLineIdx)
        {
            return true;
        }
        return false;
    }

    public LineInspector CurLineInspector
    {
        get
        {
            return lineList[CurLineIdx];
        }
    }

    public Action CurAction
    {
        get
        {
            return CurLineInspector.CurAction;
        }
    }

    public void setScript(string script)
    {
        string[] lines = script.Split('\n');
        foreach (string line in lines)
        {
            AddLine(new LineInspector(line));
        }
    }
    public void AddLine(LineInspector lineInspector)
    {
        lineList.Add(lineInspector);
    }

    public LineInspector LineInspector
    {
        get
        {
            return lineList[CurLineIdx];
        }
    }

    public int CurLineIdx { get => curLineIdx; set => curLineIdx = value; }
}
