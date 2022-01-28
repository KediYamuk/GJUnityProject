using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int health = 100;
    [HideInInspector]
    public bool enemyIsDead = false;
    public GameObject deathEffect;
    [HideInInspector]
    public GameObject enemy;
    
    void Start()
    {
        enemy = GameObject.Find("Enemy");
    }

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
}
