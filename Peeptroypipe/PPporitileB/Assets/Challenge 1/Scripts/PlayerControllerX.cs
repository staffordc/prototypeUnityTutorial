using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField] private float speed = 20.0f;
    [SerializeField] private float turnSpeed = 30.0f;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;
    public Vector3 planeTransformCoords;
    public Vector3 planeTransformRots;
    public Vector3 lerpAttempt;
    

    // Start is called before the first frame update
    void Start()
    {        
    }

    void PlaneTurnFunc() 
    {
        //// get the user's input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // tilt the plane based on arrow keys

        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);
        transform.Rotate(Vector3.right * -verticalInput * Time.deltaTime * turnSpeed);


        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }

    void PlaneRightingItself() 
    {
        //Debug.Log("using lerpAttempt " + planeTransformRots + " is the rotation value");
        //an attempt to make the plane level when no keys are depressed
        gameObject.transform.Rotate(lerpAttempt);
    }

    // Update is called once per frame
    void Update()
    {

        if (planeTransformRots.x < 180 || planeTransformRots.x > 0)
        {
            planeTransformRots.x *= -1;
        }
        if (planeTransformRots.y < 180 || planeTransformRots.y > 0)
        {
            planeTransformRots.y *= -1;
        }
        if (planeTransformRots.z < 180 || planeTransformRots.z > 0)
        {
            planeTransformRots.z *= -1;
        }

        PlaneTurnFunc();        

        // plane going forward at consistant speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // plane's current Rotation
        planeTransformRots = new Vector3(gameObject.transform.rotation.x, gameObject.transform.rotation.y, gameObject.transform.rotation.z);
        
        lerpAttempt = Vector3.Lerp(planeTransformRots, -planeTransformRots, 1000.0f * Time.deltaTime);
        
        if (verticalInput == 0 && horizontalInput == 0) 
        {
            PlaneRightingItself();
        }

    }
}
