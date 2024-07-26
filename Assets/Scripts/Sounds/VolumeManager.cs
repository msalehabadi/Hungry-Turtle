using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeManager : MonoBehaviour
{
    public AudioSource audioSource; // Ensure this is assigned in the Inspector
    public Slider volumeSlider; // Ensure this is assigned in the Inspector

    private float musicVolume = 1f;

    private void Start()
    {
        // Ensure audioSource is not null
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                Debug.LogError("AudioSource component is missing or not assigned.");
                return;
            }
        }

        // Ensure volumeSlider is not null
        if (volumeSlider == null)
        {
            Debug.LogError("VolumeSlider is not assigned.");
            return;
        }

        // Retrieve and set volume
        musicVolume = PlayerPrefs.GetFloat("volume", 0.5f); // Default to 0.5 if "volume" key doesn't exist
        audioSource.volume = musicVolume;
        volumeSlider.value = musicVolume;

        // Add listener to volumeSlider to update volume
        volumeSlider.onValueChanged.AddListener(VolumeUpdater);

        // Play audio
        audioSource.Play();
    }

    private void VolumeUpdater(float volume)
    {
        musicVolume = volume;
        audioSource.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);
    }
}
