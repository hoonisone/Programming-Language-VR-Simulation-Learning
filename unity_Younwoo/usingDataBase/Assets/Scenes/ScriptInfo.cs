using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptInfo
{
    public string[] scriptCode;
    private static int scriptLength;

    public void setScriptCode(string[] sc, int len)
    {
        scriptCode = sc;
        scriptLength = len;
    }

    public string[] GetScriptCode()
    {
        return scriptCode;
    }

    public int ScriptLength ()
    {
        return scriptLength;
    }

}
