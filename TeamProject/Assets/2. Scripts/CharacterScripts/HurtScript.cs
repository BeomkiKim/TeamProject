using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtScript : MonoBehaviour
{
    [SerializeField]
    GameObject character;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (CharacterManager.instance.GetIs_Hurt() == true)
            return;

        Debug.Log("Hurt");
        if(collision.tag == "Monster") // ���� �Ӹ��� �ƴ� �ٸ� �͵� ����Ǳ� �ؾ��Ѵ�.
        {
            CharacterManager.instance.character_Animator.SetBool("IsHurt", true);
            CharacterManager.instance.SetPrensentRushSpeed(CharacterManager.instance.GetRushSpeed());
            CharacterManager.instance.SetRushSpeed(CharacterManager.instance.GetRushSpeed() / 2);
            CharacterManager.instance.SetHurtSpeed(CharacterManager.instance.GetRushSpeed() / 2);
            CharacterManager.instance.SetIsHurt(true);
        }


    }

    
    
}
