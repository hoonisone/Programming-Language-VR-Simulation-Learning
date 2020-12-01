using System.Collections.Generic;
public class ActionTypeRecorder
{
    List<List<int>> data;
    public ActionTypeRecorder()
    {
        int objectTypeNum = System.Enum.GetNames(typeof(ObjectType)).Length;
        int motionTypeNum = System.Enum.GetNames(typeof(MotionType)).Length;
        data = new List<List<int>>();
        for(int i=0; i<objectTypeNum; i++)
        {
            data.Add(new List<int>(new int[motionTypeNum]));
        }
    }

    public void record(Action action)
    {
        record(action.ActionType);
    }

    public void record(ActionType actionType)
    {
        data[(int)actionType.ObjectType][(int)actionType.MotionType]++;
    }

    public int getCount(Action action)
    {
        return getCount(action.ActionType);
    }

    public int getCount(ActionType actionType)
    {
        return data[(int)actionType.ObjectType][(int)actionType.MotionType];
    }
}
