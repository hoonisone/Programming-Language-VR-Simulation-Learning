using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : XZPlane
{
    override public void CustomAwake()
    {
        base.CustomAwake();
        SetScaleSizeRatio(10);
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
    public Vector3 GetBasePoint()
    {
        float x = GetPositionX() - GetWidth() / 2;
        float y = GetPositionY();
        float z = GetPositionZ() - GetHeight() / 2;
        return new Vector3(x, y, z);
    }
}
