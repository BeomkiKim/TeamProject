using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostGameOver : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameOverScript.instance.is_gameOver = true;
        }
    }
}
