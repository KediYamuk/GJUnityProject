using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenuUI;
    public GameObject settingsUI;
    public static bool isPaused = false;
    public static bool inSettings = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (isPaused && !inSettings)
            {
                Resume();
            } 
            else if (isPaused && inSettings)
            {
            //Do nothing   
            }
            else
            {
                Pause();
            }
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
