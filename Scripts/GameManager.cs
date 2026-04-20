using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public bool gameOver = false;

    public bool isPaused = false;
    public Text pauseText;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void AddScore()
    {
        score += 1;
        scoreText.text = "SCORE: " + score;
    }

    public void GameOver()
    {
        gameOver = true;
        scoreText.text = "GAME OVER! SCORE: " + score + " (PRESS R)";
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0;
            if (pauseText != null)
            {
                pauseText.text = "PAUSED";
                pauseText.gameObject.SetActive(true);
            }
        }

        else
        {
            Time.timeScale = 1;
            if (pauseText != null)
            {
                pauseText.gameObject.SetActive(false);
            }
        }
    }

    public void GoToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
