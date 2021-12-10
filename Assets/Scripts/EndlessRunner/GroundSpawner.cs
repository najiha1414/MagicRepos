﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] GameObject groundTile;
    private Vector3 nextSpawnPoint;

    public void SpawnTile(bool spawnItems) 
    {
        //Quaternion.identity = no rotation, perfectly aligned
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity); //to make the ground keeps spawning without putting ground prefabs many times
        nextSpawnPoint = temp.transform.GetChild(1).transform.position; //NextSpawnPoint is a second child of GroundTile so the index is 1
    
        if (spawnItems)
        {
            temp.GetComponent<GroundTile>().SpawnObstacle();
            temp.GetComponent<GroundTile>().SpawnCoins();
        }
    }

    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            if (i < 3)
            {
                SpawnTile(false);
            } else {
                SpawnTile(true);
            }
        }
    }
}
