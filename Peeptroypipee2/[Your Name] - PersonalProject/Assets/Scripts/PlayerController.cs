using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private Rigidbody playerRb;
    private BoxCollider playAreaRug;
    private Vector3 startHerePlz;
    GameObject groundPlay;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
        groundPlay = GameObject.Find("Ground");
        playAreaRug = groundPlay.GetComponent<BoxCollider>();
        startHerePlz = new Vector3(0f, .5f, 0f);
    }
    // Something that feels like launching
    // Launching could be from the player, 
    // but particle effects on collision so, 
    // like a rubber band with varying distance for different attack types
    // Newtonian Golf

    //Player's force of movement based on axis inputs
    public void PlayerMovement() 
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticleInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticleInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    //When player leaves the collider, this resets them to origin, since I dun wanna deal with the physics yet
    private void Respawn()
    {
        gameObject.transform.position = startHerePlz;
        playerRb.AddForce(playerRb.angularVelocity * speed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    //checks if player is still inside the play area.
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name.Contains("Ground"))
        { 
            //Debug.Log("oops, you fell!");
            Respawn();
        }
    }

   
}
