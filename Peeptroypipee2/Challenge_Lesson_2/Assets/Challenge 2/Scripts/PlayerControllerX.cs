using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    IEnumerator InstanceOfDog;
    [SerializeField] public float dogSeconds = 3f;

    IEnumerator DogLimiter(float secondsForNewDog) 
    {
        Instantiate(dogPrefab, dogPrefab.transform.position,
            dogPrefab.transform.rotation);
        yield return new WaitForSeconds(secondsForNewDog);
        InstanceOfDog = null;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (InstanceOfDog == null)
            {
                InstanceOfDog = DogLimiter(dogSeconds);
                StartCoroutine(InstanceOfDog);
            }
        }
    }
}
