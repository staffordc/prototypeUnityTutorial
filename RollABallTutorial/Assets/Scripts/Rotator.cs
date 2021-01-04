using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] AudioClip soundOne;
    [SerializeField] AudioClip soundTwo;
    [SerializeField] AudioClip soundThree;
    [SerializeField] AudioClip soundFour;
    [SerializeField] AudioClip soundFive;
    [SerializeField] AudioClip soundSix;
    [SerializeField] AudioClip soundSeven;

    float whatSound;
    private void Awake()
    {
        //Color32 photo = Color.black + Color.white + Color.gray;
        //texture2D = parTicleSystem.GetComponent<Texture2D>();

        //This is deleted because LightParticleSysteController is not there
        //lightOn = parTicleSystem.GetComponent<Light>().GetComponent<LightParticleSystemController>().isActiveAndEnabled;
        
    }
    public void WhichSound()
    {
        whatSound = Random.Range(1.0f, 7.0f);
        var valueOfSoundPlayed = whatSound.ToString();
        Debug.Log("Sound Clip "+valueOfSoundPlayed+" was played");
        
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        
    }
}
