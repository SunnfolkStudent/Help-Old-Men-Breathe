using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathManager : MonoBehaviour
{
    public BreathingDot breathingDot;
    private InputManager _input;
    
    void Start()
    {
        _input = GetComponent<InputManager>();
    }

    void Update()
    {
        if (_input.mouseHeld)
        {
            if (breathingDot.angle >= 0 && breathingDot.angle < 120) { Console.WriteLine("Breathe In"); }
            if (breathingDot.angle >= 120 && breathingDot.angle < 240) { Console.WriteLine("Hold"); }
            if (breathingDot.angle >= 240 && breathingDot.angle < 360) { Console.WriteLine("Breathe Out"); }
        }
    }
}
