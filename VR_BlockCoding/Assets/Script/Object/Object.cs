using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class Object : MonoBehaviour
{
    // Start is called before the first frame update

    public void Awake()
    {
        CustomAwake();
    }
    void Start()
    {
        CustomStart();
    }
    // Update is called once per frame
    void Update()
    {
        CustomUpdate();
    }

    public virtual void CustomAwake()
    {

    }
    public virtual void CustomStart()
    {
    }

    public virtual void CustomUpdate()
    {
    }
    /////////////////////////////////////////////////////////////////////////////////////
    public Vector3 GetScale()
    {
        return transform.localScale;
    }

    public void SetScale(Vector3 scale)
    {
        transform.localScale = scale;
    }


    public Vector3 GetPosition()
    {
        return transform.position;
    }

    public void SetPosition(Vector3 position)
    {
        gameObject.transform.position = position;
    }
    public Color GetColor()
    {
        return gameObject.GetComponent<MeshRenderer>().material.color;
    }
    public void SetColor(Color c)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = c;
    }
    public float GetPositionX()
    {
        return transform.position.x;
    }
    public void SetPositionX(float x)
    {
        Vector3 position = transform.position;
        position.x = x;
        transform.position = position;
    }
    public float GetPositionY()
    {
        return transform.position.y;
    }
    public void SetPositiony(float y)
    {
        Vector3 position = transform.position;
        position.y = y;
        transform.position = position;
    }
    public float GetPositionZ()
    {
        return transform.position.z;
    }
    public void SetPositionZ(float z)
    {
        Vector3 position = transform.position;
        position.z = z;
        transform.position = position;
    }
    public float GetScaleX()
    {
        return transform.localScale.x;
    }
    public void SetScaleX(float x)
    {
        Vector3 scale = transform.localScale;
        scale.x = x;
        transform.localScale = scale;
    }
    public float GetScaleY()
    {
        return transform.localScale.y;
    }
    public void SetScaleY(float y)
    {
        Vector3 scale = transform.localScale;
        scale.y = y;
        transform.localScale = scale;
    }
    public float GetScaleZ()
    {
        return transform.localScale.z;
    }
    public void SetScaleZ(float z)
    {
        Vector3 scale = transform.localScale;
        scale.z = z;
        transform.localScale = scale;
    }
}
