using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Plane : AdjustObject
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
    abstract public float GetWidth();

    abstract public void SetWidth(float width);

    abstract public float GetHeight();

    abstract public void SetHeight(float height);

}
