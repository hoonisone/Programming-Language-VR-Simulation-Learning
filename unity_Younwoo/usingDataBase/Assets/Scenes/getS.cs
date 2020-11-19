using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getS : MonoBehaviour
{
    // Start is called before the first frame update
    //https://www.youtube.com/watch?v=4W90-mh70JY

    public IEnumerator Start()
    {
        
        
        
        WWWForm form = new WWWForm();
        form.AddField("level", 1);
        form.AddField("stage", 1);


        WWW request = new WWW("http://localhost/sqlconnect/getsbylevel.php", form);
        yield return request;
        //Debug.Log(request.text);
        
    }




}
