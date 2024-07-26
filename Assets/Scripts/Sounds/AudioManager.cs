using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
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
}
