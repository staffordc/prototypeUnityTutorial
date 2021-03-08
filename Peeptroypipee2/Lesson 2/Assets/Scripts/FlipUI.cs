using UnityEngine;

public class FlipUI : MonoBehaviour
{
    DestroyOutOfBounds destroyOutOfBounds;
    [SerializeField] public GameObject gameOverText;
    [SerializeField] public GameObject menuText;
    bool isPaused;

    private int destroyCounter;

    void Start()
    {
        isPaused = false;
        gameOverText.gameObject.SetActive(false);
        menuText.gameObject.SetActive(false);
    }

    public void Destroy_Counter() 
    {
        destroyCounter++;
        Debug.Log("Destroy Counter: " + destroyCounter);
        if (destroyCounter >= 3)
        {
            gameOverText.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    void Pause()
    {
        if (isPaused == true)
        { 
            menuText.gameObject.SetActive(false); 
            Time.timeScale = 1f; 
            isPaused = false;
            
        }
        else if (isPaused == false)
        {
            menuText.gameObject.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }
}
