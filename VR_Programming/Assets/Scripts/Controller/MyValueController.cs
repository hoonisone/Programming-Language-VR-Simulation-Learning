using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MyValueController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        setValue("1");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setValue(string value)
    {
        transform.Find("valueText").GetComponent<TextMeshPro>().text = value;
    }

    public string getValue()
    {
        return transform.Find("valueText").GetComponent<TextMeshPro>().text;
    }
}
