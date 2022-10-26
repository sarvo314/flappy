using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]private float Impulse;
    public static bool isGameOver;

    private void Start()
    {
        Score.score = 0;
        isGameOver = false;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !isGameOver)
        {
            rb.AddForce(Impulse*Vector2.up,ForceMode2D.Impulse);
            //(0,1)*10 = (0,10)
        }
    }
}
