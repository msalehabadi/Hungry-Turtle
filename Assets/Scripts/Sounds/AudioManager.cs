<<<<<<< HEAD
=======
using System.Collections;
using System.Collections.Generic;
>>>>>>> origin/main
using UnityEngine;

public class AudioManager : MonoBehaviour
{
<<<<<<< HEAD
    [Header("---------- Audio Source ----------")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;

    [Header("---------- Audio clip ----------")]
    public AudioClip mainMenuMusic;
    public AudioClip explosion;
    public AudioClip levelBuble;
    public AudioClip powerUp;
    public AudioClip tapButton;
    public AudioClip eating;

    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("AudioManager instance created.");
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if (musicSource != null && mainMenuMusic != null)
        {
            musicSource.clip = mainMenuMusic;
            musicSource.Play();
            Debug.Log("Main menu music started.");
        }
        else
        {
            Debug.LogError("MusicSource or MainMenuMusic is missing.");
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        if (SFXSource != null && clip != null)
        {
            SFXSource.PlayOneShot(clip);
            Debug.Log("Playing SFX: " + clip.name);
        }
        else
        {
            Debug.LogError("SFXSource or AudioClip is missing.");
        }
    }
=======
        [Header("---------- Audio Source ----------")]
        [SerializeField] AudioSource musicSource;
        [SerializeField] AudioSource SFXSource;
        

        [Header("---------- Audio clip ----------")]
        public AudioClip mainMenuMusic;
        public AudioClip levelMusic;
        public AudioClip explosion;
        public AudioClip laserGun;
        public AudioClip powerUp;
        public AudioClip tapButton;

        public static AudioManager instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);

            }
            else
            {
                Destroy(gameObject);
            }
        }
        private void Start()
        {
            musicSource.clip = mainMenuMusic;
            musicSource.Play();
        }

        public void PlaySFX(AudioClip clip)
        {
            SFXSource.PlayOneShot(clip);
        }
>>>>>>> origin/main
}
