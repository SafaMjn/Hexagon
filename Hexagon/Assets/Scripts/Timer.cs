using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    
    public Text seconds;
    public float StartTime;
    public static float timer = 0f;

    private void Start()
    {
        StartTime = Time.time;
    }
    // Update is called once per frame
    void FixedUpdate () {
         timer = Time.time-StartTime;

        seconds.text = timer.ToString("f2");
    }
}
