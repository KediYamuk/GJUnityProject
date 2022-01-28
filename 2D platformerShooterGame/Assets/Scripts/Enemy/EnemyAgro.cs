using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAgro : MonoBehaviour
{
    [SerializeField]
    Transform player;
    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;
    Rigidbody2D rb;
    [SerializeField]
    private bool flipped = false;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);

        if(distToPlayer < agroRange)
        {
            //Chase
            ChasePlayer();
        }
        else
        {
            //StopChase
            StopChase();
        }
    }
    void ChasePlayer()
    {
        if(transform.position.x < player.position.x)
        {
            //Enemy is to the left side of the player, move right
            if (flipped == true)
            {
                FlipBack();
            }
            rb.velocity = new Vector2(moveSpeed, 0);

        }
        else if(transform.position.x > player.position.x)
        {        
            if (flipped == false)
            {
                Flip();
            }
            rb.velocity = new Vector2(moveSpeed, 0);
        }
    }
    void StopChase()
    {
        rb.velocity = new Vector2(0, 0);
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

    