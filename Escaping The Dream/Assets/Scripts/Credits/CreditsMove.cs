using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMove : MonoBehaviour
{
    public int speed;
    public float time;
    void Update()
    {
        MoveUp();
    }
      
    void MoveUp()
    {
        if (time > 99)
        {
            time -= Time.deltaTime;
        }
        else
        {
        time -= Time.deltaTime;
        transform.Translate(Vector2.up * Time.deltaTime * speed);
        }
    }
}
