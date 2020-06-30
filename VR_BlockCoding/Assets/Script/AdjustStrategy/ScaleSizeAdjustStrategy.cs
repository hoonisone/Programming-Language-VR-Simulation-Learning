using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ScaleSizeAdjustStrategy
{
    // Start is called before the first frame update
    float ConvertXSizeToScale(float size);
    float ConvertYSizeToScale(float size);
    float ConvertZSizeToScale(float size);
    float ConvertXScaleToSize(float scale);
    float ConvertYScaleToSize(float scale);
    float ConvertZScaleToSize(float scale);
}
