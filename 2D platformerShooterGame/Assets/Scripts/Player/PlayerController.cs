using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float movementForce;
    public float jumpForce;
    private bool facingRight = true;
    private bool isGrounded = false;
    public Transform groundCheck;
    public float checkRadius;
    private int jumpAbility;
    public int jumpAbilityValue;
    
    
    [Space(5)]
    
    public LayerMask whatIsGround;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {

        Movement();
        
        Sprint();
    }

    
    void Update()
    {
        Jump();
    }

    private void Movement()
    {
        float xDir = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(xDir * (movementForce * Time.deltaTime), rb.velocity.y);
        if(facingRight == false && xDir > 0)
        {
            Flip();
        }
        else if(facingRight == true && xDir <0)
        {
            Flip();
        }

    }
    private void Jump()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        
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
    }
    /*
    private bool isGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, raycastDistance, whatIsGround);
        return hit.collider != null;


    }
    */
    private void Sprint()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            movementForce = 1200f;
        }
        else
            movementForce = 750f;

        if(Input.GetKey(KeyCode.C))
        {
            Time.timeScale = 0.3f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
            
        }
        else if(Input.GetKey(KeyCode.V))
        {
            Time.timeScale = 1;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }
    }
    
    private void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
