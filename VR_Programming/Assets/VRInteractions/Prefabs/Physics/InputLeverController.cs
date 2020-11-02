using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputLeverController : MonoBehaviour
{

    public string name;

    Camera _mainCam;
    bool isUP = true;
    GameObject gameObject;
    GameObject upLever;
    GameObject downLever;
    // Start is called before the first frame update
    void Start()
    {
        _mainCam = Camera.main;
        upLever = transform.Find("Handle(up)").gameObject;
        downLever = transform.Find("Handle(down)").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))

        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if( Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.gameObject.name);
                if(hit.transform.gameObject.name == name)
                {
                    clicked();
                }
                /*hit.transform.GetComponent<InputLeverController>().clicked();
                if(Object.ReferenceEquals(hit.transform.gameObject.name, this))
                {
                    clicked();
                }*/
            }
        }
    }
    void clicked()
    {
        if (isUP)
        {
            isUP = false;
            upLever.SetActive(false);
            downLever.SetActive(true);
        }
        else
        {
            isUP = true;
            upLever.SetActive(true);
            downLever.SetActive(false);
        }
    }
}
