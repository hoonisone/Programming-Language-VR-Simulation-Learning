using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : AdjustObject
{
    override public void CustomAwake()
    {
        base.CustomAwake();
    }
    public override void CustomStart()
    {
        base.CustomStart();
    }
    public override void CustomUpdate()
    {
        base.CustomUpdate();
    }
    /////////////////////////////////////////////////////////////////////////////////////

    public void MoveDistanceX(float distance)
    {
        SetPositionX(GetPositionX() + distance);
    }

    public void MoveDistanceY(float distance)
    {
        SetPositionY(GetPositionY() + distance);
    }

    public void MoveDistanceZ(float distance)
    {
        SetPositionZ(GetPositionZ() + distance);
    }

    public void MoveSizeXBlock(int block)
    {
        SetPositionX(GetPositionX() + GetSizeX()*block);
    }

    public void MoveRoomY(int block)
    {
        SetPositionY(GetPositionY() + GetSizeY() * block);
    }

    public void MoveRoomZ(int block)
    {
        SetPositionZ(GetPositionZ() + GetSizeZ() * block);
    }
}
