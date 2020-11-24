using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float verticalInput;
    private Vector3 planeTransformCoords;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        // get the user's input
        planeTransformCoords = new Vector3(0, horizontalInput + verticalInput, 0);


        verticalInput = Input.GetAxis("Vertical");
        //horizontalInput = Input.GetAxis("Horizontal");


        // plane going forward at consistant speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane reight/left based on the right/left arrow keys
        transform.Translate( Vector3.forward * verticalInput * Time.deltaTime * speed);
        transform.Rotate(Vector3.forward * verticalInput  * Time.deltaTime* turnSpeed);
    }
}
