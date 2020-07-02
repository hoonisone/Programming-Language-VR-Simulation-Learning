using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Character : MoveObject
{
    private float speed = 5;
    private enum State { REST, TURN_LEFT, TURN_RIGHT, MOVE_FORWARD };
    State state = State.REST;
    Vector3 starting;
    Vector3 destination;
    override public void CustomAwake()
    {
        base.CustomAwake();
    }
    public override void CustomStart()
    {
        base.CustomStart();
        SetScaleSizeAdjustStrategy(new MultipleAdjustStrategy());
    }
    public override void CustomUpdate()
    {
        base.CustomUpdate();
        switch (state)
        {
            case State.REST:
                break;
            case State.MOVE_FORWARD:
                transform.Translate(GetDirection() * Time.deltaTime * speed);
                float hope = Vector3.Distance(starting, destination);
                float cur = Vector3.Distance(starting, GetPosition());
                if (cur >= hope)
                {
                    SetPosition(destination);
                    state = State.REST;
                }
                break;
            case State.TURN_RIGHT:
                transform.Rotate(-Vector3.up * Time.deltaTime * speed);
                break;
            case State.TURN_LEFT:
                transform.Rotate(Vector3.up * Time.deltaTime * speed);
                break;
            default:
                break;
        }
    }
    /////////////////////////////////////////////////////////////////////////////////////

    public Vector3 GetDirection()
    {
        return transform.localRotation * Vector3.forward;
    }

    public void TurnLeft()
    {
        if (state == State.REST)
        {

            state = State.TURN_LEFT;
        }
    }
    public void TurnRight()
    {
        if (state == State.REST)
        {

        }
    }

    public void MoveForward()
    {
        if(state == State.REST)
        {
            starting = GetPosition();
            destination = starting + GetDirection() * GetSizeZ();
            state = State.MOVE_FORWARD;
        }
    }
}
