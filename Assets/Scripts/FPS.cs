using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using UnityEngine;

/// Author: Luke McCann
/// <datecreated>23/05/2020</datecreated>
/// <summary>
/// FPS
/// 
/// Basic script for printing FPS.
/// </summary>
/// <example>
/// Attach script to a unity object (e.g. camera) and run.
/// </example>
public class FPS : MonoBehaviour
{
    private string fps;
    private float deltaTime;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f/deltaTime;
        fps = Mathf.Ceil (fps);
        print(fps);
    }
}
