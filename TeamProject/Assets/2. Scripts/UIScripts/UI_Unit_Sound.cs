using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Unit_Sound : MonoBehaviour
{
    private AudioSource audioSource;
    private GameObject[] Sound;

    private void Awake()
    {
        Sound = GameObject.FindGameObjectsWithTag("Sound");

        if (Sound.Length >= 2)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();

    }

    public void PlayMusic()
    {
        if (audioSource.isPlaying)
            return;
        audioSource.Play();
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }
}
