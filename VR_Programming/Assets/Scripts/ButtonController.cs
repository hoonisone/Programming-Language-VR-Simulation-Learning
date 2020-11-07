using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using TMPro;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public string type;
    bool isUP = true;
    GameObject upLever;
    GameObject downLever;
    // Start is called before the first frame update
    void Start()
    {   
        switch(type)
        {
            case "lever":
                upLever = transform.Find("Handle(up)").gameObject;
                downLever = transform.Find("Handle(down)").gameObject;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void excute(int mouseButton)
    {
        Debug.Log("연우");
        MyValueController myValue = GameObject.FindWithTag("MyValue").GetComponent<MyValueController>();
        switch (type)
        {

            case "constant":
                myValue.setValue(getValue());
                break;
            case "variable":
                switch (mouseButton)
                {
                    case 0:
                        Debug.Log("left");
                        setValue(myValue.getValue());
                        break;
                    case 1:
                        Debug.Log("right");
                        myValue.setValue(getValue());
                        break;
                }
                break;
            case "input":
                myValue.setValue(getValue());
                break;
            case "output":
                setValue(myValue.getValue());
                break;
            case "operater":
                GameObject[] parameters = GameObject.FindGameObjectsWithTag("Parameter");
                ButtonController return_controller = GameObject.FindGameObjectWithTag("Return").GetComponent<ButtonController>();
                int parameter_value1 = int.Parse(parameters[0].GetComponent<ButtonController>().getValue());
                int parameter_value2 = int.Parse(parameters[1].GetComponent<ButtonController>().getValue());
                switch (getValue())
                {
                    case "+":
                        return_controller.setValue((parameter_value1 + parameter_value2).ToString());
                        break;
                    case "-":
                        return_controller.setValue((parameter_value1 - parameter_value2).ToString());
                        break;
                    case "*":
                        return_controller.setValue((parameter_value1 * parameter_value2).ToString());
                        break;
                    case "/":
                        if (parameter_value2 == 0)
                            Debug.Log("Division by zero is not posible");
                        else
                            return_controller.setValue((parameter_value1 / parameter_value2).ToString());
                        break;
                    case "%":
                        return_controller.setValue((parameter_value1 % parameter_value2).ToString());
                        break;
                }
                break;
            case "parameter":
                setValue(myValue.getValue());
                break;
            case "return":
                myValue.setValue(getValue());
                break;
            case "lever":
                downLever.SetActive(isUP);
                isUP = !isUP;
                upLever.SetActive(isUP);
                break;
            default:
                break;
        }
        
    }
    
    public void setValue(string value)
    {
        transform.Find("Text (TMP)").GetComponent<TextMeshPro>().text = value;
    }

    public string getValue()
    {
        return transform.Find("Text (TMP)").GetComponent<TextMeshPro>().text;
    }
}
