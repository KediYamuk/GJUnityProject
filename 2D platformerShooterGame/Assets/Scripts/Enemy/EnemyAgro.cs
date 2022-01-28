using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAgro : MonoBehaviour
{
    /*[SerializeField]
    Transform player;
    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;
    Rigidbody2D rb;
    private bool facingRight = true;
    private int flipCount = 1;
    

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
            rb.velocity = new Vector2(moveSpeed, 0);

        }
        else if(transform.position.x > player.position.x)
        {
            Flip();
            rb.velocity = new Vector2(moveSpeed, 0);
        }
    }
    void StopChase()
    {
        rb.velocity = new Vector2(0, 0);
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }*/
    public Transform target; //where we want to shoot(player? mouse?)
    public Transform weaponMuzzle; //The empty game object which will be our weapon muzzle to shoot from
    public GameObject bullet; //Your set-up prefab
    
    public float shootingPower = 20f; //force of projection
 
 
    
 
    public int health = 100;
    public GameObject deathEffect;
 
    private void Update()
    {
        Fire(); //Constantly fire
    }
 
    private void Fire()
    {
        
        
         //set the local var. to current time of shooting
        Vector2 myPos = new Vector2(weaponMuzzle.position.x, weaponMuzzle.position.y); //our curr position is where our muzzle points
        GameObject projectile = Instantiate(bullet, myPos, Quaternion.identity); //create our bullet
        Vector2 direction = myPos - (Vector2)target.position; //get the direction to the target
         //shoot the bullet
        
    }
 
    public void TakeDamage(int damage)
    {
        health -= damage;
 
        if (health <= 0)
        {
            Die();
        }
    }
 
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

    