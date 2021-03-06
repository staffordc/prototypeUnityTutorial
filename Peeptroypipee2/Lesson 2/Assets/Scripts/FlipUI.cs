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
    }
    public void Destroy_Counter() 
    {
        destroyCounter++;
        if (destroyCounter >= 3)
        {
            gameOverText.SetActive(true);
            Time.timeScale = 0f;
        }
        Debug.Log("Destroy counter: " + destroyCounter);
    }
    void Pause()
    {
        if (!isPaused)
        { 
            menuText.SetActive(true); 
            Time.timeScale = 0f; 
            isPaused = true; 
        }

        if (isPaused)
        { 
            menuText.SetActive(false); 
            Time.timeScale = 1f; 
            isPaused = false; 
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
