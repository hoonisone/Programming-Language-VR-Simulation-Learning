using UnityEngine;

public class Land : Object
{
    float scaleRatio = 10;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }

    public float GetWidth()
    {
        return transform.localScale.x;
    }
    public void SetWidth(float width)
    {
        float y = transform.localScale.y;
        float z = transform.localScale.z;
        SetScale(new Vector3(width, y, z));
    }
    public float GetHeight()
    {
        return transform.localScale.z;
    }
    public void SetHeight(float height)
    {
        float x = transform.localScale.x;
        float y = transform.localScale.y;
        SetScale(new Vector3(x, y, height));
    }
    public Vector3 GetBasePoint()
    {
        float x = transform.position.x - transform.localScale.x / 2;
        float y = transform.position.y;
        float z = transform.position.z - transform.localScale.z / 2;
        return new Vector3(x, y, z);
    }
}

