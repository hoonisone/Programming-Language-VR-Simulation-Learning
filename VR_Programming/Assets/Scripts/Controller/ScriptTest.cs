using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour
{
    ScriptController SC = new ScriptController();
    ScoreBoardController SBC = new ScoreBoardController();

    int curLine = 1;
    int[] scores;
    int[] maxScores;


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


        SBC.HideScoreBoard();
        scores = new int[4];
        scores[0] = 26;
        scores[1] = 25;
        scores[2] = 19;
        scores[3] = 36;

        maxScores = new int[4];
        maxScores[0] = 30;
        maxScores[1] = 30;
        maxScores[2] = 20;
        maxScores[3] = 40;


    }

    // Update is called once per frame
    void Update()
    {
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            audioSource.Play();
            SC.ShowScript(++curLine);
            if(curLine == SC.getScriptLength() + 1)
            {
                //자동으로는 이렇게
                SBC.PrintScore(scores, maxScores);

                // 직접 넣으려면 이렇게
                SBC.SetStars(1);
                SBC.SetTotalScore(15);
                SBC.SetDetailScores(scores, maxScores);
                SBC.PrintScore();
                
            }

        }
    }
}
