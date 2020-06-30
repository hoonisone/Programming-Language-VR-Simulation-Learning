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
        GameObject land = GameObject.Find("Land");
        land.AddComponent<RoomLand>();
        RoomLand landScript = land.GetComponent<RoomLand>();
        landScript.SetRoomSize((float)1);
        int mapSize = 20;
        landScript.SetWidth(mapSize);
        landScript.SetHeight(mapSize);
        List<GameObject> obstacles = new List<GameObject>();
        List<UnityEngine.Vector3> positions = new List<UnityEngine.Vector3>();
        float y = landScript.GetPositionY();
        positions.Add(landScript.GetRoomCentorPoint(0, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(1, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(2, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(3, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(4, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(5, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(6, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(7, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(8, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(9, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(11, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(12, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(13, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(14, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(15, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(16, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(17, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(18, Random.Range(0, 20)));
        positions.Add(landScript.GetRoomCentorPoint(19, Random.Range(0, 20)));
        GameObject obstacle = GameObject.Find("Obstacle");
        for (int i=0; i< mapSize; i++)
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
