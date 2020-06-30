using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLand : Land
{
    float roomSize = 1;
    int width = 10;
    int height = 10;

    public override void CustomStart()
    {
        base.CustomStart();
    }
    public override void CustomUpdate()
    {
        base.CustomUpdate();
    }

    public float GetRoomSize()
    {
        return this.roomSize;
    }
    public void SetRoomSize(float scale)
    {
        this.roomSize = scale;
        SetWidth(width * roomSize);
        SetWidth(height * roomSize);
    }
    public new int GetWidth()
    {
        return width;
    }
    public void SetWidth(int width)
    {
        this.width = width;
        base.SetWidth(width * roomSize);
    }
    public new int GetHeight()
    {
        return this.height;
    }
    public void SetHeight(int height)
    {
        this.height = height;
        base.SetHeight(height * roomSize);
    }

    public Vector3 GetRoomBasePoint(int x, int z)
    {
        Vector3 basePoint = GetBasePoint();
        basePoint.x += roomSize * x;
        basePoint.z += roomSize * z;
        return basePoint;
    }
    public Vector3 GetRoomCentorPoint(int x, int z)
    {
        Vector3 roomBasePoint = GetRoomBasePoint(x, z);
        roomBasePoint.x += roomSize / 2;
        roomBasePoint.z += roomSize / 2;
        return roomBasePoint;
    }
}
