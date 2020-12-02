using System.Collections;
using System.Collections.Generic;

public class Evaluator
{
    List<EvaluationItem> items;

    public string getReportCard(ActionRecorder actionRecorder)
    {
        foreach(EvaluationItem item in items)
        {
            int count = 0;
            foreach(Action action in item.Actions)
            {
                count += actionRecorder.getCount(action);
            }
        }
        // 미완성
        return "score is null";
    }
    public Evaluator()
    {
        EvaluationItem evaluetionItem;
        evaluetionItem = new EvaluationItem();
        evaluetionItem.AddType(new Action(ObjectType.Variable, MotionType.Read));
        AddItem(evaluetionItem);
        evaluetionItem = new EvaluationItem();
        evaluetionItem.AddType(new Action(ObjectType.Operator, MotionType.Execute));
        AddItem(evaluetionItem);
    }

    void AddItem(EvaluationItem evlauetionItem)
    {
        this.items.Add(evlauetionItem);
    }
}

class EvaluationItem
{
    private string name;
    private List<Action> actions;

    public string Name { get => name; set => name = value; }
    public List<Action> Actions { get => actions; set => actions = value; }

    public void AddType(Action action)
    {
        actions.Add(action);
    }
}