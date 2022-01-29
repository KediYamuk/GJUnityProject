using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRotateAi : MonoBehaviour
{
    public float speed = 300f;
    private Rigidbody2D rb;
    public GameObject player;
    
    
    
    void Awake()
    {
        
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        Vector3 playerPos = new Vector3(player.transform.position.x, player.transform.position.y, 0f);
        Vector3 difference = playerPos - transform.position;
        float rotZ = Mathf.Atan2(difference.x, -difference.y) * Mathf.Rad2Deg;

        rb.MoveRotation(Mathf.LerpAngle(rb.rotation, rotZ, speed * Time.deltaTime));
    }
    
}
