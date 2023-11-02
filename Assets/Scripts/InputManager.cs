using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputManager : MonoBehaviour
{

    public bool mouseHeld = false;
    public bool mouseHeldLastFrame;

    public bool oneKeyHeld, oneKeyPressed;
    public bool twoKeyHeld, twoKeyPressed;
    public bool threeKeyHeld, threeKeyPressed;
    public bool fourKeyHeld, fourKeyPressed;

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
        threeKeyHeld = _keyboard.digit3Key.isPressed;
        threeKeyPressed = _keyboard.digit3Key.wasPressedThisFrame;
        fourKeyHeld = _keyboard.digit4Key.isPressed;
        fourKeyPressed = _keyboard.digit4Key.wasPressedThisFrame;
    }
}
