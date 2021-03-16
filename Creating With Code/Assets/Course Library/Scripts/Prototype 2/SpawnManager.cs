using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 15f;
    private float spawnRangeZ = 20f;
    
    public float startDelay = 2f;
    public float spawnInterval = 1f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
            
        Instantiate(animalPrefabs[animalIndex], spawnPos , animalPrefabs[animalIndex].transform.rotation);
    }
}
