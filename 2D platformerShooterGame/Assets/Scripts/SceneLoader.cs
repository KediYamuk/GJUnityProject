using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(sceneName:"SampleScene");
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene(sceneName:"Settings");
    }
}
