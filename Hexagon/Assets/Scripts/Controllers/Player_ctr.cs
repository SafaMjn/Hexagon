using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_ctr : Singleton<Player_ctr> {

    public Transform player_go;
    public float speed = 600f;
    float movement = 0f;

	void Update () {

       movement=  Input.GetAxisRaw("Horizontal");
	}

    private void FixedUpdate()
    {
        player_go.transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -speed);
    }

    


}

