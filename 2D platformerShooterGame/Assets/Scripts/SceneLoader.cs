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

}
