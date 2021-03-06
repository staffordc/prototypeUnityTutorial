using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    FlipUI flipUI;
    public float topScreen = 30;
    public float botScreen = -20;
   
    void Start()
    {
        flipUI = FindObjectOfType<FlipUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float positionZed = gameObject.transform.position.z;

        if (positionZed <= botScreen)
        {
            flipUI.Destroy_Counter();
        }

        if (positionZed >= topScreen || positionZed <= botScreen)
        {
            Destroy(gameObject);
        }
    }
}
