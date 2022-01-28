using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMove : MonoBehaviour
{
    public int speed;
    public float time = 0;
    void Update()
    {
        if (time == 0)
        {
            
        }
        
    }

    void MoveUp()
    {
        time += 1;
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
}
