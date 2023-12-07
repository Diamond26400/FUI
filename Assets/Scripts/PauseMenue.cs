using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PauseMenue : MonoBehaviour
{
    public GameObject pauseUi;
    public KeyCode pauseKey = KeyCode.Escape;
    private bool Ispaused;
    public Restart restart;
    // Start is called before the first frame update
    void Start()
    {
        pauseUi.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        Ispaused = !Ispaused;

        if (Ispaused)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0f; // Pause the game by setting time scale to 0
        pauseUi.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Resume the game by setting time scale back to 1
        pauseUi.SetActive(false);
    }

    // Add methods for resume, restart, and quit buttons as needed
    public void ResumeButtonClicked()
    {
        ResumeGame();
    }

    public void RestartButtonClicked()
    {
        restart.Reload();// Add logic to restart the game
    }

    public void QuitButtonClicked()
    {
        // Add logic to quit the game
        Application.Quit(); // Note: This only works in a build, not in the Unity Editor
    }
}
