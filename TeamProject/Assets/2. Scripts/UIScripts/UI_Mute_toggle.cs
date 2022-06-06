using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Mute_toggle : MonoBehaviour
{
    // 추가
    [SerializeField] private bool _toggleBackground, _toggleEffects;

    //추가
    public void toggle()
    {
        if (_toggleEffects) UI_Mute.Instance.ToggleEffects();
        if (_toggleBackground) UI_Mute.Instance.ToggleBackgound();
    }
}
