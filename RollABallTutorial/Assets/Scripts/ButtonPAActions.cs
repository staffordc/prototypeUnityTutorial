using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonPAActions : MonoBehaviour
{
    GameObject Player;
    [SerializeField] Button playButton;
    void Start()
    {
        playButton.onClick.AddListener(OnButtonClick);
        Player = FindObjectOfType<PlayerController>().gameObject;
    }
    void OnButtonClick() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Update()
    {
        
    }
}
