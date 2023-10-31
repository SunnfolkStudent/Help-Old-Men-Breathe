using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldManHealth : MonoBehaviour
{

    public float oxygenLevel = 200;
    public float oxygenExpenditure;
    
    public bool oxygenDeprived;

    [SerializeField] private InputManager _input;
    [SerializeField] private BreathManager _breathManager;
    private Animator _animator;
    

    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        //Check if the old man is oxygen deprived
        if (oxygenLevel > 0) { oxygenDeprived = false; }
        else { oxygenDeprived = true; }

        if (oxygenLevel < 0) { oxygenLevel = 0; }

        //Take or give oxygen depending on quadrant
        if (_input.mouseHeld && _breathManager.breathingQuadrant.Equals("BreatheIn"))
        {
            oxygenLevel += (oxygenExpenditure * 1.25f) * Time.deltaTime;
            _animator.Play("BreatheIn");
        }
        else if (_input.mouseHeld && _breathManager.breathingQuadrant.Equals("Hold"))
        {
            _animator.Play("Hold");
        }
        else if (!_input.mouseHeld || _breathManager.breathingQuadrant.Equals("BreatheOut"))
        {
            oxygenLevel -= oxygenExpenditure * Time.deltaTime;
            _animator.Play("BreatheOut");
        }
        if (_input.mouseHeld) { Debug.Log("WORK"); }
    }
}
