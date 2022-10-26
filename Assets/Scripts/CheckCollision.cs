using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckCollision : MonoBehaviour
{
    [SerializeField] float waitForSeconds = 2f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision happened");
        PlayerMovement.isGameOver = true;
        Invoke("GameOver", waitForSeconds);
    }
    void GameOver()
    {
        Debug.Log($"Highscore is: {Score.HighScore}");
        SceneManager.LoadScene("GameOver");
    }
}
