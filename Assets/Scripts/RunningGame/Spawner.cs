using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclesPattern;

    private float timeSpawn;
    public float startTimeSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    

    private void Update() 
    {
        if (timeSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclesPattern.Length);
            Instantiate(obstaclesPattern[rand], transform.position, Quaternion.identity);
            timeSpawn = startTimeSpawn;
            
            if (startTimeSpawn > minTime)
            {
                startTimeSpawn -= decreaseTime;
            }
        }
        else {
            timeSpawn -= Time.deltaTime;
        }
    }
}
