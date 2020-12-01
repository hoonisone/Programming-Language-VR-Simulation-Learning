public class Action
{
    ActionType actionType;
    string name;

    public Action(ActionType actionType, string name)
    {
        this.ActionType = actionType;
        this.Name = name;
    }
    
    public bool Compare(Action action)
    {
        if (ActionType.Compare(action.ActionType))
        {
            if (Name.Equals(action.Name))
            {
                return true;
            }
        }
        return false;
    }

    public bool CompareType(Action action)
    {
        if (ActionType.Compare(action.ActionType))
        {
            return true;
        }
        return false;
    }

    public ActionType ActionType { get => actionType; set => actionType = value; }
    public string Name { get => name; set => name = value; }
}
