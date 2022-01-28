using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenuUI;
    public GameObject settingsUI;
    [HideInInspector]
    public GameObject gameOverOverlay;
    public static bool isPaused = false;
    public static bool inSettings = false;
    public static bool gameOver = false;

    // Update is called once per frame
    void Start()
    {
        gameOverOverlay = GameObject.Find("GameOverPanel");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            CheckOver();
            if (isPaused & !inSettings & !gameOver)
            {
                Resume();
            } 
            else if (isPaused & inSettings & gameOver)
            {
            //Do nothing   
            }
            else if (!gameOver & !inSettings)
            {
                Pause();
            }
        }
    }
    
    private void CheckOver()
    {
        if (gameOverOverlay.activeSelf)
        {
            gameOver = true;
        }
    }
    
    
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Settings()
    {
        settingsUI.SetActive(true);
        inSettings = true;
        pauseMenuUI.SetActive(false);
    }

    public void SettingsOff()
    {
        settingsUI.SetActive(false);
        inSettings = false;    
        pauseMenuUI.SetActive(true);
    }

}
