using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiShoot : MonoBehaviour
{
    public Transform gun;
    Vector2 direction;
    public GameObject player;
    public Transform playerPosition;
    
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 500f;
    private float shootingTime;
    [SerializeField]
    float shootRange = 31f;
    void Start()
    {
        
    }

    
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, playerPosition.position);
        Vector3 playerPos = new Vector3(player.transform.position.x, player.transform.position.y, 0f);
        direction = playerPos - (Vector3)gun.position;
        if(distToPlayer < shootRange)
        {
            Shoot();
            
        }
        else
        {
            //Do Nothing
        }
        
    }
    void Shoot()
    {
        if (Time.time > shootingTime)
        {
        
        shootingTime = Time.time + fireRate / 1000;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
    
    
}
