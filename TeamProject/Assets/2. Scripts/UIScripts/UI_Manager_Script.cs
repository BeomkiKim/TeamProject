using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager_Script : MonoBehaviour
{
    public static bool GameIsPaused = false; 
    public GameObject pauseMenuCanvas;

    void Start()
    {
        Time.timeScale = 0.0f;
        GameIsPaused = true;
    }

    void Update()
    {
        
    }

    public void Pause() 
    { 
        //pauseMenuCanvas.SetActive(true); 
        Time.timeScale = 0.0f; 
        GameIsPaused = true; 
    }

    public void Resume() 
    { 
        //pauseMenuCanvas.SetActive(false); 
        Time.timeScale = 1.0f; 
        GameIsPaused = false; 
    }

    public void PlayButton()
    {
        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }

    public void BackButton()
    {
        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }

    public void GamesettingButton()
    {
        Time.timeScale = 0.0f;
        GameIsPaused = true;
    }

    public void PauseButton()
    {
        Time.timeScale = 0.0f;
        GameIsPaused = true;
    }

    public void BgmButton()
    {

    }

    public void Sound_EffectButton()
    {

    }

    public void Game_ResetButton()
    {

    }
}

//외부참조
//https://husk321.tistory.com/107 [껍데기방]