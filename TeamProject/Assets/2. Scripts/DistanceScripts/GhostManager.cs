using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostManager : MonoBehaviour
{
    public GameObject ghost;
    public GameObject character;

    Rigidbody2D ghost_Rb;

    float rushSpeed = 3f;
    float add_RushSpeed = 0.03f;

    private void Start()
    {
        ghost_Rb = ghost.GetComponent<Rigidbody2D>();
        InvokeRepeating("IncreaseSpeed", 1f, 1f);
    }

    private void FixedUpdate()
    {
        Ghost_Rush();
        PositionY_Follow();
    }

    void IncreaseSpeed()
    {
        rushSpeed += add_RushSpeed;
    }

    void Ghost_Rush()
    {
        if (GameOverScript.instance.is_gameOver == true)
            return;
        ghost_Rb.velocity = new Vector3(rushSpeed, ghost_Rb.velocity.y, 0);
    }

    void PositionY_Follow()
    {
        ghost.transform.position = new Vector2(ghost.transform.position.x, character.transform.position.y+1.5f);
    }
}
