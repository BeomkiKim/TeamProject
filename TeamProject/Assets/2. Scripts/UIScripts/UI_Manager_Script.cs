using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager_Script : MonoBehaviour
{
    public static bool GameIsPaused = false;

    void Start()
    {
        Time.timeScale = 1.0f;
        GameIsPaused = true;
    }

    void Update()
    {
        
    }

    public void Pause() 
    { 
        Time.timeScale = 0.0f; 
        GameIsPaused = true; 
    }

    public void Resume() 
    { 
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

    public void ReplayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

//�ܺ�����
//https://husk321.tistory.com/107 [�������]
//[��ó] Unity���� ������ restart��� �߰��ϱ�| �ۼ��� ��Ǫ�� �ϴ��� ����