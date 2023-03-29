using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    void Start()
    {
        ResetScore();
    }
    void DisplayScore()
    {
        scoreText.text = $"{score}";
    }
    void ResetScore()
    {
        score = 0;
        DisplayScore();
    }
    public void ScoreCount()
    {
        score++;
        DisplayScore();
    }
    public void ScoreSubtract()
    {
        score--;
        DisplayScore();
    }
}
