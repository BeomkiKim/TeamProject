using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScrolling : MonoBehaviour
{
    [SerializeField]
    Transform[] backGrounds = null;
    [SerializeField]
    float speed = 0f;


    float leftPosX = 0f;
    float rightPox = 0f;

    private void Start()
    {
        float length = backGrounds[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        leftPosX = -length;
        rightPox = length * backGrounds.Length;
    }

    private void Update()
    {
        for(int i = 0; i< backGrounds.Length; i++)
        {
            backGrounds[i].position += new Vector3(speed,0,0)*Time.deltaTime;

            if(backGrounds[i].position.x<leftPosX)
            {
                Vector3 selfPos = backGrounds[i].position;
                selfPos.Set(selfPos.x + rightPox, selfPos.y, selfPos.z);
                backGrounds[i].position = selfPos;
            }

        
        }
    }
}
