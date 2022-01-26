using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int jumpAbility;
    public int jumpAbilityValue;
    

    

    void Start()
    {   
        
        jumpAbility = jumpAbilityValue;
        rb = GetComponent<Rigidbody2D>();

    }

        void Update()
    {
        //Jumping
        if(isGrounded == true)
        {
            jumpAbility = jumpAbilityValue;
        }
        if(Input.GetKeyDown(KeyCode.Space) && jumpAbility > 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            jumpAbility--;
            
        }
        else if(Input.GetKeyDown(KeyCode.W) && jumpAbility > 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            jumpAbility--;
            
        }
        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = 9f;
        }
        else
            speed = 5f;

        
        
    }
    void FixedUpdate()
    {
        //Ground Checking
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);


        //Inputs And Movement
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if(facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if(facingRight == true && moveInput <0)
        {
            Flip();
        }
        
    }
    //Flipping Character
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);

    }
}
