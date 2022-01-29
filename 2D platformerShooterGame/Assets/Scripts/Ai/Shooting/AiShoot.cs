using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiShoot : MonoBehaviour
{
    public Transform gun;
    Vector2 direction;
    public GameObject player;
    public GameObject bullet;
    public Transform shootPoint;
    public float bulletSpeed;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 playerPos = new Vector3(player.transform.position.x, player.transform.position.y, 0f);
        direction = playerPos - (Vector3)gun.position;
        Shoot();
    }
    void Shoot()
    {
        GameObject bulletIns = Instantiate(bullet, shootPoint.position, shootPoint.rotation);
        bulletIns.GetComponent<Rigidbody2D>().AddForce(bulletIns.transform.right * bulletSpeed);
    }
    
}
