using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDirector : MonoBehaviour
{
    // Start is called before the first frame update
    /* GameObject Object = Instantiate
     GameObject Object = Instantiate(myBlock, new UnityEngine.Vector3(transform.position.x, transform.position.y + 4, transform.position.z), UnityEngine.Quaternion.identity);
    */
    GameObject land = null;
    GameObject obstacles = null;
    GameObject mainCharacter = null;
    void Start()
    {
        land = LandInitialization(land);
        obstacles = ObstaclesInitialization(obstacles, land);
        mainCharacter = MainCharacterInitialization(mainCharacter);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            mainCharacter.GetComponent<MainCharacter>().MoveForward();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            mainCharacter.GetComponent<MainCharacter>().TurnRight();
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            mainCharacter.GetComponent<MainCharacter>().TurnLeft();
        }
        /*        obstacles[1].GetComponent<Obstacle>
                Debug.LogError("Main Director Update");*/
    }

    public GameObject LandInitialization(GameObject land)
    {
        if(land != null)
        {
            Destroy(land);
        }
        land = GameObject.Find("Land");
        land.AddComponent<RoomLand>();
        RoomLand landScript = land.GetComponent<RoomLand>();
        landScript.SetRoomSize(1f);
        int mapSize = 20;
        landScript.SetWidth(mapSize);
        landScript.SetHeight(mapSize);
        return land;
    }

    public GameObject ObstaclesInitialization(GameObject obstacles, GameObject land)
    {
        if(obstacles != null)
        {
            int childCount = obstacles.transform.childCount;
            for(int i=0; i<childCount; i++)
            {
                Destroy(obstacles.transform.GetChild(0));
            }
        }
        obstacles = Instantiate(Resources.Load("Group")) as GameObject;
        obstacles.name = "Obstacles";
        RoomLand landScript = land.GetComponent<RoomLand>();
        for (int i = 0; i < landScript.GetWidth(); i++)
        {
            Vector3 position = landScript.GetRoomCentorPoint(i, Random.Range(0, 20));
            GameObject obj = Instantiate(Resources.Load("Obstacle"), position, Quaternion.identity) as GameObject;
            obj.AddComponent<Obstacle>();
            obj.name = "Obstacle" + i;
            obj.transform.parent = obstacles.transform;
        }
        return obstacles;
    }

    public GameObject MainCharacterInitialization(GameObject mainCharacter)
    {
        if(mainCharacter != null)
        {
            Destroy(mainCharacter);
        }
        mainCharacter = GameObject.Find("MainCharacter");
        mainCharacter.AddComponent<MainCharacter>();
        MainCharacter script = mainCharacter.GetComponent<MainCharacter>();
        script.SetPosition(new Vector3(0.5f, 0.5f, -9.5f));
        return mainCharacter;
    }
}
