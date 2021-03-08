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

    void Update()
    {
        float positionZed = gameObject.transform.position.z;

        if (positionZed >= topScreen || positionZed <= botScreen)
        {
            Destroy(gameObject);

            if (positionZed < -10)
            {
                flipUI.Destroy_Counter();
            }
        }
    }
}
