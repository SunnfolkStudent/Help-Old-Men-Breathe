using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputManager : MonoBehaviour
{

    public bool mouseHeld;

    void Update()
    {
        //check if left-click is held
        mouseHeld = Input.GetMouseButton(0);
    }
}
