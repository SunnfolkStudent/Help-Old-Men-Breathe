using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatOldManBreathManager : MonoBehaviour
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
        if (_input.twoKeyPressed) { needToLetGo = false; }
        
        //Set which quadrant the dot is currently in
        if (_input.twoKeyHeld)
        {
            if (breathingDot.angle >= 0 && breathingDot.angle < 35 && !needToLetGo) { breathingQuadrant = "BreatheIn"; }
            if (breathingDot.angle >= 35 && breathingDot.angle < 100) { breathingQuadrant = "Hold"; }
            if (breathingDot.angle >= 100 && breathingDot.angle < 120) { breathingQuadrant = "BreatheOut"; }
            
            if (breathingDot.angle >= 120 && breathingDot.angle < 153 && !needToLetGo) { breathingQuadrant = "BreatheIn"; }
            if (breathingDot.angle >= 153 && breathingDot.angle < 200) { breathingQuadrant = "Hold"; }
            if (breathingDot.angle >= 200 && breathingDot.angle < 245) { breathingQuadrant = "BreatheOut"; }
            
            if (breathingDot.angle >= 245 && breathingDot.angle < 280 && !needToLetGo) { breathingQuadrant = "BreatheIn"; }
            if (breathingDot.angle >= 280 && breathingDot.angle < 335) { breathingQuadrant = "Hold"; }
            if (breathingDot.angle >= 335 && breathingDot.angle < 360) { breathingQuadrant = "BreatheOut"; }
        }
    }
}
