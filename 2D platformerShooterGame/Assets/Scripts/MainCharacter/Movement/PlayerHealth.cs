using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public int health = 100;
    public GameObject deathEffect;
    public GameObject gameOverOverlay;
    public GameObject player;
    
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
       player.SetActive(false);
       gameOverOverlay.SetActive(true);
       Time.timeScale = 0f;
        
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
