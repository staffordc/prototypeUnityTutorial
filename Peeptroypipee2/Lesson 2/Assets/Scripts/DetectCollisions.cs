using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    float positionZed;
    float posScreen;

    void Start()
    {
        posScreen = FindObjectOfType<DestroyOutOfBounds>().offScreen;
    }

    void Update()
    {
        positionZed = gameObject.transform.position.z;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (positionZed <= posScreen || positionZed >= posScreen)
        { Debug.Log("This guy " + gameObject.name + " has disappeared"); }
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
