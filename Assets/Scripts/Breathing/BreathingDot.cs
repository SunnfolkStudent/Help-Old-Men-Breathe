using System;
using UnityEngine;

public class BreathingDot : MonoBehaviour
{

    public float rotateSpeed;
    [HideInInspector]public float angle;
    
    public Transform rotatePoint;
    private Vector3 zAxis = new Vector3(0, 0, 1);
    
    
    public bool printDotAngle = false;

    void Update()
    {
        //rotate around the central point
        transform.RotateAround(rotatePoint.position, zAxis, -rotateSpeed * Time.deltaTime);
        angle += Math.Abs(-rotateSpeed * Time.deltaTime);
        
        if (angle >= 360) { angle -= 360; }
        
        
        if (printDotAngle) { Debug.Log("Breathing Dot Angle: " + angle); }
    }
    
}