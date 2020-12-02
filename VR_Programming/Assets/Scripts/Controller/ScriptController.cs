using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptController : MonoBehaviour
{

    private int nLines = 0;
    private int maxLines = 12;
    private int curLine = 1;
    TextMeshPro ScriptText;
    TextMeshPro ScriptIdx;
    string[] script;
    string[] scriptIndex;


    public void SetLine(string[] tscript)
    {
        //find textmeshpro
        ScriptText = GameObject.Find("ScriptText").gameObject.GetComponent<TextMeshPro>();
        ScriptIdx = GameObject.Find("ScriptIdx").gameObject.GetComponent<TextMeshPro>();

        nLines = tscript.Length;
        script = new string[nLines + maxLines];
        scriptIndex = new string[nLines + maxLines];

        int i = 0;
        for (; i < maxLines / 2; i++)
        {
            script[i] = "";
            scriptIndex[i] = "";
        }
        for (; i < nLines + maxLines / 2; i++)
        {
            scriptIndex[i] = i - maxLines / 2 + 1 + "";
            script[i] = "| " + tscript[i - maxLines / 2];
        }
        for (; i < nLines + maxLines; i++)
        {
            script[i] = "";
            scriptIndex[i] = "";
        }
    }

    public void ShowScript(int n)
    {
        ScriptIdx.text = "";
        ScriptText.text = "";
        if (n + maxLines > nLines + maxLines)
            n = nLines;
        for (int i = n - 1; i < n - 1 + maxLines; i++)
        {
            ScriptIdx.text += scriptIndex[i] + "\n";
            ScriptText.text += script[i] + "\n";
        }
    }


    public int getScriptLength()
    {
        return nLines;
    }
}


