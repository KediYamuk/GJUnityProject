using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    #region Main Menu/Options Menu(from main)
    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(sceneName:"SampleScene");
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene(sceneName:"Settings");
    }

    public void BackMain()
    {
        SceneManager.LoadScene(sceneName:"StartMenu");
    }

    #endregion

    
    #region Options Menu(from pause)
    
    public void OpenSettingsP()
    {
        SceneManager.LoadScene(sceneName:"SampleScene")
    }

    #endregion
}
