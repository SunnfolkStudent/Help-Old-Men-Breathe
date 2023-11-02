using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;

public class CameraChangeScript : MonoBehaviour
{

    public CinemachineVirtualCamera vcam;

    private TMP_Text scoreText;

    private float score;

    public GameObject[] camPositions;
    private int camIndex = 0;
    
    public GameObject[] oldMen;
    private int menIndex = 0;
    
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
    }


    void Update()
    {
        score = float.Parse(scoreText.text.Substring(6));

        if ((score == 50f && camIndex == 0) || (score == 60f && camIndex == 1))
        {
            camIndex++;
            vcam.Follow = camPositions[camIndex].transform;
            
            if (camIndex == 1) { vcam.m_Lens.OrthographicSize += 6f; }

            menIndex++;
            oldMen[menIndex].SetActive(true);
        }
    }
}
