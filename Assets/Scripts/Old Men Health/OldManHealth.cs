using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OldManHealth : MonoBehaviour
{

    public float oxygenLevel = 80;
    public float oxygenExpenditure;
    public float score = 0;
    
    public bool isDead = false;
    public bool oxygenDeprived;

    [SerializeField] private InputManager _input;
    [SerializeField] private OldManBreathManager _breathManager;
    [SerializeField] private TMP_Text _oxygenHUD;
    [SerializeField] private TMP_Text _scoreHUD;
    
    private Animator _animator;
    

    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (!isDead)
        {
            //Check if the old man is oxygen deprived
            if (oxygenLevel > 0) { oxygenDeprived = false; }
            else { oxygenDeprived = true; }

            //Prevent oxygen from going below zero
            if (oxygenLevel < 0) { oxygenLevel = 0; }

            //Take or give oxygen depending on quadrant
            if (_input.mouseHeld && _breathManager.breathingQuadrant.Equals("BreatheIn"))
            {
                oxygenLevel += (oxygenExpenditure * 1.25f) * Time.deltaTime;
                score += 0.5f;
            }
            else if (_input.mouseHeld && _breathManager.breathingQuadrant.Equals("Hold"))
            {
                oxygenLevel -= (oxygenExpenditure * 0.15f) * Time.deltaTime;
                score += 0.1f;
            }
            else if (!_input.mouseHeld || _breathManager.breathingQuadrant.Equals("BreatheOut")) { oxygenLevel -= oxygenExpenditure * Time.deltaTime; }
            
            animationControl();
        }

        //Update oxygen HUD and score text
        _oxygenHUD.text = "Oxygen: " + (Math.Round(oxygenLevel)) + "%";
        _scoreHUD.text = "Score: " + Math.Round(score) / 10;
        
        //Rupture lungs if breathe too much
        if (oxygenLevel >= 240)
        {
            isDead = true;
        }
        
        if (_input.mouseHeld) { Debug.Log("WORK"); }
    }

    public void animationControl()
    {
        //Manage animations
        if (oxygenLevel > 0)
        {
            
            if (_input.mouseHeld && _breathManager.breathingQuadrant.Equals("BreatheIn")) { _animator.Play("BreatheIn"); }
            else if (_input.mouseHeld && _breathManager.breathingQuadrant.Equals("Hold")) { _animator.Play("Hold"); }
            else if (!_input.mouseHeld || _breathManager.breathingQuadrant.Equals("BreatheOut")) { _animator.Play("BreatheOut"); }
        }
        else { _animator.Play("DeathOxygenDeprivation"); }
        
        if (oxygenLevel >= 120) { _animator.Play("DeathLungRupture"); }

        return;
    }

    //die
    public void die()
    {
        isDead = true;
        return;
    }
}
