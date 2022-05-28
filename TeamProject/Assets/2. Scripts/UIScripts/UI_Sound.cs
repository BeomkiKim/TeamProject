using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class UI_Sound : MonoBehaviour
{
    AudioSource audiosource;
    public AudioMixer mixer;
    
    public void BGMSetLevel(float sliderVal) {
        mixer.SetFloat("BGM", Mathf.Log10(sliderVal)*20);
    }

    public void SoundEffectSetLevel(float sliderVal)
    {
        mixer.SetFloat("SoundEffect", Mathf.Log10(sliderVal) * 20);
    }

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    public void MutePush()
    {
        if (audiosource.mute)
        {
            audiosource.mute = false;
        }
        else
        {
            audiosource.mute = true;
        }

    }
}
