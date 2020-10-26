using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    GameObject child;

    public void setText(string tmpS)
    {
        TextMesh playerMetaData = GameObject.Find("playerText").GetComponent<TextMesh>();
        playerMetaData.text = tmpS;
    }

    public void ChangeThirdScene()
    {
        child = transform.GetChild(0).gameObject;
        Text playerMetaData = child.GetComponent<Text>();
        //Text playerMetaData = GameObject.Find("Player1Text").GetComponent<Text>();
        setText(playerMetaData.text);
    }

}
