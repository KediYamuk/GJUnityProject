using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformScript : MonoBehaviour
{
    public float speed; //Speed of the platform
    public int startingPoint; //Starting index
    public Transform[] points; //Transform points
    private int i; // index of the array
    void Start()
    {
        transform.position = points[startingPoint].position; //Setting the position of the platform to the position of one of the points

    }

    
    void Update()
    {   
        // Checking the distance of the platform and the point
        if(Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++; // Increase the index
            if(i == points.Length) // Check if the platform was on the last point after the index increase
            {
                i = 0; // Reset the index
            }
        }

        // Moving the platform to the point position with the index "i"
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(transform.position.y<collision.transform.position.y-0.8f)
        {
            collision.transform.SetParent(transform);
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
