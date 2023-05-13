﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControls: MonoBehaviour
{
    private Text timerText;
    private int timerCount;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(CountTime());
        timerText = GameObject.Find("Score").GetComponent<Text>();
    }
}
