using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlip : MonoBehaviour
{
    

    private bool flipped = false;
    public Transform player;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        FlipEnemy();
    }
    
    void FlipEnemy()
    {
        if(transform.position.x < player.position.x)
        {
            //Enemy is to the left side of the player, move right
            if (flipped == true)
            {
                FlipBack();
            }

        }
        else if(transform.position.x > player.position.x)
        {        
            if (flipped == false)
            {
                Flip();
            }
        }
    }
    
    void Flip()
    {
        flipped = true;
        transform.Rotate(0f, 180f, 0f);
    }

    void FlipBack()
    {
        flipped = false;
        transform.Rotate(0f, 180f, 0f);
    }
}
