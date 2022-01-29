using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiHealth : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEffect;
    public GameObject gameOverOverlay;
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
       Instantiate(deathEffect,transform.position, Quaternion.identity);
       enemy.SetActive(false);
       gameOverOverlay.SetActive(true);
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
