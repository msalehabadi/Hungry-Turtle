using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float parallaxSpeed;

    private float spriteHeight;
    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
        spriteHeight = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        transform.Translate(Vector3.up * parallaxSpeed * Time.deltaTime);

        if (transform.position.y > startPos.y + spriteHeight)
=======
        transform.Translate(Vector3.down * parallaxSpeed * Time.deltaTime);

        if (transform.position.y < startPos.y - spriteHeight)
>>>>>>> origin/main
        {
            transform.position = startPos;
        }
        
    }
}
