using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptController : MonoBehaviour
{
    int step = 0;
    GameObject True;
    GameObject False;
    // Start is called before the first frame update
    void Start()
    {
        True = transform.Find("True").gameObject;
        False = transform.Find("False").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        switch (step)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.Tab))
                {
                    audioSource.Play();
                    next();
                    step++;
                }
                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.Tab))
                {
                    audioSource.Play();
                    next();
                    step++;
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.Tab))
                {
                    audioSource.Play();
                    next();
                    step++;
                    True.SetActive(true);
                    False.SetActive(true);
                }
                break;
            case 3:
                if (Input.GetKeyDown(KeyCode.Tab))
                {
                    audioSource.Play();
                    next();
                    step++;
                    True.SetActive(false);
                    False.SetActive(false  );

                }
                break;
            case 4:
                if (Input.GetKeyDown(KeyCode.Tab))
                {
                    audioSource.Play();
                    next();
                    step++;
                }
                break;
            case 5:
                if (Input.GetKeyDown(KeyCode.Tab))
                {
                    audioSource.Play();
                    next();
                    step++;
                }
                break;
            case 6:
                if (Input.GetKeyDown(KeyCode.Tab))
                {
                    audioSource.Play();
                    next();
                    step++;
                }
                break;
        }

        
    }
    public void next()
    {
        Vector3 v = transform.Find("highlight").position;
        v = new Vector3(v.x, v.y - 0.24f, v.z);
        transform.Find("highlight").position = v;
    }
}


