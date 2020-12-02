using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorController : MonoBehaviour
{
    // Start is called before the first frame update
    List<OperatorGroup> groups;
    int num;
    GameObject[] objects;
    List<string> typeNames;
    int curGroupIdx;
    
    void Start()
    {
        OperatorGroup operatorGroup;
        objects = GameObject.FindGameObjectsWithTag("Operator");
        Debug.Log(objects);
        num = objects.Length;
        groups = new List<OperatorGroup>();
        typeNames = new List<string>();
        curGroupIdx = 0;

        operatorGroup = new OperatorGroup(num);
        operatorGroup.RegisterOperator(new string[] {"+", "-", "*", "/", "%", "**"});
        AddOperatorGroup("arithmetic" ,operatorGroup);

        operatorGroup = new OperatorGroup(num);
        operatorGroup.RegisterOperator(new string[] { "==", "!=", "<" ,"<=", ">", ">=" });
        AddOperatorGroup("comparison", operatorGroup);

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddOperatorGroup(string name, OperatorGroup group)
    {
        groups.Add(group);
        typeNames.Add(name);
    }

    public void NextSet()
    {
        string[] operators = groups[curGroupIdx].getNextOperatorSet();
        groups[curGroupIdx].move(1);
        for (int i = 0; i < num; i++)
        {
            objects[i].GetComponent<ButtonController>().setValue(operators[i]);
        }
    }
    public void CurSet()
    {
        string[] operators = groups[curGroupIdx].getNextOperatorSet();
        for (int i = 0; i < num; i++)
        {
            objects[i].GetComponent<ButtonController>().setValue(operators[i]);
        }
    }

    public void BeforeSet()
    {
        groups[curGroupIdx].move(-1);
        string[] operators = groups[curGroupIdx].getNextOperatorSet();
        for (int i = 0; i < num; i++)
        {
            objects[i].GetComponent<ButtonController>().setValue(operators[i]);
        }
    }

    public void NextGroup()
    {
        curGroupIdx++;
        curGroupIdx %= groups.Count;
        CurSet();
    }

    public void BeforeGroup()
    {
        curGroupIdx--;
        curGroupIdx %= groups.Count;
        CurSet();
    }
}

public class OperatorGroup
{
    List<string> operators;
    int setSize;
    int idx;
    public OperatorGroup(int setSize)
    {
        this.setSize = setSize;
        operators = new List<string>();
    }

    public void RegisterOperator(string operator_)
    {
        operators.Add(operator_);
    }

    public void RegisterOperator(string[] operators)
    {
        foreach(string op in operators)
        {
            RegisterOperator(op);
        }
    }

    public void move(int n)
    {
        idx += n;
        idx %= operators.Count;
        while (idx < 0)
        {
            idx += setSize;
            idx %= operators.Count;
        }
        
    }

    public string[] getNextOperatorSet()
    {
        int copyIdx = idx;
        string[] operatorSet = new string[setSize];

        for(int i=0; i< setSize; i++)
        {
            operatorSet[i] = operators[copyIdx++];
            if (copyIdx >= operators.Count)
            {
                copyIdx = 0;
            }
        }
        return operatorSet;
    }
}