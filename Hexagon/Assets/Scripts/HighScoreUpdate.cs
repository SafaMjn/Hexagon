﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreUpdate : MonoBehaviour {

    public Text highscore;

	// Use this for initialization
	void Start () {
        highscore.text = "Highscore\n" + PlayerPrefs.GetFloat("HighScore").ToString("f2");

    }
	
}
