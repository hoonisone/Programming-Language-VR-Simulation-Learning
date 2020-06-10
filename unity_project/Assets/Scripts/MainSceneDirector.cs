using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainSceneDirector : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject gameObject, parentObject;
    Vector3 cameraPosition;
    float cameraMoveSpeed = (float)0.1;
    void Start()
    {
        cameraPosition = Camera.main.transform.position;

        //UnityEngine.SceneManagement.SceneManager.LoadScene("Ready");
        gameObject = GameObject.Find("Cube (1)");
        parentObject = GameObject.Find("Cube (1)");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            cameraPosition.y += cameraMoveSpeed;
            Camera.main.transform.position = cameraPosition;
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            cameraPosition.y -= cameraMoveSpeed;
            Camera.main.transform.position = cameraPosition;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) { 
            cameraPosition.x -= cameraMoveSpeed;
            Camera.main.transform.position = cameraPosition;
        }

        if (Input.GetKey(KeyCode.RightArrow)){
            cameraPosition.x += cameraMoveSpeed;
            Camera.main.transform.position = cameraPosition;
        }

        

        if (Input.GetKey("f"))
        {
            cameraPosition.z += cameraMoveSpeed;
            Camera.main.transform.position = cameraPosition;
        }

        if (Input.GetKey("d"))
        {
            cameraPosition.z -= cameraMoveSpeed;
            Camera.main.transform.position = cameraPosition;
        }

        if (Input.GetMouseButtonDown(1))
        {
            //new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z)
            GameObject clone = Instantiate(gameObject, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
            clone.transform.position = new Vector3(10, 10, 10);
        }
    }


}