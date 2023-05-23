using UnityEngine;

public class GamePause : MonoBehaviour
{
    private bool isPaused = false; // Flag to track if the game is paused
    public GameObject pausebtn;
    public GameObject Playbtn;


    public void Start()
    {
        pausebtn.SetActive(true);
        Playbtn.SetActive(false);
    }
    public void PauseGame()
    {
        Time.timeScale = 0f; // Set the time scale to 0 to pause the game
        isPaused = true;
        pausebtn.SetActive(false);
        Playbtn.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Set the time scale back to 1 to resume the game
        isPaused = false;
        pausebtn.SetActive(true);
        Playbtn.SetActive(false);
    }
}
