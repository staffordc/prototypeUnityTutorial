using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    
    public TextMeshProUGUI countText;
    private int count;
    public GameObject winTextObject;
    public Button playAgainBtn;
    public Button quitButton;
    public GameObject menuCluster;
    public GameObject spriteCheck;

    private ParticleSystem parTicleSystem;

    public float speed = 10;

    private Rigidbody playerRB;

    private bool isThisOn;
    private bool isMenuOn;
    private float movementX;
    private float movementY;
    void Start()
    {
        playAgainBtn = menuCluster.GetComponentInChildren<ButtonPAActions>()
            .gameObject.GetComponent<Button>();
        quitButton = menuCluster.GetComponentInChildren<ButtonQuitActions>()
            .gameObject.GetComponent<Button>();
        playerRB = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();

        OnOffUIelements(false);
        
    }

    private void OnOffUIelements(bool isMenuOn)
    {
        if (isMenuOn == true){menuCluster.SetActive(true);}
        if (isMenuOn == false){menuCluster.SetActive(false);}
    }

    private void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 2)
        {
            OnOffUIelements(true);
        }
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    
    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.CompareTag("PickUp"))
        {
            collider.gameObject.GetComponent<MeshRenderer>().enabled = false;
            collider.gameObject.GetComponent<BoxCollider>().enabled = false;
            parTicleSystem = collider.gameObject.GetComponentInChildren<ParticleSystem>(includeInactive: true);
            parTicleSystem.Play();
            Debug.Log("It is on now??? " + gameObject.ToString());

            StartCoroutine(TimeTrouble());

            count += 1;
            SetCountText();
        }

        if (collider.gameObject.CompareTag("Barrier"))
        {
            var barValue = gameObject.name.ToString();
            Debug.Log("It is on now??? " + barValue);

            
            
            //collider.GetComponent<Rigidbody>().AddForce(new Vector3(movementX, movementY, gameObject.transform.position.z));
        }

    }

    private IEnumerator TimeTrouble()
    {
        //isThisOn = parTicleSystem.emission.enabled;
        yield return new WaitForSeconds(3f);
        parTicleSystem.Stop();
        //Debug.Log("it's not on now..." + isThisOn.ToString());
       
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        playerRB.AddForce(movement * speed);
    }
}
