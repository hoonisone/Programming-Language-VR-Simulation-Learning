using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustObject : Object
{
    // Start is called before the first frame update
    private ScaleSizeAdjustStrategy scaleSizeAdjustStrategy;
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
    public ScaleSizeAdjustStrategy GetScaleSizeAdjustStrategy()
    {
        return scaleSizeAdjustStrategy;
    }
    public void SetScaleSizeAdjustStrategy(ScaleSizeAdjustStrategy scaleSizeConvertStrategy)
    {
        this.scaleSizeAdjustStrategy = scaleSizeConvertStrategy;
    }



    public void SetSize(Vector3 size)
    {
        float scaleX = scaleSizeAdjustStrategy.ConvertXSizeToScale(size.x);
        float scaleY = scaleSizeAdjustStrategy.ConvertXSizeToScale(size.y);
        float scaleZ = scaleSizeAdjustStrategy.ConvertXSizeToScale(size.z);
        Vector3 scale = new Vector3(scaleX, scaleY, scaleZ);
        SetScale(scale);
    }

    public Vector3 GetSize()
    {
        Vector3 scale = GetScale();
        float sizeX = scaleSizeAdjustStrategy.ConvertXScaleToSize(scale.x);
        float sizeY = scaleSizeAdjustStrategy.ConvertXScaleToSize(scale.y);
        float sizeZ = scaleSizeAdjustStrategy.ConvertXScaleToSize(scale.z);
        return new Vector3(sizeX, sizeY, sizeZ);
    }

    public float GetSizeX()
    {
        return scaleSizeAdjustStrategy.ConvertXScaleToSize(GetScaleX());
    }

    public void SetSizeX(float sizeX)
    {
        SetScaleX(scaleSizeAdjustStrategy.ConvertXSizeToScale(sizeX));
    }

    public float GetSizeY()
    {
        return scaleSizeAdjustStrategy.ConvertXScaleToSize(GetScaleY());
    }

    public void SetSizeY(float sizeY)
    {
        SetScaleY(scaleSizeAdjustStrategy.ConvertXSizeToScale(sizeY));
    }

    public float GetSizeZ()
    {
        return scaleSizeAdjustStrategy.ConvertXScaleToSize(GetScaleZ());
    }

    public void SetSizeZ(float sizeZ)
    {
        SetScaleZ(scaleSizeAdjustStrategy.ConvertXSizeToScale(sizeZ));
    }
}
