/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Pivot : MonoBehaviour
{
    private Transform aimTransform;

    void Awake()
    {
        aimTransform = transform.Find("Arm");

    }
    void Update()
    {
        Vector3 mousePosition = UtilsClass.GetMouseWorldPosition();
        
        Vector3 aimDirection = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0, 0, angle);
    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Pivot : MonoBehaviour
{
 
    
 
 
    private void FixedUpdate()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 gunPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - gunPos.x;
        mousePos.y = mousePos.y - gunPos.y;
        float gunAngle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        if(Camera.main.ScreenToWorldPoint(Input.mousePosition).x<transform.position.x)
        {
            transform.rotation = Quaternion.Euler(new Vector3(180f, 0f, -gunAngle));
        }
        else{
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, gunAngle));
        }
    }
    
        
        
 
}