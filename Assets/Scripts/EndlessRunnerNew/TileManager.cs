using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float spawnZ = -4.0f;
    private float tileLength = 4.0f; //the floor length
    private float safeZone = 15.0f; //starter floor for player
    private int amountTileOnScreen = 7;
    private int lastPrefabIndex = 0;

    private List<GameObject> activeTiles;

    void Start()
    {
        activeTiles = new List<GameObject>();

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for(int i = 0; i < amountTileOnScreen; i++) //exactly spawning 7 tiles
        {
            if(i<5)
                SpawnTile(0);
            else
                SpawnTile();
        }
    }

    void Update()
    {
        if(playerTransform.position.z - safeZone > (spawnZ - amountTileOnScreen * tileLength))
        {
            SpawnTile(); //continuosly spawning 7 times/tiles
            DeleteTile();
        }
    }

    private void SpawnTile(int prefabIndex = -1) 
    {
        GameObject go;
        if(prefabIndex == -1)
            go = Instantiate(tilePrefabs[RandomPrefabIndex()]) as GameObject;
        else
            go = Instantiate(tilePrefabs[prefabIndex]) as GameObject;

        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;

        activeTiles.Add(go);
    }

    private void DeleteTile() 
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if(tilePrefabs.Length <= 1)
        return 0; //if theres only 1 prefab in the list, just return the first one

        int randomIndex = lastPrefabIndex;
        while(randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, tilePrefabs.Length);
        }

        lastPrefabIndex = randomIndex;
        return randomIndex;
    }
}
