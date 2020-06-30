using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLand : Land
{
    float roomSize = 1;
    int width = 1;
    int height = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public RoomLand(int width, int height , float roomSize)
    {
        SetWidth(width);
        SetHeight(height);
        SetRoomSize(roomSize);
    }

    public float GetRoomSize()
    {
        return this.roomSize;
    }
    public void SetRoomSize(float scale)
    {
        this.roomSize = scale;
        SetScaleX(width * roomSize);
        SetScaleZ(height * roomSize);
    }
    public int GetWidth()
    {
        return width;
    }
    public void SetWidth(int width)
    {
        this.width = width;
        base.SetScaleX(width * roomSize);
    }
    public int GetHeight()
    {
        return this.height;
    }
    public void SetHeight(int height)
    {
        this.height = height;
        base.SetScaleZ(height * roomSize);
    }

    public Vector3 GetBasePoint()
    {
        Vector3 centorPoint = GetPosition();
        centorPoint.x -= (roomSize * width);
        centorPoint.z -= (roomSize * height);
        return centorPoint;
    }
    public Vector3 GetRoomBasePoint(int x, int z)
    {
        Vector3 basePoint = GetBasePoint();
        float newX = basePoint.x + roomSize * x;
        float newY = basePoint.y;
        float newZ = basePoint.z + roomSize * z;
        return basePoint;
        //return new Vector3(newX, newY, newZ);
    }
    public Vector3 GetRoomCentorPoint(int x, int z)
    {
        Vector3 roomBasePoint = GetRoomBasePoint(x, z);
        roomBasePoint.x += roomSize / 2;
        roomBasePoint.z += roomSize / 2;
        return roomBasePoint;
    }
}
