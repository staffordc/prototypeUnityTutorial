using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipUI : MonoBehaviour
{
    public GameObject gameOverText;
    
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
    }

    void Update()
    {
        
    }
}
