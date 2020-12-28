using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 8.0f;
    private float turnSpeed = 15.0f;
    private float horizontalInput;
    private float forwardInput;

    //private float clampRotation;

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        //horizontalInput = Input.GetAxis("Horizontal");
        //forwardInput = Input.GetAxis("Vertical");        

        //What angle do we have as speedup 
        //slowdown angle 
        //how do we measure the angle

        // Moves the player forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the player based on horizontal input
        transform.Rotate(Vector3.up *  Time.deltaTime * turnSpeed * horizontalInput);
    }
}
