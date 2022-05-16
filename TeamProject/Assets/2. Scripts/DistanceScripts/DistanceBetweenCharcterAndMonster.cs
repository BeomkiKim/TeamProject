using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceBetweenCharcterAndMonster : MonoBehaviour
{
    GameObject user;
    GameObject ghost;
    

    void Start()
    {
        this.user = GameObject.FindGameObjectWithTag("Player");
        this.ghost = GameObject.FindGameObjectWithTag("Ghost");
    }

    void Update()
    {
        float length = this.user.transform.position.x - this.ghost.transform.position.x;
        float lenght_Int = (int)length;
        this.GetComponent<Text>().text = lenght_Int.ToString() + "m";
    }
}
