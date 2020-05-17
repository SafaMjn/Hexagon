using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time_ctr : Singleton<Time_ctr> {
    
    public Text seconds;
    public float StartTime;
    public float timer = 0f;

    private void Start()
    {
        StartTime = Time.time;
    }

    void FixedUpdate () {
         timer = Time.time-StartTime;

        seconds.text = timer.ToString("f2");
    }
}
