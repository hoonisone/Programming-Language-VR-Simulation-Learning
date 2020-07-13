using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBlock : Block
{
    List<Block> blockList = new List<Block>();

    override public void CustomAwake()
    {
        base.CustomAwake();
    }
    public override void CustomStart()
    {
        base.CustomStart();
    }
    public override void CustomUpdate()
    {
        base.CustomUpdate();


    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        gameObject.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
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
