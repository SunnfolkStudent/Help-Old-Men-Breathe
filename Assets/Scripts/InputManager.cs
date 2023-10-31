using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputManager : MonoBehaviour
{

    public bool mouseHeld = false;
    public bool mouseHeldLastFrame;

    void Update()
    {
        //check if mouse was pressed last frame
        mouseHeldLastFrame = Input.GetMouseButtonDown(0);
        
        //check if left-click is held
        mouseHeld = Input.GetMouseButton(0);
    }
}
