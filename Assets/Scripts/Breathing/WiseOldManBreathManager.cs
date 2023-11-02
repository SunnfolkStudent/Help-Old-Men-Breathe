using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiseOldManBreathManager : MonoBehaviour
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
        if (_input.threeKeyPressed) { needToLetGo = false; }
        
        //right side = 0, 80, 120
        //left side = 120, 70, 25
        
        //Set which quadrant the dot is currently in
        if (_input.threeKeyHeld)
        {
            if (breathingDot.angle >= 0 && breathingDot.angle < 80 && !needToLetGo) { breathingQuadrant = "BreatheIn"; }
            if (breathingDot.angle >= 80 && breathingDot.angle < 120) { breathingQuadrant = "Hold"; }
            if (breathingDot.angle >= 120 && breathingDot.angle < 205) { breathingQuadrant = "BreatheOut"; }
            if (breathingDot.angle >= 205 && breathingDot.angle < 260 && !needToLetGo) { breathingQuadrant = "BreatheIn"; }
            if (breathingDot.angle >= 260 && breathingDot.angle < 300) { breathingQuadrant = "Hold"; }
            if (breathingDot.angle >= 300 && breathingDot.angle < 360) { breathingQuadrant = "BreatheOut"; }
        }
    }
}
