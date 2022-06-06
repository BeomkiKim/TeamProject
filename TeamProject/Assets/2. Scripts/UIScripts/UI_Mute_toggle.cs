using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Mute_toggle : MonoBehaviour
{
    // �߰�
    [SerializeField] private bool _toggleBackground, _toggleEffects;

    //�߰�
    public void toggle()
    {
        if (_toggleEffects) UI_Mute.Instance.ToggleEffects();
        if (_toggleBackground) UI_Mute.Instance.ToggleBackgound();
    }
}
