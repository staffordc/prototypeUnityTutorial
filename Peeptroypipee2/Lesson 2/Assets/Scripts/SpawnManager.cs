using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    
    private int animalIndex;

    private float spawnPosX = 20;
    private float spawnPosZ = 25;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), startDelay, spawnInterval);
    }
    void SpawnRandomAnimal() 
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnPosX = Random.Range(-spawnPosX, spawnPosX);

        Vector3 spawnPos = new Vector3(Random.Range
            (-spawnPosX, spawnPosX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }



    // Update is called once per frame
    void Update()
    {
 
    }
}
