using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneObject : Object
{
    // Start is called before the first frame update
    private GameObject plane;
    
    public PlaneObject(GameObject plane)
    {
        this.plane = plane;
    } 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaneSetTranslate(int x, int y)
    {
        gameObject.transform.position = new Vector3(x, y, 1);
    }
}
