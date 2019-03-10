﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    //Some code from: https://www.youtube.com/watch?v=BGe5HDsyhkY
    float timeCounter;
    float speed;
    float width;
    float depth;

    // Start is called before the first frame update
    void Start()
    {
        timeCounter = 0;
        speed = 0.5f;
        width = 15;
        depth = 15;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime*speed;

        float x = Mathf.Cos(timeCounter) * width;
        // no height change
        float z = Mathf.Sin(timeCounter) * depth;
        
        transform.position = new Vector3(x, 0, z);
    }
}