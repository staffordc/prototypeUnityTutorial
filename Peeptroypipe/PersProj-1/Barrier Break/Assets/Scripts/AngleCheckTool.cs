using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleCheckTool : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.GetComponent<MeshRenderer>().isVisible == true)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;            
        }
    }

    void CheckAngle()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckAngle();
        
    }
}
