using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public int health = 100;
    public bool playerIsDead = false;
    public GameObject deathEffect;
    public GameObject player;

    public GameObject gameOverScreen;
    
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
       playerIsDead = true;  
       gameOverScreen.SetActive(true);
       Time.timeScale = 0f;
    }
}
