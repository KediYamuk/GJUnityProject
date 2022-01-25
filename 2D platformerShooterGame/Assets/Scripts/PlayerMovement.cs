using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed;
    public float JumpForce;

    private Rigidbody2D rb;
    private bool FacingRight = true;
    private bool IsJumping = false;
    private float MovementDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        GetInput();
        FlipCharacter();
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }
    
    private void MoveCharacter()
    {
        rb.velocity = new Vector2(MovementDirection * MovementSpeed, rb.velocity.y);
        if(IsJumping)
        {
            rb.AddForce(new Vector2(0f, JumpForce));
        }
        IsJumping = false;
    }

    private void FlipCharacter()
    {
        //Direction
        if (MovementDirection > 0 && !FacingRight)
        {
            FlipCharacterDirection();
        }
        else if (MovementDirection < 0 && FacingRight)
        {
            FlipCharacterDirection();
        }
    }

    private void GetInput()
    {
        MovementDirection = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump"))
        {
            IsJumping = true;
        }
    }

    private void FlipCharacterDirection()
    {
        FacingRight = !FacingRight;
        transform.Rotate(0f, 180f, 0f);

    }
}
