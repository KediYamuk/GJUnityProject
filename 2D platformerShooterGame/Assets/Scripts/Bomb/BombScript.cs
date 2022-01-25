using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{

    public float fieldOfImpact;
    public float force;
    public LayerMask layerToHit;
    public GameObject explosionEffect;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            explode();
        }

    }

    void explode()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldOfImpact, layerToHit);

        foreach(Collider2D obj in objects)
        {
            Vector2 direction = obj.transform.position - transform.position;

            obj.GetComponent<Rigidbody2D>().AddForce(direction * force);

        }

        GameObject explosionEffectIns = Instantiate(explosionEffect,transform.position,Quaternion.identity);
        Destroy(explosionEffectIns, 10);
        Destroy(gameObject);

    }
}
