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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the old man is oxygen deprived
        if (oxygenLevel > 0) { oxygenDeprived = false; }
        else { oxygenDeprived = true; }

        if (oxygenLevel < 0) { oxygenLevel = 0; }

        //Take or give oxygen
        if (!_input.mouseHeld) { oxygenLevel -= oxygenExpenditure * Time.deltaTime; }
        else if (_input.mouseHeld && _breathManager.breathingQuadrant.Equals("BreatheIn")) { oxygenLevel += oxygenExpenditure * Time.deltaTime; }
        
        if (_input.mouseHeld) { Debug.Log("WORK"); }
    }
}
