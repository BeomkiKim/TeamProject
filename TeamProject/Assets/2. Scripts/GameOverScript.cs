using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public bool is_gameOver;

    public GameObject gameOverPopup;

    private static GameOverScript _instance;
    public static GameOverScript instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType(typeof(GameOverScript)) as GameOverScript;

                if (_instance == null)
                    Debug.Log("no Singleton obj");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }

        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        is_gameOver = false;
    }

    private void Update()
    {
        GameOver();
    }

    public void GameOver()
    {
        if (is_gameOver == false)
            return;

        gameOverPopup.SetActive(true);
        CancelInvoke("Increase_HurtSpeed");
        CancelInvoke("IncreaseSpeed");
    }
}
