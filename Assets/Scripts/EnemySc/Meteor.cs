using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : Enemy
{
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;
    private float speed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private ScriptableObjExamples powerUpSpawner;

    [SerializeField] private int scoreValue1 = 10;
    [SerializeField] private float destroyDelay = 0.5f; // Delay time for destruction

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        rb.velocity = Vector2.down * speed;
    }

    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }


    private IEnumerator DelayedDestroy(float delay)
    {
        Debug.Log("Starting DelayedDestroy");
        yield return new WaitForSeconds(delay);
        Debug.Log("Destroying meteor");
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D otherColl)
    {
        Debug.Log("Meteor OnTriggerEnter2D");
        if (otherColl.CompareTag("Player"))
        {
            EndGameManager.endManager.UpdateScore(scoreValue1);
            AudioManager.instance.PlaySFX(AudioManager.instance.eating);
            StartCoroutine(DelayedDestroy(destroyDelay));
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Debug.Log("Meteor OnBecameInvisible");
        Destroy(gameObject);
    }
}
