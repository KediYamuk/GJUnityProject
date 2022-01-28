using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public int health;
    private bool gameOver = false;
    [SerializeField]
    private GameObject gameOverPanel;

    void Start()
    {
        health = 100;
    }
    
    void Update()
    {
        CheckGameOver();
        if (gameOver == false)
        {
            health = GameObject.Find("Player").GetComponent<PlayerHealth>().health;
            SetHealth();
        }
        else if (gameOver == true)
        {
            health = 0;
            SetHealth();
        }
    }
    
    public void CheckGameOver()
    {
        if (gameOverPanel.activeSelf)
        {
            gameOver = true;
        }
        else
        {
            gameOver = false;
        }
    }
    
    public void SetHealth()
    {
        healthBar.value = health;
    }
}
