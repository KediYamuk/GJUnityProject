using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThanksQuit : MonoBehaviour
{
    void OnBecameInvisible() 
    {
        Debug.Log("Quit.");
        Application.Quit();
    }
}
