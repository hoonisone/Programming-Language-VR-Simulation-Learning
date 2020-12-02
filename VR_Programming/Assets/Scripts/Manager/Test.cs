using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string script = "user execute inputLever inputLever1\t" +
                    "user read input input1\t" +
                    "user write variable a\n" +

                    "user execute inputLever inputLever1\t" +
                    "user read input input1\t" +
                    "user write variable b\n" +

                    "user read variable a\t" +
                    "user write parameter input1\t" +
                    "user read variable b\t" +
                    "user write parameter input2\t" +
                    "user execute operator +\t" +
                    "user read result result1\t" +
                    "user write variable c\n" +

                    "user read variable c\t" +
                    "user write parameter input1\t" +
                    "user read constant 20\t" +
                    "user write parameter input2\t" +
                    "user execute operator <=\t" +
                    "user read result result1\t" +
                    "user write condition condition1\t" +
                    "auto jump control control 3\n" +

                    "user read variable a\t" +
                    "user write parameter input1\t" +
                    "user read constant 7\t" +
                    "user write parameter input2\t" +
                    "user execute operator *\t" +
                    "user read result result1\t" +
                    "user write variable a\n" +

                    "user read variable b\t" +
                    "user write parameter input1\t" +
                    "user read constant 5\t" +
                    "user write parameter input2\t" +
                    "user execute operator *\t" +
                    "user read result result1\t" +
                    "user write variable c\n" +

                    "user read variable a\t" +
                    "user write parameter input1\t" +
                    "user read variable b\t" +
                    "user write parameter input2\t" +
                    "user execute operator *\t" +
                    "user read result result1\t" +
                    "user write variable c\n" +

                    "user read variable c\t" +
                    "user write output output1\t" +
                    "user execute outputlever outputLever1";

        ScriptInspector scriptInspector = new ScriptInspector(script);

        while (!scriptInspector.IsFinished())
        {
            Action action = scriptInspector.CurAction;
            Debug.Log(action.Performer.ToString() + "/" +action.ObjectType.ToString()+ "/" +action.MotionType.ToString() );
            scriptInspector.Execute("");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
