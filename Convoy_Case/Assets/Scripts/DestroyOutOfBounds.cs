using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float lowerBound = -50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an obect goes past the players view in the game, remove that object
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }     
    }
}
