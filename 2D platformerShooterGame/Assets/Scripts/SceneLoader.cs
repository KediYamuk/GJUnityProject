using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public int nextSceneLoad;

    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
    
    public void NextLevel()
    {
        SceneManager.LoadScene(nextSceneLoad);

        if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", nextSceneLoad);
        }
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LvSelect()
    {
        SceneManager.LoadScene(sceneName:"LevelSelect");
    }

    public void Lv1()
    {
        SceneManager.LoadScene(sceneName:"Level1");
        Time.timeScale = 1f;
    }

    public void Lv2()
    {
        SceneManager.LoadScene(sceneName:"Level2");
        Time.timeScale = 1f;
    }

    public void Lv3()
    {
        SceneManager.LoadScene(sceneName:"Level3");
        Time.timeScale = 1f;
    }

    public void Lv4()
    {
        SceneManager.LoadScene(sceneName:"Level4");
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

    public void Credits()
    {
        SceneManager.LoadScene(sceneName:"Credits");
    }
}
