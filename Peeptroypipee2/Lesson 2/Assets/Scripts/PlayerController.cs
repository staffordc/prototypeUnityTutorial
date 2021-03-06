using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed =  10.0f;
    public float xRange = 10.0f;
    
    public float posX;
    public float posY;
    public float posZ;

    public GameObject projectilePrefabRed;
    public GameObject projectilePrefabGreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefabRed, transform.position, 
                projectilePrefabRed.transform.rotation);
        }
    }
}
