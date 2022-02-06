using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{   
    // Start is called before the first frame update
    
    public Transform playerCam;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerCam.position.x, playerCam.position.y, transform.position.z);
    }
}