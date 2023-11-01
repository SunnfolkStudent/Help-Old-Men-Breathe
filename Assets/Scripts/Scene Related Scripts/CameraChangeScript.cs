using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraChangeScript : MonoBehaviour
{

    public CinemachineVirtualCamera vcam;
    
    private float timer;
    private bool timerDone;
    private bool timerOn = false;
    
    void Start()
    {
        
    }


    void Update()
    {
        if (timerOn)
        {
            timer += Time.deltaTime;
            if (timer > 1.5f && !timerDone)
            {
                
            }
        }
    }
}
