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
    public string name;
    bool isUP = true;
    GameObject upLever;
    GameObject downLever;
    MyValueController myValue;
    GameObject constantView;
    AudioSource[] audioSources;
    // Start is called before the first frame update
    void Start()
    {   
        switch(type)
        {
            case "inputLever":
            case "outputLever":
                upLever = transform.Find("Handle(up)").gameObject;
                downLever = transform.Find("Handle(down)").gameObject;
                break;
            case "constantReset":
                constantView = GameObject.FindWithTag("ConstantView");
                break;
            case "constant":
                constantView = GameObject.FindWithTag("ConstantView");
                break;
            default:
                break;
        }
        myValue = GameObject.FindWithTag("MyValue").GetComponent<MyValueController>();
        audioSources = gameObject.GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void excute(string mouseEvent, string mouseButton){

        switch (type)
        {
            case "constant":        constantControll    (mouseEvent, mouseButton); break;
            case "constantView":    constantViewControll(mouseEvent, mouseButton); break;
            case "constantReset":   constantResetControll(mouseEvent, mouseButton); break;
            case "variable":        variableControll    (mouseEvent, mouseButton); break;
            case "input":           inputControll       (mouseEvent, mouseButton); break;
            case "output":          outputControll      (mouseEvent, mouseButton); break;
            case "operater":        operaterControll    (mouseEvent, mouseButton); break;
            case "parameter":       parameterControll   (mouseEvent, mouseButton); break;
            case "return":          returnControll      (mouseEvent, mouseButton); break;
            case "inputLever":      inputLeverControll  (mouseEvent, mouseButton); break;
            case "outputLever":     outputLeverControll (mouseEvent, mouseButton); break;
        }
    }

    private void constantViewControll(string mouseEvent, string mouseButton)
    {
        //audioSources = gameObject.GetComponents<AudioSource>();
        MyValueController myValue = GameObject.FindWithTag("MyValue").GetComponent<MyValueController>();
        if (mouseEvent.Equals("up") && mouseButton.Equals("right"))
        {
            audioSources[1].Play();
        }
        else if (mouseEvent.Equals("up") && mouseButton.Equals("left"))
        {
            return;
        }
        else if (mouseEvent.Equals("down") && mouseButton.Equals("right"))
        {
            audioSources[0].Play();
            bool flag = sendAction(new Action(Performer.User, ObjectType.Constant, MotionType.Read, name));
            if (flag)
            {
                myValue.setValue(getValue());

            }
        }
        else if (mouseEvent.Equals("down") && mouseButton.Equals("left"))
        {
            return;
        }
    }

    private void constantResetControll(string mouseEvent, string mouseButton)
    {
        if (mouseEvent.Equals("up") && mouseButton.Equals("right"))
        {
            return;
        }
        else if (mouseEvent.Equals("up") && mouseButton.Equals("left"))
        {
            audioSources[1].Play();
        }
        else if (mouseEvent.Equals("down") && mouseButton.Equals("right"))
        {
            return;
        }
        else if (mouseEvent.Equals("down") && mouseButton.Equals("left"))
        {
            audioSources[0].Play();
            constantView.transform.Find("Text (TMP)").GetComponent<TextMeshPro>().text = "0";
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
    void constantControll(string mouseEvent, string mouseButton){
        if (mouseEvent.Equals("up") && mouseButton.Equals("right")){
            return;
        }
        else if (mouseEvent.Equals("up") && mouseButton.Equals("left")){
            audioSources[1].Play(); 
        }else if (mouseEvent.Equals("down") && mouseButton.Equals("right")){
            return;
        }
        else if (mouseEvent.Equals("down") && mouseButton.Equals("left")){
            audioSources[0].Play();
            string value = constantView.transform.Find("Text (TMP)").GetComponent<TextMeshPro>().text;
            constantView.transform.Find("Text (TMP)").GetComponent<TextMeshPro>().text = (int.Parse(value) * 10 + int.Parse(getValue())).ToString();
        }
    }
    void variableControll(string mouseEvent, string mouseButton) {
        if (mouseEvent.Equals("up") && mouseButton.Equals("right")){
            audioSources[1].Play();
            return;
        }else if (mouseEvent.Equals("up") && mouseButton.Equals("left")){
            audioSources[1].Play();
            return;
        }else if (mouseEvent.Equals("down") && mouseButton.Equals("right")){
            audioSources[0].Play();
            bool flag = sendAction(new Action(Performer.User, ObjectType.Variable, MotionType.Read, name));
            if (flag)
            {
                myValue.setValue(getValue());
            }
        }
        else if (mouseEvent.Equals("down") && mouseButton.Equals("left")){
            audioSources[0].Play();
            
            bool flag = sendAction(new Action(Performer.User, ObjectType.Variable, MotionType.Write, name));
            if (flag)
            {
                setValue(myValue.getValue());
            }
        }
    }
    void inputControll(string mouseEvent, string mouseButton) {
        if (mouseEvent.Equals("up") && mouseButton.Equals("right")){
            audioSources[1].Play();
        }else if (mouseEvent.Equals("up") && mouseButton.Equals("left")){
            return;
        }else if (mouseEvent.Equals("down") && mouseButton.Equals("right")){
            audioSources[0].Play();
            bool flag = sendAction(new Action(Performer.User, ObjectType.Input, MotionType.Read, name));
            if (flag)
            {
                myValue.setValue(getValue());
            }
            
        }
        else if (mouseEvent.Equals("down") && mouseButton.Equals("left")){
            return;
        }
    }
    void outputControll(string mouseEvent, string mouseButton) {
        if(mouseEvent.Equals("up") && mouseButton.Equals("right")){
            return;
        }else if (mouseEvent.Equals("up") && mouseButton.Equals("left")){
            audioSources[1].Play();
            return;
        }else if (mouseEvent.Equals("down") && mouseButton.Equals("right")){
            return;
        }else if (mouseEvent.Equals("down") && mouseButton.Equals("left")){
            audioSources[0].Play();
            bool flag = sendAction(new Action(Performer.User, ObjectType.Output, MotionType.Write, name));
            if (flag)
            {
                setValue(myValue.getValue());
            }
        }
    }
    void operaterControll(string mouseEvent, string mouseButton) {
        if (mouseEvent.Equals("up") && mouseButton.Equals("right")){
            return;
        }else if (mouseEvent.Equals("up") && mouseButton.Equals("left")){
            audioSources[1].Play();
        }else if (mouseEvent.Equals("down") && mouseButton.Equals("right")){
            return;
        }else if (mouseEvent.Equals("down") && mouseButton.Equals("left")){
            audioSources[0].Play();
            bool flag = sendAction(new Action(Performer.User, ObjectType.Operator, MotionType.Execute, name));
            if (flag)
            {
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
            }
            
        }
    }
    void parameterControll(string mouseEvent, string mouseButton){
        if (mouseEvent.Equals("up") && mouseButton.Equals("right")){
            return;
        }else if (mouseEvent.Equals("up") && mouseButton.Equals("left")){
            audioSources[1].Play();
        }else if (mouseEvent.Equals("down") && mouseButton.Equals("right")){
            return;
        }else if (mouseEvent.Equals("down") && mouseButton.Equals("left")){
            audioSources[0].Play();
            bool flag = sendAction(new Action(Performer.User, ObjectType.Parameter, MotionType.Write, name));
            if (flag)
            {
                setValue(myValue.getValue());
            }
        }
    }
    void returnControll(string mouseEvent, string mouseButton){
        if (mouseEvent.Equals("up") && mouseButton.Equals("right")){
            audioSources[1].Play();
            return;
        }else if (mouseEvent.Equals("up") && mouseButton.Equals("left")){
            return;
        }else if (mouseEvent.Equals("down") && mouseButton.Equals("right")){
            audioSources[0].Play();
            bool flag = sendAction(new Action(Performer.User, ObjectType.Result, MotionType.Read, name));
            if (flag)
            {
                myValue.setValue(getValue());
            }
        }
        else if (mouseEvent.Equals("down") && mouseButton.Equals("left")){
            return;
        }
    }
    void inputLeverControll(string mouseEvent, string mouseButton)
    {
        
        if (mouseEvent.Equals("up") && mouseButton.Equals("right")){
            return;
        }else if (mouseEvent.Equals("up") && mouseButton.Equals("left")){
            audioSources[1].Play();
            downLever.SetActive(isUP);
            isUP = !isUP;
            upLever.SetActive(isUP);
        }else if (mouseEvent.Equals("down") && mouseButton.Equals("right")){
            return;
        }else if (mouseEvent.Equals("down") && mouseButton.Equals("left")){
            audioSources[0].Play();
            downLever.SetActive(isUP);
            isUP = !isUP;
            upLever.SetActive(isUP);
            bool flag = sendAction(new Action(Performer.User, ObjectType.InputLever, MotionType.Execute, name));
            if (flag)
            {
                transform.parent.transform.Find("button").transform.Find("Text (TMP)").GetComponent<TextMeshPro>().text = Random.Range(0, 10).ToString();
            }
        }
    }
    void outputLeverControll(string mouseEvent, string mouseButton)
    {
        if (mouseEvent.Equals("up") && mouseButton.Equals("right")){
            return;
        }else if (mouseEvent.Equals("up") && mouseButton.Equals("left")){
            audioSources[1].Play();
            downLever.SetActive(isUP);
            isUP = !isUP;
            upLever.SetActive(isUP);
        }else if (mouseEvent.Equals("down") && mouseButton.Equals("right")){
            return;
        }else if (mouseEvent.Equals("down") && mouseButton.Equals("left")){
            audioSources[0].Play();
            downLever.SetActive(isUP);
            isUP = !isUP;
            upLever.SetActive(isUP);
            bool flag = sendAction(new Action(Performer.User, ObjectType.OutputLever, MotionType.Execute, name));
            if (flag)
            {
                transform.parent.transform.Find("button").transform.Find("Text (TMP)").GetComponent<TextMeshPro>().text = "";
            }
        }
    }

    public bool sendAction(Action action)
    {
        return true;
    }
}