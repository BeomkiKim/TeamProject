using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundCtrl : MonoBehaviour
{
    public GameObject[] stageBackGround;

    [Header("플레이어거리")]
    public float distance = 0f;

    [Header("2라운드거리")]
    public float secondDistance;

    [Header("3라운드거리")]
    public float thirdDistance;


    void Update()
    {
        distance += Time.deltaTime;

        if (distance >= secondDistance && distance < thirdDistance)
        {
            stageBackGround[0].SetActive(false);
            stageBackGround[1].SetActive(true);
        }
        else if (distance >= thirdDistance)
        {
            stageBackGround[1].SetActive(false);
            stageBackGround[2].SetActive(true);
        }
    }
}
