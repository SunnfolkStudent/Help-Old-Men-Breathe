using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputManager : MonoBehaviour
{

    public bool mouseHeld = false;
    public bool mouseHeldLastFrame;

    public bool oneKeyHeld;
    public bool oneKeyPressed;
    public bool twoKeyHeld;
    public bool twoKeyPressed;

    private Keyboard _keyboard;

    private void Start()
    {
        _keyboard = Keyboard.current;
    }

    void Update()
    {
        //check if mouse was pressed this frame
        mouseHeldLastFrame = Input.GetMouseButtonDown(0);
        
        //check if left-click is held
        mouseHeld = Input.GetMouseButton(0);
        
        //Check number keys
        oneKeyHeld = _keyboard.digit1Key.isPressed;
        oneKeyPressed = _keyboard.digit1Key.wasPressedThisFrame;
        twoKeyHeld = _keyboard.digit2Key.isPressed;
        twoKeyPressed = _keyboard.digit2Key.wasPressedThisFrame;
    }
}
