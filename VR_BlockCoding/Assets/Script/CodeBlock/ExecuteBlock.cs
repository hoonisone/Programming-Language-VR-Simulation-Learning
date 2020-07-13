using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteBlock : Block
{
    override public void CustomAwake()
    {
        base.CustomAwake();
    }
    public override void CustomStart()
    {
        base.CustomStart();
        GameObject.Find("Main").GetComponent<MainDirector>().blockDown += remove;
    }
    public override void CustomUpdate()
    {
        base.CustomUpdate();


    }

    public void remove(Vector3 downLocation)
    {
        float X = GetPositionX();
        float Y = GetPositionY();
        float width = GetSizeX();
        float height = GetSizeY();
        float x = downLocation.x;
        float y = downLocation.y;
        if (X - width / 2 <= x && x <= X + width / 3 * 2 && Y - height / 3 * 4 <= y && y <= Y - height / 3 * 2) { 
            Debug.Log(true);
            SetColor(Color.green);
        }
        else {
            SetColor(Color.gray);
            Debug.Log(false);
        }
        /*
        Debug.Log(downLocation.x);
        Debug.Log(downLocation.y);
        Debug.Log(downLocation.z);*/
    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        gameObject.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        GameObject.Find("Main").GetComponent<MainDirector>().CreateEventBlockDown(Camera.main.ScreenToWorldPoint(mousePosition));
    }
    /////////////////////////////////////////////////////////////////////////////////////

    override public void setName(string text)
    {
        gameObject.transform.GetChild(0).gameObject.GetComponent<TextMesh>().text = text;
    }
    override public void execute()
    {
        //Debug.LogError("heled");
        GameObject mainCharacter = GameObject.Find("MainCharacter");
        mainCharacter.GetComponent<MainCharacter>().TurnLeft();
    }
}
