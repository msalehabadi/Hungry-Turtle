using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleAudiotest : MonoBehaviour
{
    [SerializeField] private AudioClip testClip;

    void Start()
    {
        if (testClip == null)
        {
            Debug.LogError("Test audio clip is not assigned.");
            return;
        }

        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.clip = testClip;
            audioSource.Play();
            Debug.Log("Playing test audio clip.");
        }
        else
        {
            Debug.LogError("Failed to create AudioSource.");
        }
    }
}
