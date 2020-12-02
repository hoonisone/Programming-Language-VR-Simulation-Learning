using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    List<string> textScript;
    List<string> commandScript;
    ScriptInspector scriptInspector;
    ScriptController scriptController;
    ScoreBoardController scoreBoardController;
    OperatorController operatorController;
    SceneController sceneController;
    string gameSituation;

    public OperatorController OperatorController { get => OperatorController1; set => OperatorController1 = value; }
    public SceneController SceneController { get => sceneController; set => sceneController = value; }
    public OperatorController OperatorController1 { get => operatorController; set => operatorController = value; }

    // Start is called before the first frame update
    void Start()
    {
        sceneController = GameObject.Find("SceneController").GetComponent<SceneController>();
        textScript = new List<string>();
        commandScript = new List<string>();
        ScriptSetting();
        scriptInspector = new ScriptInspector(commandScript[sceneController.StageNum-1]);
        scriptController = new ScriptController(textScript[sceneController.StageNum - 1]);
        scoreBoardController = new ScoreBoardController();
        OperatorController = GameObject.Find("OperatorController").GetComponent<OperatorController>();
        
        gameSituation = "ready";
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameSituation)
        {
            case "ready":
                scoreBoardController.HideScoreBoard();
                scriptController.ShowScript(scriptInspector.Line);
                gameSituation = "doing";
                break;
            case "doing":
                if (scriptInspector.IsFinished())
                {
                    gameSituation = "done";
                }
                break;
            case "done":
                scoreBoardController.SetTotalScore(87);
                scoreBoardController.SetStars(2);
                scoreBoardController.SetDetailScores(new int[] { 3, 6, 11, 3 }, new int[] { 5, 7, 12, 3});
                scoreBoardController.PrintScore();
                gameSituation = "score";
                break;
            case "score":
                break;
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TestStep();
        }
    }

    public bool Execute(Action action, string message)
    {
        bool isExecutable = scriptInspector.Check(action);
        if (isExecutable)
        {
            scriptInspector.Execute(message);
            scriptController.ShowScript(scriptInspector.Line);
        }
        while (true)
        {
            if (scriptInspector.IsFinished())
                break;
            if (scriptInspector.CurAction.Performer.Equals(Performer.User))
            {
                break;
            }
            scriptInspector.Execute(message);
            if (scriptInspector.IsFinished())
                break;
            scriptController.ShowScript(scriptInspector.Line);
        }
        return isExecutable;
    }

    public void TestStep()
    {
        scriptInspector.Next();
        scriptController.ShowScript(scriptInspector.Line);
    }

    public void ScriptSetting()
    {
        textScript.Add("a = input()\n" +
                     "b = input()\n" +
                     "c = a + b\n" +
                     "if c <= 20:\n" +
                     "    a = a * 7\n" +
                     "    b = b * 5\n" +
                     "c = a * b\n" +
                     "print(c)");

        commandScript.Add("user execute inputLever inputLever1\t" +
                    "user read input input1\t" +
                    "user write variable a\n" +

                    "user execute inputLever inputLever1\t" +
                    "user read input input1\t" +
                    "user write variable b\n" +

                    "user read variable a\t" +
                    "user write operand operand1\t" +
                    "user read variable b\t" +
                    "user write operand operand2\t" +
                    "user execute operator +\t" +
                    "user read result result1\t" +
                    "user write variable c\n" +

                    "user read variable c\t" +
                    "user write operand operand1\t" +
                    "user read constant 20\t" +
                    "user write operand operand2\t" +
                    "user execute operator <=\t" +
                    "user read result result1\t" +
                    "user write condition condition1\t" +
                    "auto jump control control 3\n" +

                    "user read variable a\t" +
                    "user write operand operand1\t" +
                    "user read constant 7\t" +
                    "user write operand operand2\t" +
                    "user execute operator *\t" +
                    "user read result result1\t" +
                    "user write variable a\n" +

                    "user read variable b\t" +
                    "user write operand operand1\t" +
                    "user read constant 5\t" +
                    "user write operand operand2\t" +
                    "user execute operator *\t" +
                    "user read result result1\t" +
                    "user write variable b\n" +

                    "user read variable a\t" +
                    "user write operand operand1\t" +
                    "user read variable b\t" +
                    "user write operand operand2\t" +
                    "user execute operator *\t" +
                    "user read result result1\t" +
                    "user write variable c\n" +

                    "user read variable c\t" +
                    "user write output output1\t" +
                    "user execute outputLever outputLever1");

        textScript.Add("a = input()\n" +
                        "b = input()\n" +
                        "c = input()\n" +
                        "d = a\n" +
                        "if d < a:\n" +
                        "    d = a\n" +
                        "if d < b:\n" +
                        "    d = b\n" +
                        "if d < c:\n" +
                        "    d = c\n" +
                        "print(d)");
        commandScript.Add(  "user execute inputLever inputLever1\t" +
                            "user read input input1\t" +
                            "user write variable a\n" +

                            "user execute inputLever inputLever1\t" +
                            "user read input input1\t" +
                            "user write variable b\n" +

                            "user execute inputLever inputLever1\t" + 
                            "user read input input1\t" +
                            "user write variable c\n" +

                            "user read variable a\t" +
                            "user write variable d\n" +

                            "user read variable d\t" +
                            "user write operand operand1\t" +
                            "user read variable a\t" +
                            "user write operand operand2\t" +
                            "user execute operator <\t" +
                            "user read result result1\t" +
                            "user write condition condition1\t" +
                            "auto jump control control 2\n" +

                            "user read variable a\t" +
                            "user write variable d\n" +

                            "user read variable d\t" +
                            "user write operand operand1\t" +
                            "user read variable b\t" +
                            "user write operand operand2\t" +
                            "user execute operator <\t" +
                            "user read result result1\t" +
                            "user write condition condition1\t" +
                            "auto jump control control 2\n" +

                            "user read variable b\t" +
                            "user write variable d\n" +

                            "user read variable d\t" +
                            "user write operand operand1\t" +
                            "user read variable c\t" +
                            "user write operand operand2\t" +
                            "user execute operator <\t" +
                            "user read result result1\t" +
                            "user write condition condition1\t" +
                            "auto jump control control 2\n" +

                            "user read variable c\t" +
                            "user write variable d\n" +

                            "user read variable d\t" +
                            "user write output output1\t" +
                            "user execute outputLever outputLever1");

        textScript.Add( "a = 3\n" +
                        "b = 5\n" +
                        "c = 2\n" +
                        "if a > b:\n" +
                        "    d = a\n" +
                        "    a = b\n" +
                        "    b = d\n" +
                        "if b > c:\n" +
                        "    d = b\n" +
                        "    b = c\n" +
                        "    c = d\n" +
                        "if a > b:\n" +
                        "    d = a\n" +
                        "    a = b\n" +
                        "    b = d\n" +
                        "if b > c:\n" +
                        "    d = b\n" +
                        "    b = c\n" +
                        "    c = d");
        
        commandScript.Add(  "user read constant 3\t" +
                            "user write variable a\n" +

                            "user read constant 5\t" +
                            "user write variable b\n" +

                            "user read constant 2\t" +
                            "user write variable c\n" +

                            "user read variable a\t" +
                            "user write operand operand1\t" +
                            "user read variable b\t" +
                            "user write operand operand2\t" +
                            "user execute operator >\t" +
                            "user read result result1\t" +
                            "user write condition condition1\t" +
                            "auto jump control control 4\n" +

                            "user read variable a\t" +
                            "user write variable d\n" +

                            "user read variable b\t" +
                            "user write variable a\n" +

                            "user read variable d\t" +
                            "user write variable b\n" +

                            "user read variable b\t" +
                            "user write operand operand1\t" +
                            "user read variable c\t" +
                            "user write operand operand2\t" +
                            "user execute operator >\t" +
                            "user read result result1\t" +
                            "user write condition condition1\t" +
                            "auto jump control control 4\n" +

                            "user read variable b\t" +
                            "user write variable d\n" +

                            "user read variable c\t" +
                            "user write variable b\n" +

                            "user read variable d\t" +
                            "user write variable c\n" +

                            "user read variable a\t" +
                            "user write operand operand1\t" +
                            "user read variable b\t" +
                            "user write operand operand2\t" +
                            "user execute operator >\t" +
                            "user read result result1\t" +
                            "user write condition condition1\t" +
                            "auto jump control control 4\n" +

                            "user read variable a\t" +
                            "user write variable d\n" +

                            "user read variable b\t" +
                            "user write variable a\n" +

                            "user read variable d\t" +
                            "user write variable b\n" +

                            "user read variable b\t" +
                            "user write operand operand1\t" +
                            "user read variable c\t" +
                            "user write operand operand2\t" +
                            "user execute operator >\t" +
                            "user read result result1\t" +
                            "user write condition condition1\t" +
                            "auto jump control control 4\n" +

                            "user read variable b\t" +
                            "user write variable d\n" +

                            "user read variable c\t" +
                            "user write variable b\n" +

                            "user read variable d\t" +
                            "user write variable c");

    }
}
