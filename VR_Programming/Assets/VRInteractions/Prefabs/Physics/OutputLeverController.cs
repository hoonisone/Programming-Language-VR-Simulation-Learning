using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputLeverController : MonoBehaviour
{
    bool isUP = true;
    GameObject upLever;
    GameObject downLever;
    // Start is called before the first frame update
    void Start()
    {
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

            Physics.Raycast(ray, out hit);



            if (hit.collider != null)
            {
                clicked();
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
