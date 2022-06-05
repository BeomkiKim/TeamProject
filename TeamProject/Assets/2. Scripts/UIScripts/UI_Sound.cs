using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class UI_Sound : MonoBehaviour
{
    //[SerializeField] Slider BGMSlider;
    //[SerializeField] Slider SoundEffectSlider;

    AudioSource sound;
    public AudioMixer mixer;

    void Start()
    {
        sound = GetComponent<AudioSource>();

        //if (!PlayerPrefs.HasKey("BGM"))
        //{
        //    PlayerPrefs.SetFloat("BGM", 1);
        //    Load();
        //}
        //else if (!PlayerPrefs.HasKey("SoundEffect"))
        //{
        //    PlayerPrefs.SetFloat("SoundEffect", 1);
        //    Load();
        //}
        //else
        //{
        //    Load();
        //}

    }

    public void BGMSetLevel(float sliderVal)
    {
        mixer.SetFloat("BGM", Mathf.Log10(sliderVal) * 20);
        //Save();
    }

    public void SoundEffectSetLevel(float sliderVal)
    {
        mixer.SetFloat("SoundEffect", Mathf.Log10(sliderVal) * 20);
        //Save();
    }

    //private void Load()
    //{
    //    BGMSlider.value = PlayerPrefs.GetFloat("BGM");
    //    SoundEffectSlider.value = PlayerPrefs.GetFloat("SoundEffect");
    //}

    //private void Save()
    //{
    //    PlayerPrefs.SetFloat("BGM", BGMSlider.value);
    //    PlayerPrefs.SetFloat("SoundEffect", SoundEffectSlider.value);

    //}

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
