using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position + transform.forward, transform.forward * 100, Color.red);
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.forward, out hit))
            {
                ButtonController c = hit.transform.gameObject.GetComponent<ButtonController>();
                if (c != null)
                    c.excute(0);
            }

        }
        else if(Input.GetMouseButtonDown(1)) {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                ButtonController c = hit.transform.gameObject.GetComponent<ButtonController>();
                if (c != null)
                    c.excute(1);
            }

        }
    }
}


/*        Debug.DrawRay(transform.position, Input.mousePosition, Color.red);
*//*        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;

            Vector3 position = GameObject.FindWithTag("Aim").transform.position;
            position = Camera.main.WorldToScreenPoint(transform.forwar);
            Vector3 p = Input.mousePosition;
            p = new Vector3(position.x, position.y, 0.0f);
            Ray ray = Camera.main.ScreenPointToRay(p);
            Debug.DrawRay(transform.position, transform.forward * 8, Color.red);
            *//*Debug.Log("mouse");
            Debug.Log(Input.mousePosition);
            Debug.Log("aim");
            position = new Vector3(position.x, position.y, 0);
            Debug.Log(position);*//*
            if (Physics.Raycast(ray, out hit))
            {

                Debug.Log(hit.transform.gameObject.name);
                if (hit.transform.gameObject.name == name)
                {
                    clicked();
                }
                *//*hit.transform.GetComponent<InputLeverController>().clicked();
                if(Object.ReferenceEquals(hit.transform.gameObject.name, this))
                {
                    clicked();
                }*//*
            }
        }*/



