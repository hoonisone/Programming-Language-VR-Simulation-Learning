public class MultipleAdjustStrategy : ScaleSizeAdjustStrategy
{
    float scaleSizeRatio = 1;

    public MultipleAdjustStrategy()
    {
    }
    public MultipleAdjustStrategy(int scaleSizeRatio)
    {
        this.scaleSizeRatio = scaleSizeRatio;
    }

    public float ConvertXScaleToSize(float scale)
    {
        return scale * scaleSizeRatio;
    }

    public float ConvertXSizeToScale(float size)
    {
        return size / scaleSizeRatio;
    }

    public float ConvertYScaleToSize(float scale)
    {
        return scale * scaleSizeRatio;
    }

    public float ConvertYSizeToScale(float size)
    {
        return size / scaleSizeRatio;
    }

    public float ConvertZScaleToSize(float scale)
    {
        return scale * scaleSizeRatio;
    }

    public float ConvertZSizeToScale(float size)
    {
        return size / scaleSizeRatio;
    }
}
