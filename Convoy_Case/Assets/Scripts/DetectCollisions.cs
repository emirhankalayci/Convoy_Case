
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectCollisions : MonoBehaviour
{
    public int length;
    // Start is called before the first frame update
    private void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        length = GameObject.FindGameObjectsWithTag("Guards").Length;
        Debug.Log(length);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Cars")
        {
            Destroy(gameObject);
        }      
    }


}
