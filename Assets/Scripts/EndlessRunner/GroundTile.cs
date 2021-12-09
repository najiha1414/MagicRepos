﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    private GroundSpawner groundSpawner;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    private void OnTriggerExit(Collider other) 
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2); //destroy game object 2secs after player release the trigger
    }
}
