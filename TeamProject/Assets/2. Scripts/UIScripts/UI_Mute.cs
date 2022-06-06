using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class UI_Mute : MonoBehaviour
{
    public static UI_Mute Instance;

    [SerializeField] private AudioSource[] _backgroundSource, _effectsSource;
    

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        for (int j = 0; j < _effectsSource.Length; j++)
        {
            _effectsSource[j].PlayOneShot(clip);
        }
    }

    public void ToggleEffects()
    {
        for (int i = 0; i < _effectsSource.Length; i++) 
        {
            _effectsSource[i].mute = !_effectsSource[i].mute;
        }
    }

    public void ToggleBackgound()
    {
        for (int j = 0; j < _effectsSource.Length; j++)
        {
            _backgroundSource[j].mute = !_backgroundSource[j].mute;
        }
    }

}
