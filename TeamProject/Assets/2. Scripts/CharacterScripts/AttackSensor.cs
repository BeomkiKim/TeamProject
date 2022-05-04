using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSensor : MonoBehaviour
{
    public GameObject swordRange;
    public void Attack_Start()
    {
        swordRange.SetActive(true);
    }

    public void Attack_End()
    {
        swordRange.SetActive(false);
    }
}
