using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explostion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2); //2 means 2 sec
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
