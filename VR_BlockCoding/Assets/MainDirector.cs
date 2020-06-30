using System.Collections;
using System.Collections.Generic;
using System.Numerics;
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
        GameObject land = GameObject.Find("Land");
        land.AddComponent<RoomLand>();
        RoomLand landScript = land.GetComponent<RoomLand>();
        landScript.SetRoomSize((float)1);
        landScript.SetWidth(20);
        landScript.SetHeight(20);

        List<GameObject> obstacles = new List<GameObject>();
        List<UnityEngine.Vector3> positions = new List<UnityEngine.Vector3>();
        float y = landScript.GetPositionY();
        positions.Add(landScript.GetRoomBasePoint(3, 9));
        positions.Add(landScript.GetRoomCentorPoint(3, 9));
        positions.Add(landScript.GetRoomCentorPoint(3, 9));
        positions.Add(landScript.GetRoomCentorPoint(3, 9));
        positions.Add(landScript.GetRoomCentorPoint(3, 9));
        positions.Add(landScript.GetRoomCentorPoint(3, 9));
        positions.Add(landScript.GetRoomCentorPoint(3, 9));
        positions.Add(landScript.GetRoomCentorPoint(3, 9));
        positions.Add(landScript.GetRoomCentorPoint(3, 9));
        positions.Add(landScript.GetRoomCentorPoint(3, 9));
        GameObject obstacle = GameObject.Find("Obstacle");
        for (int i=0; i<10; i++)
        {
            GameObject obj = Instantiate(obstacle, positions[i], UnityEngine.Quaternion.identity);
            obstacles.Add(obj);
        }
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
