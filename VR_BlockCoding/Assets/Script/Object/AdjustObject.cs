using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustObject : Object
{
    // Start is called before the first frame update
    float scaleSizeRatio = 1;
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

    public void SetScaleSizeRatio(float scaleSizeRatio)
    {
        this.scaleSizeRatio = scaleSizeRatio;
    }

    public float GetScaleSizeRatio()
    {
        return this.scaleSizeRatio;
    }

    public void SetSize(Vector3 size)
    {
        float scaleX = size.x / scaleSizeRatio;
        float scaleY = size.y / scaleSizeRatio;
        float scaleZ = size.z / scaleSizeRatio;
        Vector3 scale = new Vector3(scaleX, scaleY, scaleZ);
        SetScale(scale);
    }

    public Vector3 GetSize()
    {
        Vector3 scale = GetScale();
        float sizeX = scale.x * scaleSizeRatio;
        float sizeY = scale.y * scaleSizeRatio;
        float sizeZ = scale.z * scaleSizeRatio;
        return new Vector3(sizeX, sizeY, sizeZ);
    }

    public float GetSizeX()
    {
        return GetScaleX() * scaleSizeRatio;
    }

    public void SetSizeX(float sizeX)
    {
        SetScaleX(sizeX/ scaleSizeRatio);
    }

    public float GetSizeY()
    {
        return GetScaleY() * scaleSizeRatio;
    }

    public void SetSizeY(float sizeY)
    {
        SetScaleY(sizeY/ scaleSizeRatio);
    }

    public float GetSizeZ()
    {
        return GetScaleZ() * scaleSizeRatio;
    }

    public void SetSizeZ(float sizeZ)
    {
        SetScaleZ(sizeZ / scaleSizeRatio);
    }
}
