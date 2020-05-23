using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using UnityEngine;

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
