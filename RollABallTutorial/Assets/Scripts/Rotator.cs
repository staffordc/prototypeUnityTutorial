using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private void Awake()
    {
        //Color32 photo = Color.black + Color.white + Color.gray;
        //texture2D = parTicleSystem.GetComponent<Texture2D>();

        //This is deleted because LightParticleSysteController is not there
        //lightOn = parTicleSystem.GetComponent<Light>().GetComponent<LightParticleSystemController>().isActiveAndEnabled;
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        
    }
}
