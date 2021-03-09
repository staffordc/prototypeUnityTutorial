using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    int ballPrefab;
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    void Start()
    {
        float spawnInterval = Random.Range(3.0f, 5.0f);
        InvokeRepeating(nameof(SpawnRandomBall), startDelay, spawnInterval);
    }

    
    void SpawnRandomBall ()
    {
        Vector3 spawnPos = new Vector3(Random.Range(
            spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        ballPrefab = Random.Range(1, ballPrefabs.Length);

        Instantiate(ballPrefabs[ballPrefab], spawnPos, 
            ballPrefabs[ballPrefab].transform.rotation);
    }

}
