using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text minutes;
    public Text seconds;

    public float timer = 0f;
	
	// Update is called once per frame
	void Update () {
         timer += Time.deltaTime;
         minutes.text = Mathf.Floor(timer / 60f).ToString("00")+ " :";
         seconds.text = Mathf.RoundToInt(timer % 60f).ToString("00");
    }
}
