using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenuUI;
    public GameObject settingsUI;
    public GameObject gameOverOverlay;  
    public static bool isPaused = false;
    public static bool inSettings = false;
    public static bool gameOver = false;

    
    void Start()
    {
        CheckOver();
        CheckPause();
        CheckSettings();
    }
    void Update()
    {
        CheckOver();
        CheckPause();
        CheckSettings();
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (isPaused && !inSettings && !gameOver)
            {
                Resume();
            } 
            else if (isPaused && inSettings && gameOver)
            {
            //Do nothing   
            }
            else if (!isPaused && !gameOver && !inSettings)
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
        else if (!gameOverOverlay.activeSelf)
        {
            gameOver = false;
        }  
    }

    private void CheckPause()
    {
        if (!pauseMenuUI.activeSelf)
        {
            isPaused = false;
        }
        else if (pauseMenuUI.activeSelf)
        {
            isPaused = true;
        }
    }

    private void CheckSettings()
    {
        if(!settingsUI.activeSelf)
        {
            inSettings = false;
        }
        else if (settingsUI.activeSelf)
        {
            inSettings = true;
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
