using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed =  10.0f;
    public float xRange = 10.0f;
    
    private float posX;
    private float posY;
    private float posZ;

    public GameObject projectilePrefabRed;
    public GameObject projectilePrefabGreen;

    
    void PlayerPositioning() 
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        posX = gameObject.transform.position.x;
        posY = gameObject.transform.position.y;
        posZ = gameObject.transform.position.z;

        if (posX < -xRange)
        {
            transform.position = new Vector3(-xRange, posY, posZ);
        }
        else if (posX > xRange)
        {
            transform.position = new Vector3(xRange, posY, posZ);
        }
    }

    void Update()
    {
        PlayerPositioning();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefabRed, transform.position, 
                projectilePrefabRed.transform.rotation);
        }
    }
}
