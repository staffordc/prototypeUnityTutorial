using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float offScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float positionZed = gameObject.transform.position.z;

        if (positionZed >= offScreen || positionZed <= -offScreen)
        {
            Destroy(gameObject);
        }
    }
}
