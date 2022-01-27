using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    Rigidbody2D rb;
    CharacterMovement target;
    Vector2 moveDirection;
    public float moveSpeed;
    public int damage = 20;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<CharacterMovement>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerHealth player = col.GetComponent<PlayerHealth>();
        if(player != null)
        {
            player.TakeDamage(damage);
            
        }
        Destroy(gameObject);

        /*
        if(col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Hit");
            Destroy(gameObject);
        }
        */
    }
    void OnBecameInvisible() {
         Destroy(gameObject);
     }
    
    void Update()
    {
        
    }
}
