using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText; // Reference to the Text component displaying the score
    public Text highScoreText; // Reference to the Text component displaying the high score

    private float timer = 0f; // Timer to track the elapsed time
    private int score = 0; // Current score
    private int highScore = 0; // High score
    private string highScoreKey = "HighScore"; // Key to save and load the high score from PlayerPrefs

    
    private void Start()
    {
     
        // Load the high score from PlayerPrefs
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        UpdateHighScoreText();
    }

    private void Update()
    {
       
        // Increase the score based on the elapsed time
        timer += Time.deltaTime;
        score = Mathf.FloorToInt(timer);

        // Update the score text
        UpdateScoreText();

        // Check for new high score
        if (score > highScore)
        {
            highScore = score;
            UpdateHighScoreText();

            // Save the new high score to PlayerPrefs
            PlayerPrefs.SetInt(highScoreKey, highScore);
            PlayerPrefs.Save();
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    private void UpdateHighScoreText()
    {
        highScoreText.text = "High Score: " + highScore.ToString();
    }
}

