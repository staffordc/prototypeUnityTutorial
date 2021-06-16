using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private Rigidbody playerRb;

    

    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
    }


    // Something that feels like launching
    // Launching could be from the player, 
    // but particle effects on collision so, 
    // like a rubber band with varying distance for different attack types
    // Newtonian Golf

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticleInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticleInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);

    }
}
