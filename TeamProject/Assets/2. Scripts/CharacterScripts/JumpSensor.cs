using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSensor : MonoBehaviour
{
    CharacterManager characterManager;
    private void Start()
    {
        characterManager = CharacterManager.instance;
    }

    public void JumpStart()
    {
        characterManager.SetIs_Jump(true);
        
    }
}
