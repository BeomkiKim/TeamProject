using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterManager : MonoBehaviour
{
    [SerializeField]
    private GameObject character;

    private Rigidbody2D character_Rb;

    private Animator character_Animator;

    float jumpPower = 100f;
    float rushSpeed = 100f;

    private void Start()
    {
        character_Animator = character.GetComponent<Animator>();
        character_Rb = character.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        AttackEnding();
    }

    private void FixedUpdate()
    {
        Character_Rush();
    }

    public void OnPointerDown_Slide()
    {
        character_Animator.SetBool("IsSlide", true);
        
    }

    public void OnPointerUp_Slide()
    { 
        character_Animator.SetBool("IsSlide", false);
    }

    public void onButtonDown_Attack()
    {
        character_Animator.SetBool("IsAttack", true);
    }

    public void AttackEnding()
    {
        if (character_Animator.GetCurrentAnimatorStateInfo(0).IsName("HeroKnight_Attack3"))
        {
            character_Animator.SetBool("IsAttack", false);
        }
    }

    public void onButtonDown_Jump()
    {
        //그라운드 체크 기능
        character_Animator.SetBool("IsJumpUp", true);
    }

    public void Character_Rush()
    {
        character_Rb.velocity = new Vector3(rushSpeed*Time.deltaTime, 0, 0);
    }

    
    
}
