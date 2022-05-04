using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Monster")
        {
            //hurt 애니메이션 출력
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Monster")
        {
            //hurt 애니메이션 출력
        }
    }
}
