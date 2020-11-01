using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCh : MonoBehaviour
{
    public void ChangeFirstScene()
    {
        SceneManager.LoadScene("1.FirstScene");
    }
    public void ChangeSecondScene()
    {
        SceneManager.LoadScene("2.SecondScene");
    }
    public void ChangeThirdScene()
    {
        SceneManager.LoadScene("3.ThirdScene");
    }

}
