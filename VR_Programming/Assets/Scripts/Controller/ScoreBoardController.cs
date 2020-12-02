using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoardController : MonoBehaviour
{
    static GameObject ScoreBoard;
    TextMeshPro Score;
    TextMeshPro Detail;

    static GameObject[] stars;
    static bool[] activeStars;
    static int total;


    public void HideScoreBoard()
    {
        ScoreBoard = GameObject.Find("ScoreBoard").gameObject;
        Score = GameObject.Find("Score").gameObject.GetComponent<TextMeshPro>();
        Detail = GameObject.Find("Detail").gameObject.GetComponent<TextMeshPro>();
        stars = new GameObject[3];
        stars[0] = GameObject.Find("ScoreStar0").gameObject;
        stars[1] = GameObject.Find("ScoreStar1").gameObject;
        stars[2] = GameObject.Find("ScoreStar2").gameObject;
        ScoreBoard.SetActiveRecursively(false);
        activeStars = new bool[3];
        for (int i = 0; i < 3; i++)
            activeStars[i] = false;
    }

    public void PrintScore(int[] scores, int[] maxScores)
    {

        //점수 자동 계산
        SetTotalScore(scores, maxScores);
        //강제로 점수 변경
        //SetTotalScore(80);
        if (total < 70)
            SetStars(1);
        else if (total < 90)
            SetStars(2);
        else
            SetStars(3);

        SetDetailScores(scores, maxScores);

        ScoreBoard.SetActiveRecursively(true);
        DrawStars();
    }
    public void PrintScore()
    {
        ScoreBoard.SetActiveRecursively(true);
        DrawStars();
    }

    public void SetStars(int n)
    {
        for (int i = 0; i < 3; i++)
            activeStars[i] = false;

        for (int i = 0; i < n; i++)
            activeStars[i] = true;

    }

    public void DrawStars()
    {
        for (int i = 0; i < 3; i++)
            stars[i].active = activeStars[i];
    }

    public void SetTotalScore(int[] scores, int[] maxScores)
    {
        int maxSum = 0;
        for (int i = 0; i < maxScores.Length; i++)
            maxSum += maxScores[i];

        int scoreSum = 0;
        for (int i = 0; i < scores.Length; i++)
            scoreSum += scores[i];

        total = scoreSum * 100 / maxSum;
        Score.text = "Score : " + total;
    }

    public void SetTotalScore(int TScore)
    {
        total = TScore;
        Score.text = "Score : " + total;
    }

    public void SetDetailScores(int[] scores, int[] maxScores)
    {
        Detail.text = "";
        Detail.text += "const : " + scores[0] + " / " + maxScores[0] + "\n";
        Detail.text += "var : " + scores[1] + " / " + maxScores[1] + "\n";
        Detail.text += "cpu : " + scores[2] + " / " + maxScores[2] + "\n";
        Detail.text += "in/output : " + scores[3] + " / " + maxScores[3] + "\n";
    }
}
