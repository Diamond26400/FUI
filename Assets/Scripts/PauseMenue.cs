using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PauseMenue : MonoBehaviour
{
    public GameObject IngameUi;
    public KeyCode pauseKey = KeyCode.Escape;
    private bool Ispaused;
    public Restart restart;
     public  Clickswipe swipe;
    // public TextMeshProUGUI pause;
    public TextMeshProUGUI pause;
    // Start is called before the first frame update
    void Start()
    {
        IngameUi.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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
            swipe = null;
        }
        else
        {
            ResumeGame();
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0f; // Pause the game by setting time scale to 0
        IngameUi.gameObject.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Resume the game by setting time scale back to 1
        IngameUi.SetActive(false);
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
