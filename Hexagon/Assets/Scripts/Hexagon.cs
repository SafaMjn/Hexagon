﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour {

    public Rigidbody2D rb;
    public float shrink = 3f;

	// Use this for initialization
	void Start () {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale= Vector3.one*10f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale -= Vector3.one * shrink * Time.deltaTime;
        if (transform.localScale.x <=.1f)
        {
            Destroy(gameObject);
        }
	}
}
