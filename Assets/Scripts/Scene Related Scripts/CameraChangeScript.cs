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
    private int index = 0;
    
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
    }


    void Update()
    {
        score = float.Parse(scoreText.text.Substring(6));
        Debug.Log(score);

        if (score == 50f && index == 0)
        {
            index++;
            vcam.Follow = camPositions[index].transform;
            vcam.m_Lens.OrthographicSize += 6f;
        }
    }
}
