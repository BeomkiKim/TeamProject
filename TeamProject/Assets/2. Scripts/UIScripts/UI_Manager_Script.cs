using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UI_Manager_Script : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void GamesettingButton()
    {
        SceneManager.LoadScene(2);
    }

    public void PauseButton()
    {
        SceneManager.LoadScene(3);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }
}
