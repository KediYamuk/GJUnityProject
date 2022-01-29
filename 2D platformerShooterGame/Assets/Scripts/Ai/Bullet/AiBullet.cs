using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiBullet : MonoBehaviour
{
    
    public float speed = 20f;
    public int damage = 20;
    public Rigidbody2D rb;
    
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth player = hitInfo.GetComponent<PlayerHealth>();
        

        if(player != null)
        {
            player.TakeDamage(damage);
            
        }
        Destroy(gameObject);
        
        
        
        
    }
    void OnBecameInvisible() {
        Destroy(gameObject);
     }
    
    void Update()
    {
        
    }
}

