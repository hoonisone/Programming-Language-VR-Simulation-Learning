using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour
{
    ScriptController SC = new ScriptController();

    int curLine = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        // change to any string array you want.
        string[] tscript = new string[12];
        tscript[0] = "a = input()";
        tscript[1] = "b = input()";
        tscript[2] = "c = a + b";
        tscript[3] = "if c <= 20:";
        tscript[4] = "    a = a * 7";
        tscript[5] = "    b = b * 5";
        tscript[6] = "c = a * b";
        tscript[7] = "print(c)";
        tscript[8] = "a = a * 7";
        tscript[9] = "a = a * 7";
        tscript[10] = "a = a * 7";
        tscript[11] = "a = a * 7";

        SC.SetLine(tscript);
        SC.ShowScript(curLine);
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            audioSource.Play();
            SC.ShowScript(++curLine);
        }
    }
}
