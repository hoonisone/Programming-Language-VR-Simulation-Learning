using UnityEngine;

public class XZPlane : Plane
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
    public XZPlane()
    {
    }
    override public float GetWidth()
    {
        return GetSizeX();
    }
    override public void SetWidth(float width)
    {
        SetSizeX(width);
    }
    override public float GetHeight()
    {
        return GetSizeZ();
    }
    override public void SetHeight(float height)
    {
        SetSizeZ(height);
    }

}

