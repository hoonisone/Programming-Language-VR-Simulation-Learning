using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NextSceneButton2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        Debug.Log("up");

        Debug.Log(Input.inputString);

        if (Input.GetKey("down"))
            Debug.Log(Input.inputString);

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("left");


        if (Input.GetMouseButton(0))
            Debug.Log("0");

        if (Input.GetMouseButton(1))
            Debug.Log("1");

        if (Input.GetMouseButton(2))
            Debug.Log("2");
    }

    void OnMouseUp()
    {
        Debug.Log("OnMouseUp");
    }

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
    }

    void OnMouseDrag()
    {
        Vector3 mousePosition
    = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        //마우스 좌표를 스크린 투 월드로 바꾸고 이 객체의 위치로 설정해 준다.
        this.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }
}
