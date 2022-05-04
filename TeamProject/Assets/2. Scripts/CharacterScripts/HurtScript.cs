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
        if(collision.tag == "Monster") // ���� �Ӹ��� �ƴ� �ٸ� �͵� ����Ǳ� �ؾ��Ѵ�.
        {
            CharacterManager.instance.character_Animator.SetBool("IsHurt", true);
        }
    }

    
    
}
