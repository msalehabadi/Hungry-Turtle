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
<<<<<<< HEAD

    [SerializeField] private int scoreValue1 = 10;
    [SerializeField] private float destroyDelay = 0.5f; // Delay time for destruction

=======
>>>>>>> origin/main
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        rb.velocity = Vector2.down * speed;
    }

<<<<<<< HEAD
=======
    // Update is called once per frame
>>>>>>> origin/main
    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }

<<<<<<< HEAD

    private IEnumerator DelayedDestroy(float delay)
    {
        Debug.Log("Starting DelayedDestroy");
        yield return new WaitForSeconds(delay);
        Debug.Log("Destroying meteor");
=======
    public override void HurtSequence()
    {
       
    }

    public override void DeathSequence()
    {
        base.DeathSequence();
        Instantiate(explostionPrefeb, transform.position, transform.rotation);
        if(powerUpSpawner != null)
            powerUpSpawner.SpawnPowerUp(transform.position);
>>>>>>> origin/main
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D otherColl)
    {
<<<<<<< HEAD
        Debug.Log("Meteor OnTriggerEnter2D");
        if (otherColl.CompareTag("Player"))
        {
            EndGameManager.endManager.UpdateScore(scoreValue1);
            AudioManager.instance.PlaySFX(AudioManager.instance.eating);
            StartCoroutine(DelayedDestroy(destroyDelay));
            Destroy(gameObject);
        }
=======
        if (otherColl.CompareTag("Player"))
        {
            PlayerStats player = otherColl.GetComponent<PlayerStats>();
            player.PlayerTakeDamage(damage);
            Destroy(gameObject);
        }
        
>>>>>>> origin/main
    }

    private void OnBecameInvisible()
    {
<<<<<<< HEAD
        Debug.Log("Meteor OnBecameInvisible");
=======
>>>>>>> origin/main
        Destroy(gameObject);
    }
}
