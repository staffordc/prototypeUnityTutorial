using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        //Possible future check for menus = current comments
        //posiPntWidth = FindObjectOfType<Canvas>().transform.position.x;
        //posiPntHeight = FindObjectOfType<Canvas>().transform.position.y;

        //Vector3 player2Posi = new Vector3(posiPntWidth, posiPntHeight, -5f);

        quitButton.onClick.AddListener(OnButtonClick);
        
        Player = FindObjectOfType<PlayerController>().gameObject;

    }

    /*void PosiPointCalculations() 
    {
        float posiX = posiPntWidth * .5f;
        float posiY = posiPntHeight * .5f;
        player2Posi = new Vector3(posiX, posiY, -0f);
        
        Vector3 playerTranCurrent = Player.transform.position;

        Debug.Log("playerTransformCurrent: " + playerTranCurrent);
    }
    */
    void OnButtonClick() 
    {
        //PosiPointCalculations();
        //Debug.Log("The Position was calculated");
        // spriteCheck.transform.position = player2Posi;

        Vector3 playerTranCurrent = Player.transform.position;
        Debug.Log("Ball's position: " + playerTranCurrent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
