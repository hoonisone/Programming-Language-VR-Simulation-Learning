using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drector : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject cube;
    GameObject text;
    void Start()
    {
        cube = GameObject.Find("Cube");
        text = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {

    
        //text.textMa

        Vector3 vector = cube.transform.position;
        //vector.x++;
        cube.transform.position = vector;
        Quaternion quaternion = cube.transform.rotation;
        //quaternion.w++;
        //quaternion.x++;
        //quaternion.y++;
        quaternion.z++;
        cube.transform.rotation = quaternion;
    }
}
