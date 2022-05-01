using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Characterdistance : MonoBehaviour
{
    GameObject user;
    GameObject distance;

    void Start()
    {
        this.user = GameObject.Find("user");
        this.distance = GameObject.Find("Characterdistance");
    }

    void Update()
    {
        float length = this.user.transform.position.x;
        this.distance.GetComponent<Text>().text = "이동한 거리: " + length.ToString("F2") + "m";
    }
}
