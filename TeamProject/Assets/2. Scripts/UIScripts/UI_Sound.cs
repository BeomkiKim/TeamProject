using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class UI_Sound : MonoBehaviour
{
    public Text message;
    public Text result;
    public Slider slider;
    public Toggle toggle;

    private int min = 0;
    private int max = 100;

    void Start()
    {
        SetFunction_UI();
    }

    void Update()
    {
        
    }

    private void SetFunction_UI()
    {
        //Reset
        ResetFunction_UI();

        toggle.onValueChanged.AddListener(Function_Toggle);
        slider.onValueChanged.AddListener(Function_Slider);

    }

    private void Function_Toggle(bool _bool)
    {
        message.text = "Toggle Click!\n" + _bool;
        Debug.Log("Toggle Click!\n" + _bool);
    }
    private void Function_Slider(float _value)
    {
        message.text = _value.ToString();
        Debug.Log("Slider Dragging!\n" + _value);
    }

    private void ResetFunction_UI()
    {
        toggle.onValueChanged.RemoveAllListeners();
        slider.onValueChanged.RemoveAllListeners();
        slider.maxValue = max;
        slider.minValue = min;
        slider.wholeNumbers = true;
    }

}
