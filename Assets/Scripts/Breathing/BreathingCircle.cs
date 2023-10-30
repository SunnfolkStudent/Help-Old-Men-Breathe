using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class BreathingCircle : MonoBehaviour
{

    public float rotateSpeed;

    public Transform rotatePoint;
    
    private Vector3 zAxis = new Vector3(0, 0, 1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate around the central point
        transform.RotateAround(rotatePoint.position, zAxis, -rotateSpeed * Time.deltaTime);
    }
}
