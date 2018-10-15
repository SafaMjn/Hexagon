using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float rotationSpeed = 30f;
    public Camera cam;
    public Color camColor;
    private float nextTimeToChangeColor = 0f;
    public float rate = 1f;

    private void Start()
    {
        camColor = cam.backgroundColor;
    }

    // Update is called once per frame
    void Update () {
        transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);

        if (Time.time >= nextTimeToChangeColor)
        {
            camColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            cam.backgroundColor = camColor;
            nextTimeToChangeColor = Time.time + 10f /rate;
           
        }
    }
}
