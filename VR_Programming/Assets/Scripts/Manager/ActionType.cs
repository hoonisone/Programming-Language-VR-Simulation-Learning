public class ActionType
{
    ObjectType objectType;
    MotionType motionType;

    public ActionType(ObjectType objectType, MotionType motionType)
    {
        this.ObjectType = objectType;
        this.MotionType = motionType;
    }
    public ObjectType ObjectType { get => objectType; set => objectType = value; }
    public MotionType MotionType { get => motionType; set => motionType = value; }

    public bool Compare(ActionType actionType)
    {
        if(ObjectType == actionType.ObjectType)
        {
            if(MotionType == actionType.MotionType)
            {
                return true;
            }
        }
        return false;
    }
}