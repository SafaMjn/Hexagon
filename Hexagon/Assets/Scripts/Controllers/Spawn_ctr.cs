using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_ctr : Singleton<Spawn_ctr> {

    public float spawnRate = 1f;

    public GameObject prefab;

    private float nextTimeToSpawn = 0f;

    void Update () {
		
        if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(prefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
	}

    
}
