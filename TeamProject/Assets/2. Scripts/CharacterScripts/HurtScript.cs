using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtScript : MonoBehaviour
{
    [SerializeField]
    GameObject character;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hurt");
        if(collision.tag == "Monster") // 몬스터 뿐만이 아닌 다른 것도 적용되긴 해야한다.
        {
            CharacterManager.instance.character_Animator.SetBool("IsHurt", true);
        }
    }

    
    
}
