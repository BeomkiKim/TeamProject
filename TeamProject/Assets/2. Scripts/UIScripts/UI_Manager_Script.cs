using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    public void BgmButton()
    {

    }

    public void Sound_EffectButton()
    {

    }

    public void Game_ResetButton()
    {

    }

    public void BackButton()
    {
        SceneManager.LoadScene(1);
    }
}
