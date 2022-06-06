using System;
using UnityEngine;
using UnityEngine.UI;

public class AudioManagerTutorial : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectPref = "SoundEffectPref";

    private int firstPlayInt;
    public Slider backgroundSlider, soundEffectsSlider;
    private float backgroundFloat, soundEffectsFloat;
    public AudioSource[] backgroundAudio;
    public AudioSource[] soundEffectAudio;

    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if(firstPlayInt == 0)
        {
            backgroundFloat = 0.5f;
            soundEffectsFloat = 0.75f;
            backgroundSlider.value = backgroundFloat;
            soundEffectsSlider.value = soundEffectsFloat;
            PlayerPrefs.SetFloat(BackgroundPref, backgroundFloat);
            PlayerPrefs.SetFloat(SoundEffectPref, soundEffectsFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);

        }
        else
        {
          backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
          backgroundSlider.value = backgroundFloat;
          soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectPref);
          soundEffectsSlider.value = soundEffectsFloat;
        }
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(BackgroundPref, backgroundSlider.value);
        PlayerPrefs.SetFloat(SoundEffectPref, soundEffectsSlider.value);
    }

    void OnApplicationFocus(bool infocus)
    {
        if (!infocus)
        {
            SaveSoundSettings();
        }
    }

    public void UpdateSound()
    {

        for (int i = 0; i<backgroundAudio.Length; i++)
        {
            backgroundAudio[i].volume = backgroundSlider.value;
        }

        for(int j = 0; j<soundEffectAudio.Length; j++)
        {
            soundEffectAudio[j].volume = soundEffectsSlider.value;
        }
    }
}
