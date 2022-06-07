using System;
using UnityEngine;
using UnityEngine.UI;

public class AudioManagerTutorial : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectPref = "SoundEffectPref";

    /*�߰�*/
    private static readonly string BackgroundMutePref = "BackgroundMutePref";
    private static readonly string SoundEffectMutePref = "SoundEffectMutePref";


    private int firstPlayInt;
    public Slider backgroundSlider, soundEffectsSlider;
    private float backgroundFloat, soundEffectsFloat;
    public AudioSource[] backgroundAudio;
    public AudioSource[] soundEffectAudio;

    /*�߰�*/
    public Toggle backgroundToggle, soundEffectsToggle;
    private float backgroundInt, soundEffectsInt;

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

            //�߰�
            backgroundInt = 1;
            soundEffectsInt = 1;
            backgroundToggle.isOn = Convert.ToBoolean(backgroundInt);
            soundEffectsToggle.isOn = Convert.ToBoolean(soundEffectsInt);
            PlayerPrefs.SetFloat(BackgroundMutePref, backgroundInt);
            PlayerPrefs.SetFloat(SoundEffectMutePref, soundEffectsInt);

        }
        else
        {
          backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
          backgroundSlider.value = backgroundFloat;
          soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectPref);
          soundEffectsSlider.value = soundEffectsFloat;

            //�߰�
          backgroundInt = PlayerPrefs.GetFloat(BackgroundMutePref);
          backgroundToggle.isOn = Convert.ToBoolean(backgroundInt);
          soundEffectsInt = PlayerPrefs.GetFloat(SoundEffectMutePref);
          soundEffectsToggle.isOn = Convert.ToBoolean(soundEffectsInt);
        }
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(BackgroundPref, backgroundSlider.value);
        PlayerPrefs.SetFloat(SoundEffectPref, soundEffectsSlider.value);

        //�߰�
        PlayerPrefs.SetFloat(BackgroundMutePref, Convert.ToSingle(backgroundToggle.isOn));
        PlayerPrefs.SetFloat(SoundEffectMutePref, Convert.ToSingle(soundEffectsToggle.isOn));
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
            backgroundAudio[i].mute = backgroundToggle.isOn;
        }

        for(int j = 0; j<soundEffectAudio.Length; j++)
        {
            soundEffectAudio[j].volume = soundEffectsSlider.value;
            soundEffectAudio[j].mute = soundEffectsToggle.isOn;
        }
    }
}
