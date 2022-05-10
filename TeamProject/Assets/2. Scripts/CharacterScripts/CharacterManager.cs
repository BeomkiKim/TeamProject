using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterManager : MonoBehaviour
{
    [SerializeField]
    private GameObject character;
    [SerializeField]
    private GameObject swordRange;

    private Rigidbody2D character_Rb;

    public Animator character_Animator;

    float jumpPower = 25f;
    float rushSpeed = 5f;
    float add_RushSpeed = 0.05f; //초마다 증가 
    float hurtSpeed;

    Vector2 accerlation = new Vector2(0,0);
    Vector2 lastVelocity = new Vector2(0, 0);
    bool is_Ground = true;
    bool is_Jump = false;
    bool is_Hurt;
    bool is_HurtSpeed = false;

    private static CharacterManager _instance;

    public static CharacterManager instance
    {
        get
        {
            if(!_instance)
            {
                _instance = FindObjectOfType(typeof(CharacterManager)) as CharacterManager;

                if (_instance == null)
                    Debug.Log("no Singleton obj");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }

        else if(_instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        character_Animator = character.GetComponent<Animator>();
        character_Rb = character.GetComponent<Rigidbody2D>();
        InvokeRepeating("IncreaseSpeed", 1f, 1f);
    }

    private void Update()
    {
        AttackEnding();
        OnJumpInGround();
        HurtEnding();
        Rushdeceleration();
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

    public void HurtEnding()
    {
        if (character_Animator.GetCurrentAnimatorStateInfo(0).IsName("HeroKnight_Hurt"))
        {
            character_Animator.SetBool("IsHurt", false);
        }
    }

    public void onButtonDown_Jump()
    {
        
        if (is_Ground == true)
        {
            Debug.Log("Jump");
            character_Rb.velocity = new Vector2(character_Rb.velocity.x, jumpPower);
            character_Animator.SetBool("IsJumpUp", true);
            is_Ground = false;
        }
    }

    void OnJumpInGround()
    {

        if(is_Ground ==true && character_Animator.GetBool("IsJumpUp") == true && is_Jump==true)
        {
            Debug.Log("Down");
            character_Animator.SetBool("IsJumpUp", false);
            is_Jump = false;
        }

    }

    void IncreaseSpeed()
    {
        rushSpeed += add_RushSpeed;
    }

    void Increase_HurtSpeed()
    {
        rushSpeed += hurtSpeed/2;
    }

    public void Character_Rush()
    {
        character_Rb.velocity = new Vector3(rushSpeed, character_Rb.velocity.y, 0);
    }

    void Rushdeceleration()
    {
        if (is_Hurt == false)
            return;

        CancelInvoke("IncreaseSpeed");

        if(is_HurtSpeed==false)
        { 
            InvokeRepeating("Increase_HurtSpeed", 0.001f, 0.25f);
            is_HurtSpeed = true;
        }

        if(rushSpeed >= hurtSpeed * 2)
        {
            is_Hurt = false;
            is_HurtSpeed = false;
            CancelInvoke("Increase_HurtSpeed");
            InvokeRepeating("IncreaseSpeed", 1f, 1f);
        }

    }

    public bool GetIs_Ground()
    {
        return is_Ground;
    }

    public bool GetIs_Jump()
    {
        return is_Jump;
    }

    public float GetRushSpeed()
    {
        return rushSpeed;
    }

    public bool GetIs_Hurt()
    {
        return is_Hurt;
    }

    public float Get_Hurtspeed()
    {
        return hurtSpeed;
    }

    public void SetIs_Ground(bool isGround)
    {
        is_Ground = isGround;
    }

    public void SetIs_Jump(bool isJump)
    {
        is_Jump = isJump;
    }

    public void SetRushSpeed(float speed)
    {
        rushSpeed = speed;
    }

    public void SetIsHurt(bool isHurting)
    {
        is_Hurt = isHurting;
    }

    public void SetHurtSpeed(float speed)
    {
        hurtSpeed = speed;
    }
    
}
