using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    private GroundSpawner groundSpawner;
    [SerializeField] GameObject coinPrefab;
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] GameObject tallObstaclePrefab;
    [SerializeField] float tallObstacleChance = 0.2f;


    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    private void OnTriggerExit(Collider other) 
    {
        groundSpawner.SpawnTile(true);
        Destroy(gameObject, 2); //destroy ground tile 2secs after player release the trigger
    }

    public void SpawnObstacle()
    {
        //choose which obstacle to spawn
        GameObject obstacleToSpawn = obstaclePrefab;
        float random = Random.Range(0f, 1f);
        if(random < tallObstacleChance)
        {
            obstacleToSpawn = tallObstaclePrefab;
        }

        //choose a random point to spawn the obstacle
        int obstacleSpawnIndex = Random.Range(2,5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        
        //to spawn the obstacle at the position
        Instantiate(obstacleToSpawn, spawnPoint.position, Quaternion.identity, transform); //transform means this object transform, so when the GroundTile is destroyed, the obstacles are destroyed along with it
    }

    public void SpawnCoins()
    {
        int coinsToSpawn = 10;
        for (int i=0; i < coinsToSpawn; i++)
        {
            GameObject temp = Instantiate(coinPrefab, transform); //spawning coins (instantiate) & destroy after collect along with ground tile (transform)
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    //random position of coins in scene
    private Vector3 GetRandomPointInCollider (Collider collider) 
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
        );

        if (point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;
    }
}
