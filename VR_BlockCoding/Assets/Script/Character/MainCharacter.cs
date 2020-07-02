using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : Character
{
    override public void CustomAwake()
    {
        base.CustomAwake();
        
    }
    public override void CustomStart()
    {
        base.CustomStart();
        SetScaleSizeAdjustStrategy(new MultipleAdjustStrategy(2));

    }
/*    public override void CustomUpdate()
    {
        base.CustomUpdate();
    }*/
}
