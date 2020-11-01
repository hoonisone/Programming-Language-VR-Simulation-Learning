using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class LoadData : MonoBehaviour
{
    public string playerName = "newName";
    public int stage = 1;
    public int life = 3;

    // Start is called before the first frame update
    void Start()
    {
        ReadMeatData();
        SetText(DataToText(playerName, stage, life));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string DataToText(string pN, int st, int lif) // 플레이어명, 스테이지, 라이프개수
    {
        string cntLife = "";

        for (int i = 0; i < lif; i++)
            cntLife += "O";

        return "name: " + pN + "\n" + "Stage: " + st + "\n" + "Life: " + cntLife;
    }

    void SetText(string targetStr) // 버튼에 텍스트 설정
    {
        Text playerMetaData = GameObject.Find("Player1Text").GetComponent<Text>();
        playerMetaData.text = targetStr;
    }

    void ReadMeatData()
    {
        
        FileStream fs = new FileStream(Application.dataPath + "/Resources/userData1.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        string temp = sr.ReadLine();
        string[] dataSplit = temp.Split(',');
        playerName = dataSplit[0];
        stage = int.Parse(dataSplit[1]);
        life = int.Parse(dataSplit[2]);
    }
}
