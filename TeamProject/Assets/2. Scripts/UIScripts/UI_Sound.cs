using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class UI_Sound : MonoBehaviour
{
    AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    public void MutePush()
    {
        if (sound.mute)
        {
            sound.mute = false;
            AudioSource MutePush = GetComponent<AudioSource>();
            MutePush.Play();
        }
        else
        {
            sound.mute = true;
        }

    }
}
