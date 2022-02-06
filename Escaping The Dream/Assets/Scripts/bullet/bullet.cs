using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 20;
    public Rigidbody2D rb;
    public float destroyTime = 3f;
    
    void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, destroyTime);
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        AiHealth ai = hitInfo.GetComponent<AiHealth>();
        

        if(ai != null)
        {
            ai.TakeDamage(damage);
            
        }
        Destroy(gameObject);
        
        
        
        
    }
    
    
    void Update()
    {
        
    }
}
