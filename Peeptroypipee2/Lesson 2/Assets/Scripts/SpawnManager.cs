using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private int animalIndex;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), 2, 1.5f);
    }
    void SpawnRandomAnimal() 
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnRangeX = Random.Range(-10, 11);

        Vector3 spawnPos = new Vector3(Random.Range
            (-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }



    // Update is called once per frame
    void Update()
    {
 
    }
}
