using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonQuitActions : MonoBehaviour
{
    //Vector3 player2Posi;
    //float posiPntHeight;
    //float posiPntWidth;
    GameObject Player;
    [SerializeField] Button quitButton;
    
    void Start()
    {
        quitButton.onClick.AddListener(OnButtonClick);
        
        Player = FindObjectOfType<PlayerController>().gameObject;

        Vector3 playerTranCurrent = Player.transform.position;
        Debug.Log("Ball's position: " + playerTranCurrent);
    }

    void OnButtonClick() 
    {
        if (quitButton != null)
        {
            Debug.Log("woah, this game closed or something");
            Application.Quit();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
