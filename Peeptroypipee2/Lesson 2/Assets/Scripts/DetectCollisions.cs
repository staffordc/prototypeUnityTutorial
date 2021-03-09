using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (positionZed <= posScreen || positionZed >= posScreen)
        { Debug.Log("This guy " + gameObject.name + " has disappeared"); }
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
