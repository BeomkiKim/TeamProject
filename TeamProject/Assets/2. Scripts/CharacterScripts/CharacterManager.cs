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

    float jumpPower = 20f;
    float rushSpeed = 100f;

    Vector2 accerlation = new Vector2(0,0);
    Vector2 lastVelocity = new Vector2(0, 0);
    bool is_Ground = true;

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
    }

    private void Update()
    {
        AttackEnding();
    }

    private void FixedUpdate()
    {
        Character_Rush();
        OnJumpInGround();
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
        
        if (is_Ground == true)
        {
            Debug.Log("Jump");
            character_Rb.velocity = new Vector2(character_Rb.velocity.x, jumpPower);
            character_Animator.SetBool("IsJumpUp", true);
        }
    }

    void OnJumpInGround()
    {

        if(is_Ground ==true && character_Animator.GetBool("IsJumpUp") == true)
        {
            character_Animator.SetBool("IsJumpUp", false);
        }

        


    }

    public void Character_Rush()
    {
        character_Rb.velocity = new Vector3(rushSpeed*Time.deltaTime, character_Rb.velocity.y, 0);
    }

    public bool GetIs_Ground()
    {
        return is_Ground;
    }

    public void SetIs_Ground(bool isGround)
    {
        is_Ground = isGround;
    }
    
}
