using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceText_Scirpt : MonoBehaviour
{
    [SerializeField]
    private GameObject character;

    [SerializeField]
    private Text distance_Text;


    public void FixedUpdate()
    {
        DistanceText_Renwal();
    }

    public void DistanceText_Renwal()
    {
        float distance_Shame = character.transform.position.x+4f;
        int distance_Shame_Int = (int)distance_Shame;
        distance_Text.text = distance_Shame_Int.ToString();
    }
}
