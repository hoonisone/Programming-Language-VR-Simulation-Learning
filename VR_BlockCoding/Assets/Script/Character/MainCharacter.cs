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
        SetScaleSizeRatio(2);

    }
    /*    public override void CustomUpdate()
        {
            base.CustomUpdate();
        }*/
}
