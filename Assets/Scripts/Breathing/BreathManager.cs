using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathManager : MonoBehaviour
{
    public BreathingDot breathingDot;
    private InputManager _input;
    public bool needToLetGo = false;
    
    public String breathingQuadrant;
    
    void Start()
    {
        _input = GetComponent<InputManager>();
    }

    void Update()
    {
        
        //Make is so that you can't hold the entire game and win
        if (breathingDot.angle >=  359) { needToLetGo = true; }
        if (_input.mouseHeldLastFrame) { needToLetGo = false; }
        
        //Set which quadrant the dot is currently in
        if (_input.mouseHeld)
        {
            if (breathingDot.angle >= 0 && breathingDot.angle < 120 && !needToLetGo) { breathingQuadrant = "BreatheIn"; }
            if (breathingDot.angle >= 120 && breathingDot.angle < 240) { breathingQuadrant = "Hold"; }
            if (breathingDot.angle >= 240 && breathingDot.angle < 360) { breathingQuadrant = "BreatheOut"; }
        }
    }
}
