using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]public static int score;
    public static int HighScore;

    [SerializeField] Text scoreTxt;

    private void Update()
    {
       if(scoreTxt != null)
        {
            scoreTxt.text = $"SCORE: {score}";
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ++score;

        if(score>PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
            HighScore = PlayerPrefs.GetInt("highScore");
        }
    }
}
