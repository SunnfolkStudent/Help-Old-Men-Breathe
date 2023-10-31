using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathManager : MonoBehaviour
{
    public BreathingDot breathingDot;
    private InputManager _input;

    public String breathingQuadrant;
    
    void Start()
    {
        _input = GetComponent<InputManager>();
    }

    void Update()
    {
        if (_input.mouseHeld)
        {
            if (breathingDot.angle >= 0 && breathingDot.angle < 120) { breathingQuadrant = "BreatheIn"; }
            if (breathingDot.angle >= 120 && breathingDot.angle < 240) { breathingQuadrant = "Hold"; }
            if (breathingDot.angle >= 240 && breathingDot.angle < 360) { breathingQuadrant = "BreatheOut"; }
        }
    }
}
