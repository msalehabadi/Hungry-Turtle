using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMusic : MonoBehaviour
{
     [Header("---------- Scene Music ----------")]
    public AudioClip backgroundMusic;

    private void Start()
    {
        // Ensure AudioManager exists and set the music
        // if (AudioManager.instance != null)
        // {
        //     AudioManager.instance.PlayMusic(backgroundMusic);
        // }

    }
}
