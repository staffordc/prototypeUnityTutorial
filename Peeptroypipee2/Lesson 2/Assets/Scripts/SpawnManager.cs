using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    public float xRangeLimit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //xRangeLimit = Math.Random();
        
        if (Input.GetKeyDown(KeyCode.H))
        {
            animalIndex = Random.Range(0, animalPrefabs.Length);
            xRangeLimit = Random.Range(-10, 11);
            Instantiate(animalPrefabs[animalIndex], new Vector3(xRangeLimit, 0, 20), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
