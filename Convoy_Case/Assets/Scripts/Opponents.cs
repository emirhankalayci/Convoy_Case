using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponents : MonoBehaviour
{
    public GameObject Explosion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Guards")
        {
            Instantiate(Explosion,transform.position, Quaternion.identity);    
            StartCoroutine(destroyObject());
        }

        if (other.gameObject.tag == "President")
        {
            Instantiate(Explosion, transform.position, Quaternion.identity);
            StartCoroutine(destroyObject());
            
        }
    }
    IEnumerator destroyObject()
    {
        Destroy(gameObject);
       
        yield return new WaitForSeconds(0.2f);


    }
}