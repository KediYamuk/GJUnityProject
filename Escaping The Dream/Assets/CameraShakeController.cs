using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeController : MonoBehaviour
{
    private float shakeTimeRemaining, shakePower;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            StartShake(.005f, .2f);
        }
    }
    void LateUpdate()
    {
        if(shakeTimeRemaining > 0)
        {
            shakeTimeRemaining -= Time.deltaTime;

            float xAmount = Random.Range(-1f, 1f) * shakePower;
            

            transform.position += new Vector3(xAmount, 0f, 0f);


        }
    }
    public void StartShake(float length, float power)
    {
        shakeTimeRemaining = length;
        shakePower = power;
    }
}
