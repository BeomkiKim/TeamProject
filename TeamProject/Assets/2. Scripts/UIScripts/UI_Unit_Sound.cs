using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Unit_Sound : MonoBehaviour
{
    private AudioSource music;
    //private GameObject[] Sound;
    public static UI_Unit_Sound Instance;

    private void Awake()
    {
        //Sound = GameObject.FindGameObjectsWithTag("Sound");

        //if (Sound.Length >= 2)
        //{
        //    Destroy(sound.gameObject);
        //}

        //DontDestroyOnLoad(transform.gameObject);
        //audiosource = GetComponent<AudioSource>();

        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    public void PlayMusic()
    {
        if (Instance == null)
            music = gameObject.GetComponent<AudioSource>();
        else
            music = Instance.GetComponent<AudioSource>();
        music.enabled = true;
    }

    public void StopMusic()
    {
        if (Instance == null)
            music = gameObject.GetComponent<AudioSource>();
        else
            music = Instance.GetComponent<AudioSource>();
        music.enabled = false;
    }
}
