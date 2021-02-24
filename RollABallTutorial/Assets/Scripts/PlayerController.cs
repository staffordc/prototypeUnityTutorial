using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
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

    public GameObject collisionBarHit;
    public GameObject pickUpSpark;

    public float speed = 10;
    private Rigidbody playerRB;

    private float movementX;
    private float movementY;

    public List<AudioClip> audioClipNumbers;
    public AudioSource loudMouth;


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

        if (count >= 7)
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
        WhichSound();
        if (collider.gameObject.CompareTag("PickUp"))
        {
            var pickMeUpFrom = gameObject.transform.position;
            var spark = Instantiate(pickUpSpark, pickMeUpFrom, Quaternion.identity);
                        
            StartCoroutine(ParticleTiming(spark));

            count += 1;
            Destroy(collider.gameObject);
            SetCountText();
        }        
    }

    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Barrier"))
        {
            
            Vector3 playerPositionForLogs = new Vector3(playerRB.position.x, playerRB.position.y, playerRB.position.z);
            
            foreach (ContactPoint contact in collision.contacts)
            {
                Quaternion hitRotation = contact.thisCollider.transform.rotation;
                Vector3 pointOfContact = contact.point;

                Debug.DrawLine(contact.point, playerPositionForLogs, Color.red);
                Debug.DrawRay(contact.point, contact.normal, Color.white, 6);

                //if (// >= 2f) 
                {
                    var spark = Instantiate(collisionBarHit, pointOfContact, hitRotation);
                    StartCoroutine(ParticleTiming(spark));   
                }
            }
        }  
    }

    public void WhichSound()
    {
        int noAudio = audioClipNumbers.Count;
        Debug.Log(noAudio);
        int whatSound = UnityEngine.Random.Range(0, noAudio);

        var valueOfSoundPlayed = whatSound.ToString();
        Debug.Log("Sound Clip " + valueOfSoundPlayed + " was played");

        loudMouth.PlayOneShot(audioClipNumbers[whatSound]);
        
    }


    private IEnumerator ParticleTiming(GameObject sortingPartType) 
    {
        float particleTimeLength = sortingPartType.GetComponent<ParticleSystem>().main.duration;
        yield return new WaitForSeconds(particleTimeLength);        
        Destroy(sortingPartType, particleTimeLength);
        
        
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        playerRB.AddForce(movement * speed);
    }
}
