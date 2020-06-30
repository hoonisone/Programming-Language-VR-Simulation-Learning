using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Object : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSize(float xSize, float ySize, float zSize)
    {
        transform.localScale = new UnityEngine.Vector3(xSize, ySize, zSize);
    }

    public void SetTranslate(float x, float y, float z)
    {
        gameObject.transform.position = new Vector3(x, y, z);
    }

    public void SetColor(Color c)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = c;
    }

}
