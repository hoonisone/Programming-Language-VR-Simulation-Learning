using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class ScriptHandler : MonoBehaviour
{
    public static string[] scriptCode;
    public static int scriptLength;

    public void Start()
    {
        GetScriptByStage(1);
        ScriptInfo spi = new ScriptInfo();
        spi.setScriptCode(scriptCode, scriptLength);

        if (spi.scriptCode != null)
            Debug.Log(spi.scriptCode[0]);
    }

    public void GetScriptByStage(int num)
    {
        //ScriptInfo spi = new ScriptInfo();

        StartCoroutine(Request(num));
        //StartCoroutine(Request(num));
        //spi.setScriptCode(scriptCode, scriptLength);

        //if(spi.scriptCode !=null)
        // Debug.Log(spi.scriptCode[0]);
    }

    IEnumerator Request(int num)
    {
        WWWForm form = new WWWForm();
        form.AddField("level", 1);
        form.AddField("stage", num);


        WWW request = new WWW("http://localhost/sqlconnect/getsbylevel.php", form);
        yield return request;
        //Debug.Log(request.text);
        scriptCode = request.text.Split('@');
        scriptLength = scriptCode.Length;
        //Debug.Log(scriptCode[0]);
    }

}
