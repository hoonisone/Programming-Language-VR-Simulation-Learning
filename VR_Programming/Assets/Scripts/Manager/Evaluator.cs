using System.Collections;
using System.Collections.Generic;

public class Evaluator
{
    List<EvaluationItem> items;

    public string getReportCard(ActionTypeRecorder actionTypeRecorder)
    {
        foreach(EvaluationItem item in items)
        {
            int count = 0;
            foreach(ActionType type in item.Types)
            {
                count += actionTypeRecorder.getCount(type);
            }
        }
        return "score is null";
    }
    public Evaluator()
    {
        EvaluationItem evaluetionItem;
        evaluetionItem = new EvaluationItem();
        evaluetionItem.AddType(new ActionType(ObjectType.Variable, MotionType.Read));
        AddItem(evaluetionItem);
        evaluetionItem = new EvaluationItem();
        evaluetionItem.AddType(new ActionType(ObjectType.Operator, MotionType.Execute));
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
    private List<ActionType> types;

    public string Name { get => name; set => name = value; }
    public List<ActionType> Types { get => types; set => types = value; }

    public void AddType(ActionType actionType)
    {
        Types.Add(actionType);
    }
}