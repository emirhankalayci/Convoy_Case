using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int number = 0;
    public GameObject canvas;

   
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
        if (other.gameObject.tag == "Cars")
        {
            number++;

            if (number==2)
            {
                Destroy(gameObject);
                canvas.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        

    }


}
