using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDirector : MonoBehaviour
{
    // Start is called before the first frame update
    /* GameObject Object = Instantiate
     GameObject Object = Instantiate(myBlock, new UnityEngine.Vector3(transform.position.x, transform.position.y + 4, transform.position.z), UnityEngine.Quaternion.identity);
    */
    List<GameObject> obstacles = new List<GameObject>();
    void Start()
    {
        Debug.LogError("Main Director Start");
        GameObject obj = GameObject.Find("Obstacle");
        GameObject newObj = Instantiate(obj, new UnityEngine.Vector3(transform.position.x, transform.position.y + 4, transform.position.z), UnityEngine.Quaternion.identity);
        //Obstacle a = newObj.GetComponent<Obstacle>().SetTranslate(1, 1, 1);
        
        
    }

    // Update is called once per frame
    void Update()
    {
/*        obstacles[1].GetComponent<Obstacle>
        Debug.LogError("Main Director Update");*/
    }

    public void TurnRight()
    {

    }
    public void TurnLeft()
    {

    }

    public void MoveForward()
    {

    }

    public void MoveBackward()
    {

    }
}
