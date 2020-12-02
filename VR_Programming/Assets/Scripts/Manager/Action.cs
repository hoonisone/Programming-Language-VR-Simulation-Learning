using System;

public class Action
{
    Performer performer;
    ObjectType objectType;
    MotionType motionType;
    string name;
    int jumpSize = 0;
    string message;

    public Action(ObjectType objectType, MotionType motionType)
    {
        this.ObjectType = objectType;
        this.MotionType = motionType;
    }
    public Action(ObjectType objectType, MotionType motionType, string name) : this(objectType, motionType)
    {
        Name = name;
    }

    public Action(Performer performer, ObjectType objectType, MotionType motionType, string name) : this(objectType, motionType, name)
    {
        this.performer = performer;
    }

    public Action(string action)
    {
        SetAction(action);
    }
    public bool Compare(Action action)
    {
        if( ObjectType.Equals(action.ObjectType) && MotionType.Equals(action.MotionType) && Name.Equals(action.Name))
            return true;
        return false;
    }
    public ObjectType ObjectType { get => objectType; set => objectType = value; }
    public MotionType MotionType { get => motionType; set => motionType = value; }
    public string Name { get => name; set => name = value; }
    public int JumpSize { get => jumpSize; set => jumpSize = value; }
    public Performer Performer { get => performer; set => performer = value; }
    public string Message { get => message; set => message = value; }

    public void SetAction(string action)
    {
        string[] elements = action.Split(' ');
        Performer = ToPerformer(elements[0]);
        MotionType = ToMotionType(elements[1]);
        ObjectType = ToObjectType(elements[2]);
        name = elements[3];
        if (ObjectType.Equals(ObjectType.Control))
            JumpSize = Int32.Parse(elements[4]);
    }
    public MotionType ToMotionType(string motionType)
    {
        switch (motionType)
        {
            case "read":
                return MotionType.Read;
            case "write":
                return MotionType.Write;
            case "execute":
                return MotionType.Execute;
            case "jump":
                return MotionType.Jump;
            default:
                return MotionType.Read;
        }
    }
    public ObjectType ToObjectType(string objectType)
    {
        switch (objectType)
        {
            case "parameter":
                return ObjectType.Parameter;
            case "operator":
                return ObjectType.Operator;
            case "result":
                return ObjectType.Result;
            case "variable":
                return ObjectType.Variable;
            case "constant":
                return ObjectType.Constant;
            case "condition":
                return ObjectType.Condition;
            case "input":
                return ObjectType.Input;
            case "output":
                return ObjectType.Output;
            case "inputLever":
                return ObjectType.InputLever;
            case "outputLever":
                return ObjectType.OutputLever;
            case "control":
                return ObjectType.Control;
            default:
                return ObjectType.Parameter;
        }
    }
    public Performer ToPerformer(string performer)
    {
        switch (performer)
        {
            case "user":
                return Performer.User;
            case "auto":
                return Performer.Auto;
            default:
                return Performer.User;
        }
    }

    public string State { get => performer.ToString() + " " + motionType.ToString() + " " + ObjectType.ToString() + " " + name; }
}
