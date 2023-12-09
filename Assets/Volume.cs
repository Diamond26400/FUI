using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Volume : MonoBehaviour
{
    public Slider volumeSlider;
    public GameObject pauseMenu;

   public  void Update()
    {
        // Check for input or conditions to pause the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

     public void PauseGame()
    {
        // Toggle the visibility of the pause menu and volume slider
        bool isPaused = !pauseMenu.activeSelf;
        pauseMenu.SetActive(isPaused);
        volumeSlider.gameObject.SetActive(isPaused);

        // You can add more functionality here, like stopping time or other pause-related actions
        Time.timeScale = isPaused ? 0 : 1;
    }

    public void SetVolume(float volume)
    {
        // Implement your volume setting logic here
        Debug.Log("Setting volume to: " + volume);
    }
}