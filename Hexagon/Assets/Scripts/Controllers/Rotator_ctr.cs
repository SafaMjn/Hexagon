using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator_ctr : Singleton<Rotator_ctr> {

    public float rotationSpeed = 30f;
    public Camera camera;
    public Color camColor;
    private float nextTimeToChangeColor = 0f;
    public float rate = 1f;

    private void Start()
    {
        camColor = camera.backgroundColor;
    }


    void Update () {
        camera.transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);

        if (Time.time >= nextTimeToChangeColor)
        {
            camColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            camera.backgroundColor = camColor;
            nextTimeToChangeColor = Time.time + 10f /rate;
           
        }
    }
}
