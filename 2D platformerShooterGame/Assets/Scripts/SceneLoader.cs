using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReloadGame1()
    {
        SceneManager.LoadScene(sceneName:"Load");
        Invoke("OpenGame", 1);

    }

    public void OpenGame()
    {
        SceneManager.LoadScene(sceneName:"Level1");
        Time.timeScale = 1f;
    }

    public void BackMain()
    {
        SceneManager.LoadScene(sceneName:"StartMenu");
    }
    
    public void OpenSettings()
    {
        SceneManager.LoadScene(sceneName:"Settings");
    }
}
