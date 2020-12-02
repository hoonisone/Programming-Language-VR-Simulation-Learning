using System.Collections.Generic;
public class ActionRecorder
{
    List<List<int>> data;
    public ActionRecorder()
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
        data[(int)action.ObjectType][(int)action.MotionType]++;
    }

    public int getCount(Action action)
    {
        return data[(int)action.ObjectType][(int)action.MotionType];
    }
}
