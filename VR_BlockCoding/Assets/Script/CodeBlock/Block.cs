using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

abstract public class Block : MoveObject
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

    abstract public void setName(string targetText);
    abstract public void execute();
    
}
