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

    private BoxCollider2D character_collider2D;

    public Animator character_Animator;

    float jumpPower = 25f;
    public float rushSpeed = 5f;
    float add_RushSpeed = 0.05f; //초마다 증가 
    public float hurtSpeed;
    public float presentRushSpeed;
    public float usual_ColliderSizeY;
    public float usual_ColliderOffsetY;

    Vector2 accerlation = new Vector2(0,0);
    Vector2 lastVelocity = new Vector2(0, 0);
    bool is_Ground = true;
    bool is_Jump = false;
    public bool is_Hurt;
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
        character_collider2D = character.GetComponent<BoxCollider2D>();
        usual_ColliderSizeY = character_collider2D.size.y;
        usual_ColliderOffsetY = character_collider2D.offset.y;
        InvokeRepeating("IncreaseSpeed", 1f, 1f);
    }

    private void Update()
    {
        AttackEnding();
        OnJumpInGround();
        HurtEnding();
        Rushdeceleration();
        Falling_Death();
    }

    private void FixedUpdate()
    {
        Character_Rush();
    }

    public void OnPointerDown_Slide()
    {
        if (GameOverScript.instance.is_gameOver == true)
            return;

        character_Animator.SetBool("IsSlide", true);
        character_collider2D.size = new Vector2(character_collider2D.size.x, usual_ColliderSizeY/2);
        character_collider2D.offset = new Vector2(character_collider2D.offset.x, usual_ColliderOffsetY/2);
        
    }

    public void OnPointerUp_Slide()
    {
        if (GameOverScript.instance.is_gameOver == true)
            return;

        character_Animator.SetBool("IsSlide", false);
        character_collider2D.size = new Vector2(character_collider2D.size.x, usual_ColliderSizeY);
        character_collider2D.offset = new Vector2(character_collider2D.offset.x, usual_ColliderOffsetY);
    }

    public void onButtonDown_Attack()
    {
        if (GameOverScript.instance.is_gameOver == true)
            return;

        character_Animator.SetBool("IsAttack", true);
    }

    public void AttackEnding()
    {
        if (GameOverScript.instance.is_gameOver == true)
            return;

        if (character_Animator.GetCurrentAnimatorStateInfo(0).IsName("HeroKnight_Attack3"))
        {
            character_Animator.SetBool("IsAttack", false);
        }
    }

    public void HurtEnding()
    {
        if (GameOverScript.instance.is_gameOver == true)
            return;

        if (character_Animator.GetCurrentAnimatorStateInfo(0).IsName("HeroKnight_Hurt"))
        {
            character_Animator.SetBool("IsHurt", false);
        }
    }

    public void onButtonDown_Jump()
    {
        if (GameOverScript.instance.is_gameOver == true)
            return;


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
        if (GameOverScript.instance.is_gameOver == true)
            return;


        if (is_Ground ==true && character_Animator.GetBool("IsJumpUp") == true && is_Jump==true)
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
        rushSpeed += hurtSpeed/3;
    }

    public void Character_Rush()
    {
        if (GameOverScript.instance.is_gameOver == true)
            return;

        character_Rb.velocity = new Vector3(rushSpeed, character_Rb.velocity.y, 0);
    }

    void Rushdeceleration()
    {
        if (GameOverScript.instance.is_gameOver == true)
            return;

        if (is_Hurt == false)
            return;

        if (presentRushSpeed == 0)
            return;

        CancelInvoke("IncreaseSpeed");

        if(is_HurtSpeed==false)
        { 
            InvokeRepeating("Increase_HurtSpeed", 0.001f, 0.25f);
            is_HurtSpeed = true;
        }

        if(rushSpeed >= presentRushSpeed)
        {
            Debug.Log("asdf");
            is_Hurt = false;
            is_HurtSpeed = false;
            CancelInvoke("Increase_HurtSpeed");
            InvokeRepeating("IncreaseSpeed", 1f, 1f);
        }

    }

    void Falling_Death()
    {
        float death_Height = -11f;
        if(character.transform.position.y<death_Height)
        {
            GameOverScript.instance.is_gameOver = true;
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

    public float Get_PresentRushSpeed()
    {
        return presentRushSpeed;
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

    public void SetPrensentRushSpeed(float speed)
    {
        presentRushSpeed = speed;
    }
    
}
