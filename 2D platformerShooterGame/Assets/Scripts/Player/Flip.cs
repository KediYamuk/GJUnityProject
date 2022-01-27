using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Flip : MonoBehaviour
{
    private Rigidbody2D rb;
    
    private bool facingRight = true;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        float xDir = Input.GetAxisRaw("Horizontal");
        
        if(facingRight == false && xDir > 0)
        {
            Flipping();
        }
        else if(facingRight == true && xDir <0)
        {
            Flipping();
        }
    }
    
    void Flipping()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
    
}
