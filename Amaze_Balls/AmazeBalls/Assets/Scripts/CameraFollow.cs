using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  
    public Vector3 offset;    
    public float followSpeed = 5.0f;  
    public float rotationSpeed = 2.0f;  
    private Vector3 desiredPosition;

    void Update()
    {
        if (target == null)
            return;

       
        desiredPosition = target.position + offset;

        
        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);
    }
}
