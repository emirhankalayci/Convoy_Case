using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    
public class FinishLine : MonoBehaviour
{
    public GameObject canvas2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "President")
        {
            canvas2.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
