using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Object
{
    float scale = (float)0.2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetWieth()
    {
        return ((int)transform.localScale.x)*10;
    }

    public int GetHeight()
    {
        return ((int)transform.localScale.z) * 10;
    }

    public void SetWidth(int width)
    {
        float y = transform.localScale.y;
        float z = transform.localScale.z;
        SetSize(width, y, z);
    }
    public void SetHeight(int height)
    {
        float x = transform.localScale.x;
        float y = transform.localScale.y;
        SetSize(x, y, height);
    }

    public Vector3 WhereIs(int x, int y)
    {
        return 0;
    }
}
