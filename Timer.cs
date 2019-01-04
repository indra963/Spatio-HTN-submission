﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timerText;
    private float startTime;
    private bool finished = false;

    // Use this for initialization
    void Start () {
    	startTime = Time.time;
    }
	
	// Update is called once per frame
    void Update () {
        if (finished) return;

        float t = Time.time - startTime;
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f2");

        timerText.text = min + ":" + sec;
    }
}
