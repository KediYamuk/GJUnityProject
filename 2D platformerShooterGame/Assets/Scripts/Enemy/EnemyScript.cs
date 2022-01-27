using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int health = 100;
    public bool enemyIsDead = false;
    public GameObject deathEffect;
    public GameObject enemy;
    


    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
        
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        enemy.SetActive(false);
        enemyIsDead = true;
        
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
