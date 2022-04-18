using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountMedalScript : MonoBehaviour
{
    public Text medalText;
    DetectCollisions detectCollisions;

    private void Awake()
    {
        detectCollisions = FindObjectOfType<DetectCollisions>();
    }

  

    private void Update()
    {
        medalText.text = detectCollisions.length.ToString() + " " + "medals you won";
      
    }
}
