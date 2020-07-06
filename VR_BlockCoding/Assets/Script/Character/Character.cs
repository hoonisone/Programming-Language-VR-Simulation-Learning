using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Character : MoveObject
{
    private float speed = 15;
    private enum State { REST, TURN_LEFT, TURN_RIGHT, MOVE_FORWARD };
    State state = State.REST;
    Vector3 starting;
    Vector3 destination;
    float progress;
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
        float hope, cur, workload;
        switch (state)
        {
            case State.REST:
                break;
            case State.MOVE_FORWARD:
                transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
                if(destination == GetPosition())
                {
                    state = State.REST;
                }
                break;
            case State.TURN_RIGHT:
                workload = Time.deltaTime * speed*20;
                transform.Rotate(Vector3.up * workload);
                progress += workload;
                if (progress >= 90)
                {
                    SetRotation(destination);
                    state = State.REST;
                }
                break;
            case State.TURN_LEFT:
                workload = Time.deltaTime * speed*20;
                transform.Rotate(-Vector3.up * workload);
                progress += workload;
                if (progress >= 90)
                {
                    SetRotation(destination);
                    state = State.REST;
                }
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
            starting = transform.rotation.eulerAngles;
            destination = transform.rotation.eulerAngles - Vector3.up * 90;
            progress = 0;
            state = State.TURN_LEFT;
        }
    }
    public void TurnRight()
    {
        if (state == State.REST)
        {
            starting = transform.rotation.eulerAngles;
            destination = transform.rotation.eulerAngles + Vector3.up * 90;
            progress = 0;
            state = State.TURN_RIGHT;
        }
    }

    public void MoveForward()
    {
        if(state == State.REST)
        {
            starting = GetPosition();
            destination = starting + transform.forward.normalized * GetSizeZ();
            progress = 0;
            state = State.MOVE_FORWARD;
        }
    }
}
