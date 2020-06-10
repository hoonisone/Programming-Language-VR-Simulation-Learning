using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Security.Cryptography;
using UnityEngine;



public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] prefab;
    public TextMesh prefabText;
    public GameObject clone;

    // Start is called before the first frame update
    void Start()
    {
        prefab = GameObject.FindGameObjectsWithTag("nemo"); // 탐색 순서는 hierarchy의 자식 순서
        prefabText = GameObject.Find("PrefapText").GetComponent<TextMesh>();
        for (int i = 0; i < 5; i++)
        {
            prefabText.text = i.ToString();
            clone = Instantiate(prefab[0], new Vector3(2f * i, 0, 0), Quaternion.identity);
        }
        clone.transform.Translate(new Vector3(0, 0, 1f)); // 객체처럼 사용가능=
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
