using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Target; 
    public Vector3 Offset = new Vector3(0, 5, -10); 
    public float SmoothSpeed = 0.125f; 

    void LateUpdate()
    {
        Vector3 desiredPosition = Target.position + Target.TransformDirection(Offset);

        transform.position = Vector3.Lerp(transform.position, desiredPosition, SmoothSpeed);

        transform.LookAt(Target);
    }
}
