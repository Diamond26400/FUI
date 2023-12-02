using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Volume : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        // Set the slider value to the current volume
        volumeSlider.value = audioSource.volume;

        // Subscribe to the slider's OnValueChanged event
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    // Update is called once per frame
    void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
