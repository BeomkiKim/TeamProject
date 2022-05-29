using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class UI_Sound : MonoBehaviour
{
    AudioSource sound;
    public AudioMixer mixer;

    public void BGMSetLevel(float sliderVal) 
    {
        mixer.SetFloat("BGM", Mathf.Log10(sliderVal)*20);
    }

    public void SoundEffectSetLevel(float sliderVal)
    {
        mixer.SetFloat("SoundEffect", Mathf.Log10(sliderVal) * 20);
    }

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    public void MutePush()
    {
        if (sound.mute)
        {
            sound.mute = false;
        }
        else
        {
            sound.mute = true;
        }

    }
}
