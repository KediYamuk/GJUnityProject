using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlip : MonoBehaviour
{
    

    private bool facingRight = true;
    public Transform player;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        
        if(facingRight == false)
        {
            Flip();
        }
        else if(facingRight == true)
        {
            Flip();
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
