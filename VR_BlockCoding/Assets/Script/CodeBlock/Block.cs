using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Block : Object
{
    public GameObject myBlock;
    static bool flag = true;
    List<GameObject> trueBlocks = new List<GameObject>();
    List<GameObject> falseBlocks = new List<GameObject>();

    private Execute execute = null;
    private Condition condition = null;

    public Block(Execute execute, Condition condition)
    {
        this.execute = execute;
        this.condition = condition;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (flag == true)
        {
            flag = false;
            trueBlocks.Add(Instantiate(myBlock, new UnityEngine.Vector3(transform.position.x, transform.position.y + 4, transform.position.z), UnityEngine.Quaternion.identity));
            print(trueBlocks.Count);
            trueBlocks[0].transform.GetChild(0).gameObject.transform.GetComponent<TextMeshPro>().text = "root Node";
            trueBlocks[0].GetComponent<Block>().setText("root Node");
        }

    }

    // Update is called once per frame
    void Update()
    {
/*        if (flag == false)
        {
            insertBlockInTrueBlocks(10, gameObject);
            trueBlocks[0].GetComponent<Block>().setText("root Node");
            setTranslate(10, 20, 10);
            flag = true;
        }*/
        
    }

    void setText(string targetText)
    {
        GameObject myText = myBlock.transform.GetChild(0).gameObject;
        myText.transform.GetComponent<TextMeshPro>().text = targetText;
    }

    void setTranslate(float x, float y, float z)
    {
        gameObject.transform.position = new Vector3(x, y, z);
    }

    void insertBlockInTrueBlocks(int idx, GameObject obj)
    {
        try
        {
            trueBlocks.Insert(idx, obj);
        }
        catch(ArgumentOutOfRangeException e)
        {
            Debug.LogError(e.Message);
        }
    }

    int getTrueBlocksSize()
    {
        return trueBlocks.Count;
    }

    int getFalseBlocksSize()
    {
        return falseBlocks.Count;
    }
    
}
