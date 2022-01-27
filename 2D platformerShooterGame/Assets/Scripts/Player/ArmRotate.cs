using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRotate : MonoBehaviour
{
    public int isLeftOrRight;
    public float speed = 300f;
    private Rigidbody2D rb;
    public Camera cam;


    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector3 mousePos = new Vector3(cam.ScreenToWorldPoint(Input.mousePosition).x, cam.ScreenToWorldPoint(Input.mousePosition).y, 0f);
        Vector3 difference = mousePos - transform.position;
        float rotationZ = Mathf.Atan2(difference.x, -difference.y) * Mathf.Rad2Deg;

        rb.MoveRotation(Mathf.LerpAngle(rb.rotation, rotationZ, speed * Time.deltaTime));
    }
}
