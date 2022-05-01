using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceBetweenCharcterAndMonster : MonoBehaviour
{
    GameObject user;
    GameObject ghost;
    GameObject distance;

    void Start()
    {
        this.user = GameObject.Find("user");
        this.ghost = GameObject.Find("ghost");
        this.distance = GameObject.Find("DistanceBetweenCharcterAndMonster");
    }

    void Update()
    {
        float length = this.user.transform.position.x - this.ghost.transform.position.x;
        this.distance.GetComponent<Text>().text = length.ToString("F2") + "m";
    }
}
